using GalaSoft.MvvmLight;


namespace PressHmi.Model
{
    public class SParaMachineInfoDto : ViewModelBase
    {
        private double m_MaxWeight;
        public double MaxWeight
        {
            get { return m_MaxWeight; }
            set
            {
                if (m_MaxWeight != value)
                {
                    m_MaxWeight = value;
                    RaisePropertyChanged(() => MaxWeight);
                }
            }
        }

        private double m_MaxTemperature;
        public double MaxTemperature
        {
            get { return m_MaxTemperature; }
            set
            {
                if (m_MaxTemperature != value)
                {
                    m_MaxTemperature = value;
                    RaisePropertyChanged(() => MaxTemperature);
                }
            }
        }

        private double m_MaxError;
        public double MaxError
        {
            get { return m_MaxError; }
            set
            {
                if (m_MaxError != value)
                {
                    m_MaxError = value;
                    RaisePropertyChanged(() => MaxError);
                }
            }
        }

        private double m_PressureSensorPara;
        public double PressureSensorPara
        {
            get { return m_PressureSensorPara; }
            set
            {
                if (m_PressureSensorPara != value)
                {
                    m_PressureSensorPara = value;
                    RaisePropertyChanged(() => PressureSensorPara);
                }
            }
        }

        private double m_BalanceCylinderAnalog;
        public double BalanceCylinderAnalog
        {
            get { return m_BalanceCylinderAnalog; }
            set
            {
                if (m_BalanceCylinderAnalog != value)
                {
                    m_BalanceCylinderAnalog = value;
                    RaisePropertyChanged(() => BalanceCylinderAnalog);
                }
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

        private double m_OverflowDelay;
        public double OverflowDelay
        {
            get { return m_OverflowDelay; }
            set
            {
                if (m_OverflowDelay != value)
                {
                    m_OverflowDelay = value;
                    RaisePropertyChanged(() => OverflowDelay);
                }
            }
        }

        private double m_PressureDiffPara;
        public double PressureDiffPara
        {
            get { return m_PressureDiffPara; }
            set
            {
                if (m_PressureDiffPara != value)
                {
                    m_PressureDiffPara = value;
                    RaisePropertyChanged(() => PressureDiffPara);
                }
            }
        }

        private double m_PressureLowAlarm;
        public double PressureLowAlarm
        {
            get { return m_PressureLowAlarm; }
            set
            {
                if (m_PressureLowAlarm != value)
                {
                    m_PressureLowAlarm = value;
                    RaisePropertyChanged(() => PressureLowAlarm);
                }
            }
        }


        private double m_LubricateDetect;
        public double LubricateDetect
        {
            get { return m_LubricateDetect; }
            set
            {
                if (m_LubricateDetect != value)
                {
                    m_LubricateDetect = value;
                    RaisePropertyChanged(() => LubricateDetect);
                }
            }
        }

    }
}
