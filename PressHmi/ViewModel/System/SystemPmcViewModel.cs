using FanucCnc.Enum;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using FanucCnc;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using FanucCnc.Model;
using Newtonsoft.Json;
using System.IO;

namespace PressHmi.ViewModel
{
    public class SystemPmcViewModel
    {
        Fanuc fanuc;
        public List<SystemPmcItemViewModel> PmcNodes { get; set; }

        public SystemPmcViewModel(Fanuc fanuc)
        {
            this.fanuc = fanuc;
            PmcNodes = new List<SystemPmcItemViewModel>();
            LoadData();
        }
        public ICommand SaveCommand
        {
            get { return new GalaSoft.MvvmLight.Command.RelayCommand(SaveConfig); }
        }
        private void SaveConfig()
        {
            var type = fanuc.CurPmcBom.GetType();
            foreach (PropertyInfo item in type.GetProperties())
            {
                var limit = item.GetValue(fanuc.CurPmcBom) as PmcBomItem;
                if (limit == null)
                {
                    limit = new PmcBomItem();
                    item.SetValue(fanuc.CurPmcBom, limit);
                }
                var prop = PmcNodes.FirstOrDefault(d => d.PropertyName == item.Name);
                if (prop != null)
                {
                    limit.Adr = prop.Adr;
                    limit.ConversionFactor = prop.ConversionFactor;
                    limit.Bit = prop.Bit;
                }


            }
            var jsonLimitBom = JsonConvert.SerializeObject(fanuc.CurPmcBom, Formatting.Indented);
            using (StreamWriter sw = new StreamWriter(@"pmcbom.cfg", false))
            {
                sw.Write(jsonLimitBom);
            }

        }
        private void LoadData()
        {
            var type = fanuc.CurPmcBom.GetType();
            foreach (PropertyInfo item in type.GetProperties())
            {
                var attributes = item.GetCustomAttribute<DisplayAttribute>();

                if (attributes != null && (attributes.GetAutoGenerateField() ?? true))
                {
                    var limit = item.GetValue(fanuc.CurPmcBom) as PmcBomItem;
                    if (limit == null)
                    {
                        continue;
                    }
                    var node = new SystemPmcItemViewModel()
                    {
                        PropertyName = item.Name,
                        Title = attributes.Name,
                        Adr = limit.Adr,
                        Bit = limit.Bit,
                        ConversionFactor = limit.ConversionFactor ?? 0.0,
                        DataType = limit.DataType

                    };
                    node.OpenDialogEvent += Node_OpenDialogEvent;
                    PmcNodes.Add(node);
                }

            }
        }
        public event Action<SystemPmcItemViewModel, string, string> OpenDialogWindowEvent;
        private void Node_OpenDialogEvent(SystemPmcItemViewModel arg1, string arg2)
        {
            var prop = arg1.GetType().GetProperty(arg2);
            OpenDialogWindowEvent?.Invoke(arg1, arg2, prop.GetValue(arg1, null)?.ToString());
        }
    }


    public class SystemPmcItemViewModel : ViewModelBase
    {
        public string PropertyName { get; set; }
        public string Title { get; set; }

        public PmcDataTypeEnum DataType { get; set; }

        public Visibility ByteVisibility { get { return DataType == PmcDataTypeEnum.BYTE ? Visibility.Visible : Visibility.Collapsed; } }
        public Visibility WordVisibility { get { return DataType == PmcDataTypeEnum.WORD ? Visibility.Visible : Visibility.Collapsed; } }
        public Visibility LongVisibility { get { return DataType == PmcDataTypeEnum.LONG ? Visibility.Visible : Visibility.Collapsed; } }
        public Visibility BitVisibility { get { return DataType == PmcDataTypeEnum.BIT ? Visibility.Visible : Visibility.Collapsed; } }


        private ushort adr;

        public ushort Adr
        {
            get { return adr; }
            set
            {
                if (adr != value)
                {
                    adr = value;
                    RaisePropertyChanged(() => Adr);
                }
            }
        }


        private ushort bit;

        public ushort Bit
        {
            get { return bit; }
            set
            {
                if (bit != value)
                {
                    bit = value;
                    RaisePropertyChanged(() => Bit);
                }
            }
        }

        private double conversionFactor;

        public double ConversionFactor
        {
            get { return conversionFactor; }
            set
            {
                if (conversionFactor != value)
                {
                    conversionFactor = value;
                    RaisePropertyChanged(() => ConversionFactor);
                }
            }
        }


        public ICommand ShowDialogCommand
        {
            get
            {
                return new RelayCommand<string>((s) =>
                {
                    OpenDialogEvent?.Invoke(this, s);
                });
            }
        }

        public event Action<SystemPmcItemViewModel, string> OpenDialogEvent;
    }
}
