using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class ParaPressureMaintInfoDto : ViewModelBase
    {
        private double m_Pressure;
        public double Pressure
        {
            get { return m_Pressure; }
            set
            {
                if (m_Pressure != value)
                {
                    m_Pressure = value;
                    RaisePropertyChanged(() => Pressure);
                }
            }
        }

        public string StrPressure
        {
            get
            {
                return Pressure.ToString("0.000");
            }
        }

        private double m_Time;
        public double Time
        {
            get { return m_Time; }
            set
            {
                if (m_Time != value)
                {
                    m_Time = value;
                    RaisePropertyChanged(() => Time);
                }
            }
        }

        public string StrTime
        {
            get
            {
                return Time.ToString("0.000");
            }
        }

        private double m_PreDelayTime;
        public double PreDelayTime
        {
            get { return m_PreDelayTime; }
            set
            {
                if (m_PreDelayTime != value)
                {
                    m_PreDelayTime = value;
                    RaisePropertyChanged(() => PreDelayTime);
                }
            }
        }

        public string StrPreDelayTime
        {
            get
            {
                return PreDelayTime.ToString("0.000");
            }
        }

        private double m_ChangeMode;
        public double ChangeMode
        {
            get { return m_ChangeMode; }
            set
            {
                if (m_ChangeMode != value)
                {
                    m_ChangeMode = value;
                    RaisePropertyChanged(() => ChangeMode);
                }
            }
        }

        private double m_ChangePressure;
        public double ChangePressure
        {
            get { return m_ChangePressure; }
            set
            {
                if (m_ChangePressure != value)
                {
                    m_ChangePressure = value;
                    RaisePropertyChanged(() => ChangePressure);
                }
            }
        }

        public string StrChangePressure
        {
            get
            {
                return ChangePressure.ToString("0.000");
            }
        }
    }
}
