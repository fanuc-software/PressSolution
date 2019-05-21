using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class SParaEncodeInfoDto : ViewModelBase
    {
        private double m_IM_RESOLUTION;
        public double IM_RESOLUTION
        {
            get { return m_IM_RESOLUTION; }
            set
            {
                if (m_IM_RESOLUTION != value)
                {
                    m_IM_RESOLUTION = value;
                    RaisePropertyChanged(() => IM_RESOLUTION);
                }
            }
        }

        private double m_IM_MOVEPITCH;
        public double IM_MOVEPITCH
        {
            get { return m_IM_MOVEPITCH; }
            set
            {
                if (m_IM_MOVEPITCH != value)
                {
                    m_IM_MOVEPITCH = value;
                    RaisePropertyChanged(() => IM_MOVEPITCH);
                }
            }
        }
        private double m_IM_UPPOSITION;
        public double IM_UPPOSITION
        {
            get { return m_IM_MOVEPITCH; }
            set
            {
                if (m_IM_MOVEPITCH != value)
                {
                    m_IM_MOVEPITCH = value;
                    RaisePropertyChanged(() => IM_UPPOSITION);
                }
            }
        }
        private double m_IM_DOWNPOSITION;
        public double IM_DOWNPOSITION
        {
            get { return m_IM_DOWNPOSITION; }
            set
            {
                if (m_IM_DOWNPOSITION != value)
                {
                    m_IM_DOWNPOSITION = value;
                    RaisePropertyChanged(() => IM_DOWNPOSITION);
                }
            }
        }
        private double m_IM_SPEEDCHANGEPOSITION;
        public double IM_SPEEDCHANGEPOSITION
        {
            get { return m_IM_SPEEDCHANGEPOSITION; }
            set
            {
                if (m_IM_SPEEDCHANGEPOSITION != value)
                {
                    m_IM_SPEEDCHANGEPOSITION = value;
                    RaisePropertyChanged(() => IM_SPEEDCHANGEPOSITION);
                }
            }
        }
        private double m_IM_LIMITUP;
        public double IM_LIMITUP
        {
            get { return m_IM_LIMITUP; }
            set
            {
                if (m_IM_LIMITUP != value)
                {
                    m_IM_LIMITUP = value;
                    RaisePropertyChanged(() => IM_LIMITUP);
                }
            }
        }
        private double m_IM_LIMITDOWN;
        public double IM_LIMITDOWN
        {
            get { return m_IM_LIMITDOWN; }
            set
            {
                if (m_IM_LIMITDOWN != value)
                {
                    m_IM_LIMITDOWN = value;
                    RaisePropertyChanged(() => IM_LIMITDOWN);
                }
            }
        }
        private double m_IM_ERROR;
        public double IM_ERROR
        {
            get { return m_IM_ERROR; }
            set
            {
                if (m_IM_ERROR != value)
                {
                    m_IM_ERROR = value;
                    RaisePropertyChanged(() => IM_ERROR);
                }
            }
        }
        private double m_IM_DIRECTION;
        public double IM_DIRECTION
        {
            get { return m_IM_DIRECTION; }
            set
            {
                if (m_IM_DIRECTION != value)
                {
                    m_IM_DIRECTION = value;
                    RaisePropertyChanged(() => IM_DIRECTION);
                }
            }
        }
        private double m_AC_RESOLUTION;
        public double AC_RESOLUTION
        {
            get { return m_AC_RESOLUTION; }
            set
            {
                if (m_AC_RESOLUTION != value)
                {
                    m_AC_RESOLUTION = value;
                    RaisePropertyChanged(() => AC_RESOLUTION);
                }
            }
        }
        private double m_AC_MOVEPITCH;
        public double AC_MOVEPITCH
        {
            get { return m_AC_MOVEPITCH; }
            set
            {
                if (m_AC_MOVEPITCH != value)
                {
                    m_AC_MOVEPITCH = value;
                    RaisePropertyChanged(() => AC_MOVEPITCH);
                }
            }
        }
        private double m_AC_UPPOSITION;
        public double AC_UPPOSITION
        {
            get { return m_AC_UPPOSITION; }
            set
            {
                if (m_AC_UPPOSITION != value)
                {
                    m_AC_UPPOSITION = value;
                    RaisePropertyChanged(() => AC_UPPOSITION);
                }
            }
        }
        private double m_AC_DOWNPOSITION;
        public double AC_DOWNPOSITION
        {
            get { return m_AC_DOWNPOSITION; }
            set
            {
                if (m_AC_DOWNPOSITION != value)
                {
                    m_AC_DOWNPOSITION = value;
                    RaisePropertyChanged(() => AC_DOWNPOSITION);
                }
            }
        }
        private double m_AC_LIMITUP;
        public double AC_LIMITUP
        {
            get { return m_AC_LIMITUP; }
            set
            {
                if (m_AC_LIMITUP != value)
                {
                    m_AC_LIMITUP = value;
                    RaisePropertyChanged(() => AC_LIMITUP);
                }
            }
        }
        private double m_AC_LIMITDOWN;
        public double AC_LIMITDOWN
        {
            get { return m_AC_LIMITDOWN; }
            set
            {
                if (m_AC_LIMITDOWN != value)
                {
                    m_AC_LIMITDOWN = value;
                    RaisePropertyChanged(() => AC_LIMITDOWN);
                }
            }
        }
        private double m_AC_ERROR;
        public double AC_ERROR
        {
            get { return m_AC_ERROR; }
            set
            {
                if (m_AC_ERROR != value)
                {
                    m_AC_ERROR = value;
                    RaisePropertyChanged(() => AC_ERROR);
                }
            }
        }
        private double m_AC_DIRECTION;
        public double AC_DIRECTION
        {
            get { return m_AC_DIRECTION; }
            set
            {
                if (m_AC_DIRECTION != value)
                {
                    m_AC_DIRECTION = value;
                    RaisePropertyChanged(() => AC_DIRECTION);
                }
            }
        }
    }
}
