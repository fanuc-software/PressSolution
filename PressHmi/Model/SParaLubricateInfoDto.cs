using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class SParaLubricateInfoDto : ViewModelBase
    {
        private double m_CR_LubricateTime;
        public double CR_LubricateTime
        {
            get { return m_CR_LubricateTime; }
            set
            {
                if (m_CR_LubricateTime != value)
                {
                    m_CR_LubricateTime = value;
                    RaisePropertyChanged(() => CR_LubricateTime);
                }
            }
        }

        private double m_CR_SetLubricateInterval;
        public double CR_SetLubricateInterval
        {
            get { return m_CR_SetLubricateInterval; }
            set
            {
                if (m_CR_SetLubricateInterval != value)
                {
                    m_CR_SetLubricateInterval = value;
                    RaisePropertyChanged(() => CR_SetLubricateInterval);
                }
            }
        }

        private double m_CR_ActualLubricateInterval;
        public double CR_ActualLubricateInterval
        {
            get { return m_CR_ActualLubricateInterval; }
            set
            {
                if (m_CR_ActualLubricateInterval != value)
                {
                    m_CR_ActualLubricateInterval = value;
                    RaisePropertyChanged(() => CR_ActualLubricateInterval);
                }
            }
        }

        private double m_CR_LubricateDetectTime;
        public double CR_LubricateDetectTime
        {
            get { return m_CR_LubricateDetectTime; }
            set
            {
                if (m_CR_LubricateDetectTime != value)
                {
                    m_CR_LubricateDetectTime = value;
                    RaisePropertyChanged(() => CR_LubricateDetectTime);
                }
            }
        }

        private double m_CR_LubricateTotalNum;
        public double CR_LubricateTotalNum
        {
            get { return m_CR_LubricateTotalNum; }
            set
            {
                if (m_CR_LubricateTotalNum != value)
                {
                    m_CR_LubricateTotalNum = value;
                    RaisePropertyChanged(() => CR_LubricateTotalNum);
                }
            }
        }


        private double m_CR_PowerOnLubricateTime;
        public double CR_PowerOnLubricateTime
        {
            get { return m_CR_PowerOnLubricateTime; }
            set
            {
                if (m_CR_PowerOnLubricateTime != value)
                {
                    m_CR_PowerOnLubricateTime = value;
                    RaisePropertyChanged(() => CR_PowerOnLubricateTime);
                }
            }
        }

        private double m_CR_LubricateDetecte;
        public double CR_LubricateDetecte
        {
            get { return m_CR_LubricateDetecte; }
            set
            {
                if (m_CR_LubricateDetecte != value)
                {
                    m_CR_LubricateDetecte = value;
                    RaisePropertyChanged(() => CR_LubricateDetecte);
                }
            }
        }


        private double m_AC_LubricateTime;
        public double AC_LubricateTime
        {
            get { return m_AC_LubricateTime; }
            set
            {
                if (m_AC_LubricateTime != value)
                {
                    m_AC_LubricateTime = value;
                    RaisePropertyChanged(() => AC_LubricateTime);
                }
            }
        }

        private double m_AC_SetLubricateInterval;
        public double AC_SetLubricateInterval
        {
            get { return m_AC_SetLubricateInterval; }
            set
            {
                if (m_AC_SetLubricateInterval != value)
                {
                    m_AC_SetLubricateInterval = value;
                    RaisePropertyChanged(() => AC_SetLubricateInterval);
                }
            }
        }


        private double m_AC_ActualLubricateInterval;
        public double AC_ActualLubricateInterval
        {
            get { return m_AC_ActualLubricateInterval; }
            set
            {
                if (m_AC_ActualLubricateInterval != value)
                {
                    m_AC_ActualLubricateInterval = value;
                    RaisePropertyChanged(() => AC_ActualLubricateInterval);
                }
            }
        }

        private double m_AC_LubricateDetectTime;
        public double AC_LubricateDetectTime
        {
            get { return m_AC_LubricateDetectTime; }
            set
            {
                if (m_AC_LubricateDetectTime != value)
                {
                    m_AC_LubricateDetectTime = value;
                    RaisePropertyChanged(() => AC_LubricateDetectTime);
                }
            }
        }

        private double m_AC_LubricateTotalNum;
        public double AC_LubricateTotalNum
        {
            get { return m_AC_LubricateTotalNum; }
            set
            {
                if (m_AC_LubricateTotalNum != value)
                {
                    m_AC_LubricateTotalNum = value;
                    RaisePropertyChanged(() => AC_LubricateTotalNum);
                }
            }
        }

        private double m_AC_PowerOnLubricateTime;
        public double AC_PowerOnLubricateTime
        {
            get { return m_AC_PowerOnLubricateTime; }
            set
            {
                if (m_AC_PowerOnLubricateTime != value)
                {
                    m_AC_PowerOnLubricateTime = value;
                    RaisePropertyChanged(() => AC_PowerOnLubricateTime);
                }
            }
        }

        private double m_AC_LubricateDetecte;
        public double AC_LubricateDetecte
        {
            get { return m_AC_LubricateDetecte; }
            set
            {
                if (m_AC_LubricateDetecte != value)
                {
                    m_AC_LubricateDetecte = value;
                    RaisePropertyChanged(() => AC_LubricateDetecte);
                }
            }
        }

        private double m_AC2_LubricateTime;
        public double AC2_LubricateTime
        {
            get { return m_AC2_LubricateTime; }
            set
            {
                if (m_AC2_LubricateTime != value)
                {
                    m_AC2_LubricateTime = value;
                    RaisePropertyChanged(() => AC2_LubricateTime);
                }
            }
        }

        private double m_AC2_SetLubricateInterval;
        public double AC2_SetLubricateInterval
        {
            get { return m_AC2_SetLubricateInterval; }
            set
            {
                if (m_AC2_SetLubricateInterval != value)
                {
                    m_AC2_SetLubricateInterval = value;
                    RaisePropertyChanged(() => AC2_SetLubricateInterval);
                }
            }
        }

        private double m_AC2_ActualLubricateInterval;
        public double AC2_ActualLubricateInterval
        {
            get { return m_AC2_ActualLubricateInterval; }
            set
            {
                if (m_AC2_ActualLubricateInterval != value)
                {
                    m_AC2_ActualLubricateInterval = value;
                    RaisePropertyChanged(() => AC2_ActualLubricateInterval);
                }
            }
        }

        private double m_AC2_LubricateDetectTime;
        public double AC2_LubricateDetectTime
        {
            get { return m_AC2_LubricateDetectTime; }
            set
            {
                if (m_AC2_LubricateDetectTime != value)
                {
                    m_AC2_LubricateDetectTime = value;
                    RaisePropertyChanged(() => AC2_LubricateDetectTime);
                }
            }
        }

        private double m_AC2_LubricateTotalNum;
        public double AC2_LubricateTotalNum
        {
            get { return m_AC2_LubricateTotalNum; }
            set
            {
                if (m_AC2_LubricateTotalNum != value)
                {
                    m_AC2_LubricateTotalNum = value;
                    RaisePropertyChanged(() => AC2_LubricateTotalNum);
                }
            }
        }

        private double m_AC2_PowerOnLubricateTime;
        public double AC2_PowerOnLubricateTime
        {
            get { return m_AC2_PowerOnLubricateTime; }
            set
            {
                if (m_AC2_PowerOnLubricateTime != value)
                {
                    m_AC2_PowerOnLubricateTime = value;
                    RaisePropertyChanged(() => AC2_PowerOnLubricateTime);
                }
            }
        }

        private double m_AC2_LubricateDetecte;
        public double AC2_LubricateDetecte
        {
            get { return m_AC2_LubricateDetecte; }
            set
            {
                if (m_AC2_LubricateDetecte != value)
                {
                    m_AC2_LubricateDetecte = value;
                    RaisePropertyChanged(() => AC2_LubricateDetecte);
                }
            }
        }

        private double m_GR_LubricateReversing;
        public double GR_LubricateReversing
        {
            get { return m_GR_LubricateReversing; }
            set
            {
                if (m_GR_LubricateReversing != value)
                {
                    m_GR_LubricateReversing = value;
                    RaisePropertyChanged(() => GR_LubricateReversing);
                }
            }
        }

        private double m_GR_LubricateDetectTime;
        public double GR_LubricateDetectTime
        {
            get { return m_GR_LubricateDetectTime; }
            set
            {
                if (m_GR_LubricateDetectTime != value)
                {
                    m_GR_LubricateDetectTime = value;
                    RaisePropertyChanged(() => GR_LubricateDetectTime);
                }
            }
        }


        private double m_SC_LubricateReversing;
        public double SC_LubricateReversing
        {
            get { return m_SC_LubricateReversing; }
            set
            {
                if (m_SC_LubricateReversing != value)
                {
                    m_SC_LubricateReversing = value;
                    RaisePropertyChanged(() => SC_LubricateReversing);
                }
            }
        }

        private double m_OS_Time;
        public double OS_Time
        {
            get { return m_OS_Time; }
            set
            {
                if (m_OS_Time != value)
                {
                    m_OS_Time = value;
                    RaisePropertyChanged(() => OS_Time);
                }
            }
        }

        private double m_OS_IntervalTime;
        public double OS_IntervalTime
        {
            get { return m_OS_IntervalTime; }
            set
            {
                if (m_OS_IntervalTime != value)
                {
                    m_OS_IntervalTime = value;
                    RaisePropertyChanged(() => OS_IntervalTime);
                }
            }
        }

        private double m_OS_DelayTime;
        public double OS_DelayTime
        {
            get { return m_OS_DelayTime; }
            set
            {
                if (m_OS_DelayTime != value)
                {
                    m_OS_DelayTime = value;
                    RaisePropertyChanged(() => OS_DelayTime);
                }
            }
        }

        private double m_TS_DelayTime;
        public double TS_DelayTime
        {
            get { return m_TS_DelayTime; }
            set
            {
                if (m_TS_DelayTime != value)
                {
                    m_TS_DelayTime = value;
                    RaisePropertyChanged(() => TS_DelayTime);
                }
            }
        }

        private double m_TS_StopTime;
        public double TS_StopTime
        {
            get { return m_TS_StopTime; }
            set
            {
                if (m_TS_StopTime != value)
                {
                    m_TS_StopTime = value;
                    RaisePropertyChanged(() => TS_StopTime);
                }
            }
        }

        private double m_TS_RunTime;
        public double TS_RunTime
        {
            get { return m_TS_RunTime; }
            set
            {
                if (m_TS_RunTime != value)
                {
                    m_TS_RunTime = value;
                    RaisePropertyChanged(() => TS_RunTime);
                }
            }
        }
        

    }
}
