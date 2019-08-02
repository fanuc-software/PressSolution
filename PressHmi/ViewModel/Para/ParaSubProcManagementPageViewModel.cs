using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Ioc;
using Newtonsoft.Json;
using AutoMapper;
using PressHmi.Model;
using PressHmi.View;
using FanucCnc;
using FanucCnc.Model;
using System.Windows.Forms;
using System.IO;

namespace PressHmi.ViewModel
{
    public class ParaSubProcManagementPageViewModel : MyBaseViewModel
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }
        public ICommand RefreshFileCommand { get; set; }
        public ICommand SaveToPcCommand { get; set; }
        public ICommand LoadAndShowCommand { get; set; }
        public ICommand SaveAndApplicationCommand { get; set; }
        public ICommand FileFolderCommand { get; set; }

        private string m_CurFileFolder;
        public string CurFileFolder
        {
            get { return m_CurFileFolder; }
            set
            {
                if (m_CurFileFolder != value)
                {
                    m_CurFileFolder = value;
                    RaisePropertyChanged(() => CurFileFolder);
                }
            }
        }

        private ObservableCollection<ParaProcFileDto> m_ProcFiles = new ObservableCollection<ParaProcFileDto>();
        public ObservableCollection<ParaProcFileDto> ProcFiles
        {
            get { return m_ProcFiles; }
            set
            {
                if (m_ProcFiles != value)
                {
                    m_ProcFiles = value;
                    RaisePropertyChanged(() => m_ProcFiles);
                }
            }
        }

        private ParaProcFileDto m_SelProcFile ;
        public ParaProcFileDto SelProcFile
        {
            get { return m_SelProcFile; }
            set
            {
                if (m_SelProcFile != value)
                {
                    m_SelProcFile = value;
                    RaisePropertyChanged(() => SelProcFile);
                }
            }
        }

        private ObservableCollection<RecipesInfoItemDto> m_RecipesInfos = new ObservableCollection<RecipesInfoItemDto>();
        public ObservableCollection<RecipesInfoItemDto> RecipesInfos
        {
            get { return m_RecipesInfos; }
            set
            {
                if (m_RecipesInfos != value)
                {
                    m_RecipesInfos = value;
                    RaisePropertyChanged(() => RecipesInfos);
                }
            }
        }

        public ParaSubProcManagementPageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);
            RefreshFileCommand = new RelayCommand(OnRefreshFile);
            SaveToPcCommand = new RelayCommand(OnSaveToPc);
            LoadAndShowCommand = new RelayCommand(OnLoadAndShow);
            SaveAndApplicationCommand = new RelayCommand(OnSaveAndApplication);
            FileFolderCommand =new RelayCommand(OnFileFolder);

            GetProcFiles(CurFileFolder);

            Messenger.Default.Register<RecipesInfo>(this, "ParaRecipesInfoMsg", msg =>
            {
                foreach(var info in msg.PmcBoms)
                {
                    var rec = RecipesInfos.Where(x => x.Id == info.Id && x.PmcType == true).FirstOrDefault();

                    if (rec == null)
                    {

                        DispatcherHelper.CheckBeginInvokeOnUI(() =>
                        {
                            RecipesInfos.Add(new RecipesInfoItemDto()
                            {
                                Id = info.Id,
                                PmcType = true,
                                Name=info.Name,
                                PmcBomItem = new PmcBomItemRecipesDto()
                                {
                                    Id = info.Id,
                                    Adr = info.Adr,
                                    AdrType = info.AdrType,
                                    Bit = info.Bit,
                                    ConversionFactor = info.ConversionFactor,
                                    DataType = info.DataType,
                                    IsRecipes = info.IsRecipes,
                                    Value = info.Value
                                }
                            });
                        });
                        
                    }
                    else
                    {
                        rec.Value = info.Value;

                        if (rec.Value != null && rec.FileValue != null)
                        {
                            double v1, v2;
                            var ret_v1 = double.TryParse(rec.Value, out v1);
                            var ret_v2 = double.TryParse(rec.FileValue, out v2);

                            if(ret_v1==false || ret_v2==false)
                            {
                                bool v3, v4;
                                var ret_v3 = bool.TryParse(rec.Value, out v3);
                                var ret_v4 = bool.TryParse(rec.FileValue, out v4);

                                if (ret_v3 == true && ret_v4 == true)
                                {
                                    if(v3==v4)
                                    {
                                        rec.UpDown = 0;
                                    }
                                }
                            }
                            else
                            {
                                rec.UpDown = v1 - v2;
                            }
                        }
                        else rec.UpDown = null;
                    }
                }

                foreach (var info in msg.MacroBoms)
                {
                    var rec = RecipesInfos.Where(x => x.Id == info.Id && x.MacroType == true).FirstOrDefault();

                    if (rec == null)
                    {
                        DispatcherHelper.CheckBeginInvokeOnUI(() =>
                        {
                            RecipesInfos.Add(new RecipesInfoItemDto()
                            {
                                Id = info.Id,
                                Name = info.Name,
                                MacroType = true,
                                MacroBomItem = new MacroBomItemRecipesDto()
                                {
                                    Id = info.Id,
                                    Adr = info.Adr,
                                    IsRecipes = info.IsRecipes,
                                    Value = info.Value
                                }
                            });
                        });
                    }
                    else
                    {
                        rec.Value = info.Value;

                        if (rec.Value != null && rec.FileValue != null)
                        {
                            double v1, v2;
                            var ret_v1 = double.TryParse(rec.Value, out v1);
                            var ret_v2 = double.TryParse(rec.FileValue, out v2);

                            if (ret_v1 == false || ret_v2 == false)
                            {
                                bool v3, v4;
                                var ret_v3 = bool.TryParse(rec.Value, out v3);
                                var ret_v4 = bool.TryParse(rec.FileValue, out v4);

                                if (ret_v3 == true && ret_v4 == true)
                                {
                                    if (v3 == v4)
                                    {
                                        rec.UpDown = 0;
                                    }
                                }
                            }
                            else
                            {
                                rec.UpDown = v1 - v2;
                            }
                        }
                        else rec.UpDown = null;
                    }
                }

                foreach(var info in RecipesInfos.Where(x=>x.PmcType==true))
                {

                    if (msg.PmcBoms.Where(x => x.Id == info.Id).Count() == 0)
                    {
                        DispatcherHelper.CheckBeginInvokeOnUI(() =>
                        {
                            RecipesInfos.Remove(info);
                        });
                    }
                        
                }

                foreach (var info in RecipesInfos.Where(x => x.MacroType == true))
                {
                    if (msg.MacroBoms.Where(x => x.Id == info.Id).Count() == 0)
                    {
                        DispatcherHelper.CheckBeginInvokeOnUI(() =>
                        {
                            RecipesInfos.Remove(info);
                        });
                    }
                }

            });
        }

        private void OnRefreshFile()
        {
            GetProcFiles(CurFileFolder);
        }

        private void OnFileFolder()
        {
            System.Windows.Forms.FolderBrowserDialog dlg = new System.Windows.Forms.FolderBrowserDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK || dlg.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                var last_c = dlg.SelectedPath.Substring(dlg.SelectedPath.Length - 1, 1);
                if (last_c != @"\") CurFileFolder = dlg.SelectedPath + @"\";
                else CurFileFolder = dlg.SelectedPath;

                GetProcFiles(CurFileFolder);
            }
        }

        private void OnLoaded()
        {
            _fanuc.ChangePageEvent(pararecipes: true);
        }

        private void OnUnloaded()
        {

        }

        private void OnSaveToPc()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Recipes files(*.recip)|*.recip";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName.Trim() == "")
                {
                    
                    return;
                }
                _fanuc.SaveRecipesToPC(saveFileDialog.FileName);
            }
        }

        private void OnLoadAndShow()
        {
            if(SelProcFile==null)
            {
                return;
            }

            string file_buf = "";
            using (StreamReader sr = new StreamReader(SelProcFile.Path, true))
            {
                file_buf = sr.ReadToEnd();
            }

            var recps = JsonConvert.DeserializeObject<RecipesInfo>(file_buf);

            foreach(var pmc_item in recps.PmcBoms)
            {
                try
                {
                    var dto_info = RecipesInfos.Where(x => x.Id == pmc_item.Id).FirstOrDefault();
                    if (dto_info!=null)
                    {
                        if (dto_info.Name != pmc_item.Name || dto_info.PmcType == false || dto_info.PmcBomItem.Adr != pmc_item.Adr
                            || dto_info.PmcBomItem.AdrType != pmc_item.AdrType || dto_info.PmcBomItem.Bit != pmc_item.Bit
                            || dto_info.PmcBomItem.ConversionFactor != pmc_item.ConversionFactor || dto_info.PmcBomItem.DataType != pmc_item.DataType)
                        {
                            dto_info.IsConsistent = false;
                        }
                        else dto_info.IsConsistent = true;

                        dto_info.FileValue = pmc_item.Value;
                    }
                }
                catch
                {

                }
            }

            foreach (var macro_item in recps.MacroBoms)
            {
                try
                {
                    var dto_info = RecipesInfos.Where(x => x.Id == macro_item.Id).FirstOrDefault();
                    if (dto_info != null)
                    {
                        if (dto_info.Name != macro_item.Name || dto_info.MacroType == false || dto_info.MacroBomItem.Adr != macro_item.Adr)
                        {
                            dto_info.IsConsistent = false;
                        }
                        else dto_info.IsConsistent = true;

                        dto_info.FileValue = macro_item.Value;
                    }
                }
                catch
                {

                }
            }
        }

        private void OnSaveAndApplication()
        {

        }

        private void GetProcFiles(string root)
        {
            try
            {
                var files = System.IO.Directory.GetFiles(root, "*.recip", SearchOption.TopDirectoryOnly);

                ProcFiles.Clear();
                foreach (string f in files)
                {
                    ParaProcFileDto pf = new ParaProcFileDto();
                    pf.Name = System.IO.Path.GetFileName(f);
                    pf.Path = f;
                    ProcFiles.Add(pf);
                }
            }
            catch
            {
            }
        }
    }
}
