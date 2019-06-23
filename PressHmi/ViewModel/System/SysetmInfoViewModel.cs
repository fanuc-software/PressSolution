using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Reflection;

using GalaSoft.MvvmLight.Command;
namespace PressHmi.ViewModel
{
    public class SysetmInfoViewModel : ViewModelBase
    {
        private string ip;

        [Display(Name = "IP地址")]
        public string Ip
        {
            get { return ip; }
            set
            {
                if (ip != value)
                {
                    ip = value;
                    RaisePropertyChanged(() => Ip);
                }
            }
        }


        private ushort port;
        [Display(Name = "Port")]

        public ushort Port
        {
            get { return port; }
            set
            {
                if (port != value)
                {
                    port = value;
                    RaisePropertyChanged(() => Port);
                }
            }
        }


        private ushort timeout;
        [Display(Name = "Timeout")]

        public ushort Timeout
        {
            get { return timeout; }
            set
            {
                if (timeout != value)
                {
                    timeout = value;
                    RaisePropertyChanged(() => Timeout);
                }
            }
        }


        private double increment;
        [Display(Name = "Increment")]


        public double Increment
        {
            get { return increment; }
            set
            {
                if (increment != value)
                {
                    increment = value;
                    RaisePropertyChanged(() => Increment);
                }
            }
        }

        private string csdFolder;

        [Display(Name = "CsdFolder")]

        public string CsdFolder
        {
            get { return csdFolder; }
            set
            {
                if (csdFolder != value)
                {
                    csdFolder = value;
                    RaisePropertyChanged(() => CsdFolder);
                }
            }
        }

        private int sciChartXTimeMax;

        [Display(Name = "SciChartXTimeMax")]

        public int SciChartXTimeMax
        {
            get { return sciChartXTimeMax; }
            set
            {
                if (sciChartXTimeMax != value)
                {
                    sciChartXTimeMax = value;
                    RaisePropertyChanged(() => SciChartXTimeMax);
                }
            }
        }



        private short realTimeSciChartInflgAdrType;

        [Display(Name = "RealTimeSciChartInflgAdrType")]


        public short RealTimeSciChartInflgAdrType
        {
            get { return realTimeSciChartInflgAdrType; }
            set
            {
                if (realTimeSciChartInflgAdrType != value)
                {
                    realTimeSciChartInflgAdrType = value;
                    RaisePropertyChanged(() => RealTimeSciChartInflgAdrType);
                }
            }
        }



        private ushort realTimeSciChartInflgAdr;

        [Display(Name = "RealTimeSciChartInflgAdr")]


        public ushort RealTimeSciChartInflgAdr
        {
            get { return realTimeSciChartInflgAdr; }
            set
            {
                if (realTimeSciChartInflgAdr != value)
                {
                    realTimeSciChartInflgAdr = value;
                    RaisePropertyChanged(() => RealTimeSciChartInflgAdr);
                }
            }
        }


        private ushort realTimeSciChartInflgBit;

        [Display(Name = "RealTimeSciChartInflgBit")]

        public ushort RealTimeSciChartInflgBit
        {
            get { return realTimeSciChartInflgBit; }
            set
            {
                if (realTimeSciChartInflgBit != value)
                {
                    realTimeSciChartInflgBit = value;
                    RaisePropertyChanged(() => RealTimeSciChartInflgBit);
                }
            }
        }


        public ICommand ShowDialogCommand
        {
            get
            {
                return new RelayCommand<string>((s) =>
                {

                    var prop = this.GetType().GetProperty(s);
                    var display = prop.GetCustomAttribute<DisplayAttribute>();
                    var value = prop.GetValue(this, null).ToString();
                    OpenDialogWidnowEvent?.Invoke(s, value, display?.Name);
                });

            }
        }

        public event Action<string, string, string> OpenDialogWidnowEvent;

    }
}
