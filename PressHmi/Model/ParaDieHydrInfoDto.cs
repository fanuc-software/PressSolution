using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class ParaDieHydrInfoDto : ViewModelBase
    {
        private double m_Mode;
        public double Mode
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

        private double m_PushPos;
        public double PushPos
        {
            get { return m_PushPos; }
            set
            {
                if (m_PushPos != value)
                {
                    m_PushPos = value;
                    RaisePropertyChanged(() => PushPos);
                }
            }
        }

        private double m_PushDelayTime;
        public double PushDelayTime
        {
            get { return m_PushDelayTime; }
            set
            {
                if (m_PushDelayTime != value)
                {
                    m_PushDelayTime = value;
                    RaisePropertyChanged(() => PushDelayTime);
                }
            }
        }

        private double m_ActualPressure;
        public double ActualPressure
        {
            get { return m_ActualPressure; }
            set
            {
                if (m_ActualPressure != value)
                {
                    m_ActualPressure = value;
                    RaisePropertyChanged(() => ActualPressure);
                }
            }
        }

        private double m_ActualPos;
        public double ActualPos
        {
            get { return m_ActualPos; }
            set
            {
                if (m_ActualPos != value)
                {
                    m_ActualPos = value;
                    RaisePropertyChanged(() => ActualPos);
                }
            }
        }

        private double m_Run;
        public double Run
        {
            get { return m_Run; }
            set
            {
                if (m_Run != value)
                {
                    m_Run = value;
                    RaisePropertyChanged(() => Run);
                }
            }
        }

        private double m_State;
        public double State
        {
            get { return m_State; }
            set
            {
                if (m_State != value)
                {
                    m_State = value;
                    RaisePropertyChanged(() => State);
                }
            }
        }

    }
}
