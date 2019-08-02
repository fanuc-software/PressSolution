using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class ParaDieChangeInfoDto : ViewModelBase
    {
        public double Increment { get; set; }

        private int m_RapidFeed;
        public int RapidFeed
        {
            get { return m_RapidFeed; }
            set
            {
                if (m_RapidFeed != value)
                {
                    m_RapidFeed = value;
                    RaisePropertyChanged(() => RapidFeed);
                }
            }
        }

        private int m_JogFeed;
        public int JogFeed
        {
            get { return m_JogFeed; }
            set
            {
                if (m_JogFeed != value)
                {
                    m_JogFeed = value;
                    RaisePropertyChanged(() => JogFeed);
                }
            }
        }

        private double m_InstallDieHighSet;
        public double InstallDieHighSet
        {
            get { return m_InstallDieHighSet; }
            set
            {
                if (m_InstallDieHighSet != value)
                {
                    m_InstallDieHighSet = value;
                    RaisePropertyChanged(() => InstallDieHighSet);
                }
            }
        }

        public string StrInstallDieHighSet
        {
            get
            {
                return InstallDieHighSet.ToString("0.00");
            }
        }

        private double m_InstallDieHighActual;
        public double InstallDieHighActual
        {
            get { return m_InstallDieHighActual; }
            set
            {
                if (m_InstallDieHighActual != value)
                {
                    m_InstallDieHighActual = value;
                    RaisePropertyChanged(() => InstallDieHighActual);
                }
            }
        }

        public string StrInstallDieHighActual
        {
            get
            {
                return InstallDieHighActual.ToString("0.00");
            }
        }

        private double m_CylinderpRressureSet;
        public double CylinderpRressureSet
        {
            get { return m_CylinderpRressureSet; }
            set
            {
                if (m_CylinderpRressureSet != value)
                {
                    m_CylinderpRressureSet = value;
                    RaisePropertyChanged(() => CylinderpRressureSet);
                }
            }
        }

        public string StrCylinderpRressureSet
        {
            get
            {
                return CylinderpRressureSet.ToString("0.0");
            }
        }

        private double m_CylinderpRressureActual;
        public double CylinderpRressureActual
        {
            get { return m_CylinderpRressureActual; }
            set
            {
                if (m_CylinderpRressureActual != value)
                {
                    m_CylinderpRressureActual = value;
                    RaisePropertyChanged(() => CylinderpRressureActual);
                }
            }
        }

        public string StrCylinderpRressureActual
        {
            get
            {
                return CylinderpRressureActual.ToString("0.0");
            }
        }

        private double m_DieWeight;
        public double DieWeight
        {
            get { return m_DieWeight; }
            set
            {
                if (m_DieWeight != value)
                {
                    m_DieWeight = value;
                    RaisePropertyChanged(() => DieWeight);
                }
            }
        }

        public string StrDieWeight
        {
            get
            {
                return DieWeight.ToString("0.0");
            }
        }

        private double m_LoaderSafePosition;
        public double LoaderSafePosition
        {
            get { return m_LoaderSafePosition; }
            set
            {
                if (m_LoaderSafePosition != value)
                {
                    m_LoaderSafePosition = value;
                    RaisePropertyChanged(() => LoaderSafePosition);
                }
            }
        }

        public string StrLoaderSafePosition
        {
            get
            {
                return LoaderSafePosition.ToString("0.0");
            }
        }
    }
}
