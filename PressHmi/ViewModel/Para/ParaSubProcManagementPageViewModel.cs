using System;
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
using AutoMapper;
using PressHmi.Model;
using PressHmi.View;
using FanucCnc;
using FanucCnc.Model;
using System.Windows.Forms;
using System.IO;

namespace PressHmi.ViewModel
{
    public class ParaSubProcManagementPageViewModel : ViewModelBase
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
            _fanuc.ChangePageEvent(paraworkcount: true);
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

        }

        private void OnSaveAndApplication()
        {

        }

        private void GetProcFiles(string root)
        {
            try
            {
                var files = System.IO.Directory.GetFiles(root, "*.*", SearchOption.TopDirectoryOnly);

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
