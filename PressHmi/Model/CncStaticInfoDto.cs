using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class CncStaticInfoDto : ViewModelBase
    {

        public double Increment { get; set; }

        private int m_LampStatus;
        public int LampStatus
        {
            get { return m_LampStatus; }
            set
            {
                if (m_LampStatus != value)
                {
                    m_LampStatus = value;
                    RaisePropertyChanged(() => LampStatus);
                }
            }
        }

        private bool m_CncAlarmFlag;
        public bool CncAlarmFlag
        {
            get { return m_CncAlarmFlag; }
            set
            {
                if (m_CncAlarmFlag != value)
                {
                    m_CncAlarmFlag = value;
                    RaisePropertyChanged(() => CncAlarmFlag);
                }
            }
        }

        private List<CncAlarm> _cncAlarmList = new List<CncAlarm>();
        public List<CncAlarm> CncAlarmList
        {
            get { return _cncAlarmList; }
            set
            {
                if (_cncAlarmList != value)
                {
                    _cncAlarmList = value;
                    RaisePropertyChanged(() => CncAlarmList);
                }
            }
        }

        private int m_Mode;
        public int Mode
        {
            get { return m_Mode; }
            set
            {
                if (m_Mode != value)
                {
                    m_Mode = value;
                    RaisePropertyChanged(() => Mode);
                }
            }
        }

        private int m_MainStatus;
        public int MainStatus
        {
            get { return m_MainStatus; }
            set
            {
                if (m_MainStatus != value)
                {
                    m_MainStatus = value;
                    RaisePropertyChanged(() => MainStatus);
                }
            }
        }

        private double m_SliderPosition;
        public double SliderPosition
        {
            get { return m_SliderPosition; }
            set
            {
                if (m_SliderPosition != value)
                {
                    m_SliderPosition = value;
                    RaisePropertyChanged(() => SliderPosition);
                }
            }
        }

        private double m_SliderSpeed;
        public double SliderSpeed
        {
            get { return m_SliderSpeed; }
            set
            {
                if (m_SliderSpeed != value)
                {
                    m_SliderSpeed = value;
                    RaisePropertyChanged(() => SliderSpeed);
                }
            }
        }

        private double m_SliderPressure;
        public double SliderPressure
        {
            get { return m_SliderPressure; }
            set
            {
                if (m_SliderPressure != value)
                {
                    m_SliderPressure = value;
                    RaisePropertyChanged(() => SliderPressure);
                }
            }
        }

        public string StrSliderPressure
        {
            get
            {
                return SliderPressure.ToString("0.0");
            }
        }

        private double m_BalanceCylinderPressure;
        public double BalanceCylinderPressure
        {
            get { return m_BalanceCylinderPressure; }
            set
            {
                if (m_BalanceCylinderPressure != value)
                {
                    m_BalanceCylinderPressure = value;
                    RaisePropertyChanged(() => BalanceCylinderPressure);
                }
            }
        }

        private string m_WorkPartName;
        public string WorkPartName
        {
            get { return m_WorkPartName; }
            set
            {
                if (m_WorkPartName != value)
                {
                    m_WorkPartName = value;
                    RaisePropertyChanged(() => WorkPartName);
                }
            }
        }

        public string StrBalanceCylinderPressure
        {
            get
            {
                return BalanceCylinderPressure.ToString("0.0");
            }
        }

        private double m_InstallDieHigh;
        public double InstallDieHigh
        {
            get { return m_InstallDieHigh; }
            set
            {
                if (m_InstallDieHigh != value)
                {
                    m_InstallDieHigh = value;
                    RaisePropertyChanged(() => InstallDieHigh);
                }
            }
        }
        public string StrInstallDieHigh
        {
            get
            {
                return InstallDieHigh.ToString("0.00");
            }
        }

        private int m_TotalPiece;
        public int TotalPiece
        {
            get { return m_TotalPiece; }
            set
            {
                if (m_TotalPiece != value)
                {
                    m_TotalPiece = value;
                    RaisePropertyChanged(() => TotalPiece);
                }
            }
        }

        private int m_TotalWork;
        public int TotalWork
        {
            get { return m_TotalWork; }
            set
            {
                if (m_TotalWork != value)
                {
                    m_TotalWork = value;
                    RaisePropertyChanged(() => TotalWork);
                }
            }
        }

        private int m_DayPiece;
        public int DayPiece
        {
            get { return m_DayPiece; }
            set
            {
                if (m_DayPiece != value)
                {
                    m_DayPiece = value;
                    RaisePropertyChanged(() => DayPiece);
                }
            }
        }

        private int m_DayWork;
        public int DayWork
        {
            get { return m_DayWork; }
            set
            {
                if (m_DayWork != value)
                {
                    m_DayWork = value;
                    RaisePropertyChanged(() => DayWork);
                }
            }
        }
    }
}
