using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class ParaDieClampInfoDto : ViewModelBase
    {
        private double m_ClampStatus1;
        public double ClampStatus1
        {
            get { return m_ClampStatus1; }
            set
            {
                if (m_ClampStatus1 != value)
                {
                    m_ClampStatus1 = value;
                    RaisePropertyChanged(() => ClampStatus1);
                }
            }
        }

        private double m_ClampStatus2;
        public double ClampStatus2
        {
            get { return m_ClampStatus2; }
            set
            {
                if (m_ClampStatus2 != value)
                {
                    m_ClampStatus2 = value;
                    RaisePropertyChanged(() => ClampStatus2);
                }
            }
        }
        private double m_ClampRelaxPosition;
        public double ClampRelaxPosition
        {
            get { return m_ClampRelaxPosition; }
            set
            {
                if (m_ClampRelaxPosition != value)
                {
                    m_ClampRelaxPosition = value;
                    RaisePropertyChanged(() => ClampRelaxPosition);
                }
            }
        }
        private double m_ClampRelaxInPosition;
        public double ClampRelaxInPosition
        {
            get { return m_ClampRelaxInPosition; }
            set
            {
                if (m_ClampRelaxInPosition != value)
                {
                    m_ClampRelaxInPosition = value;
                    RaisePropertyChanged(() => ClampRelaxInPosition);
                }
            }
        }
        private double m_Clamp_Front_1_Ebable;
        public double Clamp_Front_1_Ebable
        {
            get { return m_Clamp_Front_1_Ebable; }
            set
            {
                if (m_Clamp_Front_1_Ebable != value)
                {
                    m_Clamp_Front_1_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Front_1_Ebable);
                }
            }
        }
        private double m_Clamp_Front_1_MoveOutStatus;
        public double Clamp_Front_1_MoveOutStatus
        {
            get { return m_Clamp_Front_1_MoveOutStatus; }
            set
            {
                if (m_Clamp_Front_1_MoveOutStatus != value)
                {
                    m_Clamp_Front_1_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_1_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Front_1_MoveInStatus;
        public double Clamp_Front_1_MoveInStatus
        {
            get { return m_Clamp_Front_1_MoveInStatus; }
            set
            {
                if (m_Clamp_Front_1_MoveInStatus != value)
                {
                    m_Clamp_Front_1_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_1_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Front_2_Ebable;
        public double Clamp_Front_2_Ebable
        {
            get { return m_Clamp_Front_2_Ebable; }
            set
            {
                if (m_Clamp_Front_2_Ebable != value)
                {
                    m_Clamp_Front_2_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Front_2_Ebable);
                }
            }
        }
        private double m_Clamp_Front_2_MoveOutStatus;
        public double Clamp_Front_2_MoveOutStatus
        {
            get { return m_Clamp_Front_2_MoveOutStatus; }
            set
            {
                if (m_Clamp_Front_2_MoveOutStatus != value)
                {
                    m_Clamp_Front_2_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_2_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Front_2_MoveInStatus;
        public double Clamp_Front_2_MoveInStatus
        {
            get { return m_Clamp_Front_2_MoveInStatus; }
            set
            {
                if (m_Clamp_Front_2_MoveInStatus != value)
                {
                    m_Clamp_Front_2_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_2_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Front_3_Ebable;
        public double Clamp_Front_3_Ebable
        {
            get { return m_Clamp_Front_3_Ebable; }
            set
            {
                if (m_Clamp_Front_3_Ebable != value)
                {
                    m_Clamp_Front_3_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Front_3_Ebable);
                }
            }
        }
        private double m_Clamp_Front_3_MoveOutStatus;
        public double Clamp_Front_3_MoveOutStatus
        {
            get { return m_Clamp_Front_3_MoveOutStatus; }
            set
            {
                if (m_Clamp_Front_3_MoveOutStatus != value)
                {
                    m_Clamp_Front_3_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_3_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Front_3_MoveInStatus;
        public double Clamp_Front_3_MoveInStatus
        {
            get { return m_Clamp_Front_3_MoveInStatus; }
            set
            {
                if (m_Clamp_Front_3_MoveInStatus != value)
                {
                    m_Clamp_Front_3_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_3_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Front_4_Ebable;
        public double Clamp_Front_4_Ebable
        {
            get { return m_Clamp_Front_4_Ebable; }
            set
            {
                if (m_Clamp_Front_4_Ebable != value)
                {
                    m_Clamp_Front_4_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Front_4_Ebable);
                }
            }
        }
        private double m_Clamp_Front_4_MoveOutStatus;
        public double Clamp_Front_4_MoveOutStatus
        {
            get { return m_Clamp_Front_4_MoveOutStatus; }
            set
            {
                if (m_Clamp_Front_4_MoveOutStatus != value)
                {
                    m_Clamp_Front_4_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_4_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Front_4_MoveInStatus;
        public double Clamp_Front_4_MoveInStatus
        {
            get { return m_Clamp_Front_4_MoveInStatus; }
            set
            {
                if (m_Clamp_Front_4_MoveInStatus != value)
                {
                    m_Clamp_Front_4_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_4_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Front_5_Ebable;
        public double Clamp_Front_5_Ebable
        {
            get { return m_Clamp_Front_5_Ebable; }
            set
            {
                if (m_Clamp_Front_5_Ebable != value)
                {
                    m_Clamp_Front_5_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Front_5_Ebable);
                }
            }
        }
        private double m_Clamp_Front_5_MoveOutStatus;
        public double Clamp_Front_5_MoveOutStatus
        {
            get { return m_Clamp_Front_5_MoveOutStatus; }
            set
            {
                if (m_Clamp_Front_5_MoveOutStatus != value)
                {
                    m_Clamp_Front_5_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_5_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Front_5_MoveInStatus;
        public double Clamp_Front_5_MoveInStatus
        {
            get { return m_Clamp_Front_5_MoveInStatus; }
            set
            {
                if (m_Clamp_Front_5_MoveInStatus != value)
                {
                    m_Clamp_Front_5_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_5_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Front_6_Ebable;
        public double Clamp_Front_6_Ebable
        {
            get { return m_Clamp_Front_6_Ebable; }
            set
            {
                if (m_Clamp_Front_6_Ebable != value)
                {
                    m_Clamp_Front_6_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Front_6_Ebable);
                }
            }
        }
        private double m_Clamp_Front_6_MoveOutStatus;
        public double Clamp_Front_6_MoveOutStatus
        {
            get { return m_Clamp_Front_6_MoveOutStatus; }
            set
            {
                if (m_Clamp_Front_6_MoveOutStatus != value)
                {
                    m_Clamp_Front_6_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_6_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Front_6_MoveInStatus;
        public double Clamp_Front_6_MoveInStatus
        {
            get { return m_Clamp_Front_6_MoveInStatus; }
            set
            {
                if (m_Clamp_Front_6_MoveInStatus != value)
                {
                    m_Clamp_Front_6_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_6_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Front_7_Ebable;
        public double Clamp_Front_7_Ebable
        {
            get { return m_Clamp_Front_7_Ebable; }
            set
            {
                if (m_Clamp_Front_7_Ebable != value)
                {
                    m_Clamp_Front_7_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Front_7_Ebable);
                }
            }
        }
        private double m_Clamp_Front_7_MoveOutStatus;
        public double Clamp_Front_7_MoveOutStatus
        {
            get { return m_Clamp_Front_7_MoveOutStatus; }
            set
            {
                if (m_Clamp_Front_7_MoveOutStatus != value)
                {
                    m_Clamp_Front_7_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_7_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Front_7_MoveInStatus;
        public double Clamp_Front_7_MoveInStatus
        {
            get { return m_Clamp_Front_7_MoveInStatus; }
            set
            {
                if (m_Clamp_Front_7_MoveInStatus != value)
                {
                    m_Clamp_Front_7_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_7_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Front_8_Ebable;
        public double Clamp_Front_8_Ebable
        {
            get { return m_Clamp_Front_8_Ebable; }
            set
            {
                if (m_Clamp_Front_8_Ebable != value)
                {
                    m_Clamp_Front_8_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Front_8_Ebable);
                }
            }
        }
        private double m_Clamp_Front_8_MoveOutStatus;
        public double Clamp_Front_8_MoveOutStatus
        {
            get { return m_Clamp_Front_8_MoveOutStatus; }
            set
            {
                if (m_Clamp_Front_8_MoveOutStatus != value)
                {
                    m_Clamp_Front_8_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_8_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Front_8_MoveInStatus;
        public double Clamp_Front_8_MoveInStatus
        {
            get { return m_Clamp_Front_8_MoveInStatus; }
            set
            {
                if (m_Clamp_Front_8_MoveInStatus != value)
                {
                    m_Clamp_Front_8_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_8_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Front_9_Ebable;
        public double Clamp_Front_9_Ebable
        {
            get { return m_Clamp_Front_9_Ebable; }
            set
            {
                if (m_Clamp_Front_9_Ebable != value)
                {
                    m_Clamp_Front_9_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Front_9_Ebable);
                }
            }
        }
        private double m_Clamp_Front_9_MoveOutStatus;
        public double Clamp_Front_9_MoveOutStatus
        {
            get { return m_Clamp_Front_9_MoveOutStatus; }
            set
            {
                if (m_Clamp_Front_9_MoveOutStatus != value)
                {
                    m_Clamp_Front_9_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_9_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Front_9_MoveInStatus;
        public double Clamp_Front_9_MoveInStatus
        {
            get { return m_Clamp_Front_9_MoveInStatus; }
            set
            {
                if (m_Clamp_Front_9_MoveInStatus != value)
                {
                    m_Clamp_Front_9_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_9_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Front_10_Ebable;
        public double Clamp_Front_10_Ebable
        {
            get { return m_Clamp_Front_10_Ebable; }
            set
            {
                if (m_Clamp_Front_10_Ebable != value)
                {
                    m_Clamp_Front_10_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Front_10_Ebable);
                }
            }
        }
        private double m_Clamp_Front_10_MoveOutStatus;
        public double Clamp_Front_10_MoveOutStatus
        {
            get { return m_Clamp_Front_10_MoveOutStatus; }
            set
            {
                if (m_Clamp_Front_10_MoveOutStatus != value)
                {
                    m_Clamp_Front_10_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_10_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Front_10_MoveInStatus;
        public double Clamp_Front_10_MoveInStatus
        {
            get { return m_Clamp_Front_10_MoveInStatus; }
            set
            {
                if (m_Clamp_Front_10_MoveInStatus != value)
                {
                    m_Clamp_Front_10_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_10_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Front_11_Ebable;
        public double Clamp_Front_11_Ebable
        {
            get { return m_Clamp_Front_11_Ebable; }
            set
            {
                if (m_Clamp_Front_11_Ebable != value)
                {
                    m_Clamp_Front_11_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Front_11_Ebable);
                }
            }
        }
        private double m_Clamp_Front_11_MoveOutStatus;
        public double Clamp_Front_11_MoveOutStatus
        {
            get { return m_Clamp_Front_11_MoveOutStatus; }
            set
            {
                if (m_Clamp_Front_11_MoveOutStatus != value)
                {
                    m_Clamp_Front_11_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_11_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Front_11_MoveInStatus;
        public double Clamp_Front_11_MoveInStatus
        {
            get { return m_Clamp_Front_11_MoveInStatus; }
            set
            {
                if (m_Clamp_Front_11_MoveInStatus != value)
                {
                    m_Clamp_Front_11_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_11_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Front_12_Ebable;
        public double Clamp_Front_12_Ebable
        {
            get { return m_Clamp_Front_12_Ebable; }
            set
            {
                if (m_Clamp_Front_12_Ebable != value)
                {
                    m_Clamp_Front_12_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Front_12_Ebable);
                }
            }
        }
        private double m_Clamp_Front_12_MoveOutStatus;
        public double Clamp_Front_12_MoveOutStatus
        {
            get { return m_Clamp_Front_12_MoveOutStatus; }
            set
            {
                if (m_Clamp_Front_12_MoveOutStatus != value)
                {
                    m_Clamp_Front_12_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_12_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Front_12_MoveInStatus;
        public double Clamp_Front_12_MoveInStatus
        {
            get { return m_Clamp_Front_12_MoveInStatus; }
            set
            {
                if (m_Clamp_Front_12_MoveInStatus != value)
                {
                    m_Clamp_Front_12_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_12_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Front_13_Ebable;
        public double Clamp_Front_13_Ebable
        {
            get { return m_Clamp_Front_13_Ebable; }
            set
            {
                if (m_Clamp_Front_13_Ebable != value)
                {
                    m_Clamp_Front_13_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Front_13_Ebable);
                }
            }
        }
        private double m_Clamp_Front_13_MoveOutStatus;
        public double Clamp_Front_13_MoveOutStatus
        {
            get { return m_Clamp_Front_13_MoveOutStatus; }
            set
            {
                if (m_Clamp_Front_13_MoveOutStatus != value)
                {
                    m_Clamp_Front_13_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_13_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Front_13_MoveInStatus;
        public double Clamp_Front_13_MoveInStatus
        {
            get { return m_Clamp_Front_13_MoveInStatus; }
            set
            {
                if (m_Clamp_Front_13_MoveInStatus != value)
                {
                    m_Clamp_Front_13_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Front_13_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Back_1_Ebable;
        public double Clamp_Back_1_Ebable
        {
            get { return m_Clamp_Back_1_Ebable; }
            set
            {
                if (m_Clamp_Back_1_Ebable != value)
                {
                    m_Clamp_Back_1_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Back_1_Ebable);
                }
            }
        }
        private double m_Clamp_Back_1_MoveOutStatus;
        public double Clamp_Back_1_MoveOutStatus
        {
            get { return m_Clamp_Back_1_MoveOutStatus; }
            set
            {
                if (m_Clamp_Back_1_MoveOutStatus != value)
                {
                    m_Clamp_Back_1_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_1_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Back_1_MoveInStatus;
        public double Clamp_Back_1_MoveInStatus
        {
            get { return m_Clamp_Back_1_MoveInStatus; }
            set
            {
                if (m_Clamp_Back_1_MoveInStatus != value)
                {
                    m_Clamp_Back_1_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_1_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Back_2_Ebable;
        public double Clamp_Back_2_Ebable
        {
            get { return m_Clamp_Back_2_Ebable; }
            set
            {
                if (m_Clamp_Back_2_Ebable != value)
                {
                    m_Clamp_Back_2_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Back_2_Ebable);
                }
            }
        }
        private double m_Clamp_Back_2_MoveOutStatus;
        public double Clamp_Back_2_MoveOutStatus
        {
            get { return m_Clamp_Back_2_MoveOutStatus; }
            set
            {
                if (m_Clamp_Back_2_MoveOutStatus != value)
                {
                    m_Clamp_Back_2_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_2_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Back_2_MoveInStatus;
        public double Clamp_Back_2_MoveInStatus
        {
            get { return m_Clamp_Back_2_MoveInStatus; }
            set
            {
                if (m_Clamp_Back_2_MoveInStatus != value)
                {
                    m_Clamp_Back_2_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_2_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Back_3_Ebable;
        public double Clamp_Back_3_Ebable
        {
            get { return m_Clamp_Back_3_Ebable; }
            set
            {
                if (m_Clamp_Back_3_Ebable != value)
                {
                    m_Clamp_Back_3_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Back_3_Ebable);
                }
            }
        }
        private double m_Clamp_Back_3_MoveOutStatus;
        public double Clamp_Back_3_MoveOutStatus
        {
            get { return m_Clamp_Back_3_MoveOutStatus; }
            set
            {
                if (m_Clamp_Back_3_MoveOutStatus != value)
                {
                    m_Clamp_Back_3_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_3_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Back_3_MoveInStatus;
        public double Clamp_Back_3_MoveInStatus
        {
            get { return m_Clamp_Back_3_MoveInStatus; }
            set
            {
                if (m_Clamp_Back_3_MoveInStatus != value)
                {
                    m_Clamp_Back_3_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_3_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Back_4_Ebable;
        public double Clamp_Back_4_Ebable
        {
            get { return m_Clamp_Back_4_Ebable; }
            set
            {
                if (m_Clamp_Back_4_Ebable != value)
                {
                    m_Clamp_Back_4_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Back_4_Ebable);
                }
            }
        }
        private double m_Clamp_Back_4_MoveOutStatus;
        public double Clamp_Back_4_MoveOutStatus
        {
            get { return m_Clamp_Back_4_MoveOutStatus; }
            set
            {
                if (m_Clamp_Back_4_MoveOutStatus != value)
                {
                    m_Clamp_Back_4_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_4_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Back_4_MoveInStatus;
        public double Clamp_Back_4_MoveInStatus
        {
            get { return m_Clamp_Back_4_MoveInStatus; }
            set
            {
                if (m_Clamp_Back_4_MoveInStatus != value)
                {
                    m_Clamp_Back_4_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_4_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Back_5_Ebable;
        public double Clamp_Back_5_Ebable
        {
            get { return m_Clamp_Back_5_Ebable; }
            set
            {
                if (m_Clamp_Back_5_Ebable != value)
                {
                    m_Clamp_Back_5_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Back_5_Ebable);
                }
            }
        }
        private double m_Clamp_Back_5_MoveOutStatus;
        public double Clamp_Back_5_MoveOutStatus
        {
            get { return m_Clamp_Back_5_MoveOutStatus; }
            set
            {
                if (m_Clamp_Back_5_MoveOutStatus != value)
                {
                    m_Clamp_Back_5_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_5_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Back_5_MoveInStatus;
        public double Clamp_Back_5_MoveInStatus
        {
            get { return m_Clamp_Back_5_MoveInStatus; }
            set
            {
                if (m_Clamp_Back_5_MoveInStatus != value)
                {
                    m_Clamp_Back_5_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_5_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Back_6_Ebable;
        public double Clamp_Back_6_Ebable
        {
            get { return m_Clamp_Back_6_Ebable; }
            set
            {
                if (m_Clamp_Back_6_Ebable != value)
                {
                    m_Clamp_Back_6_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Back_6_Ebable);
                }
            }
        }
        private double m_Clamp_Back_6_MoveOutStatus;
        public double Clamp_Back_6_MoveOutStatus
        {
            get { return m_Clamp_Back_6_MoveOutStatus; }
            set
            {
                if (m_Clamp_Back_6_MoveOutStatus != value)
                {
                    m_Clamp_Back_6_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_6_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Back_6_MoveInStatus;
        public double Clamp_Back_6_MoveInStatus
        {
            get { return m_Clamp_Back_6_MoveInStatus; }
            set
            {
                if (m_Clamp_Back_6_MoveInStatus != value)
                {
                    m_Clamp_Back_6_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_6_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Back_7_Ebable;
        public double Clamp_Back_7_Ebable
        {
            get { return m_Clamp_Back_7_Ebable; }
            set
            {
                if (m_Clamp_Back_7_Ebable != value)
                {
                    m_Clamp_Back_7_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Back_7_Ebable);
                }
            }
        }
        private double m_Clamp_Back_7_MoveOutStatus;
        public double Clamp_Back_7_MoveOutStatus
        {
            get { return m_Clamp_Back_7_MoveOutStatus; }
            set
            {
                if (m_Clamp_Back_7_MoveOutStatus != value)
                {
                    m_Clamp_Back_7_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_7_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Back_7_MoveInStatus;
        public double Clamp_Back_7_MoveInStatus
        {
            get { return m_Clamp_Back_7_MoveInStatus; }
            set
            {
                if (m_Clamp_Back_7_MoveInStatus != value)
                {
                    m_Clamp_Back_7_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_7_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Back_8_Ebable;
        public double Clamp_Back_8_Ebable
        {
            get { return m_Clamp_Back_8_Ebable; }
            set
            {
                if (m_Clamp_Back_8_Ebable != value)
                {
                    m_Clamp_Back_8_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Back_8_Ebable);
                }
            }
        }
        private double m_Clamp_Back_8_MoveOutStatus;
        public double Clamp_Back_8_MoveOutStatus
        {
            get { return m_Clamp_Back_8_MoveOutStatus; }
            set
            {
                if (m_Clamp_Back_8_MoveOutStatus != value)
                {
                    m_Clamp_Back_8_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_8_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Back_8_MoveInStatus;
        public double Clamp_Back_8_MoveInStatus
        {
            get { return m_Clamp_Back_8_MoveInStatus; }
            set
            {
                if (m_Clamp_Back_8_MoveInStatus != value)
                {
                    m_Clamp_Back_8_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_8_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Back_9_Ebable;
        public double Clamp_Back_9_Ebable
        {
            get { return m_Clamp_Back_9_Ebable; }
            set
            {
                if (m_Clamp_Back_9_Ebable != value)
                {
                    m_Clamp_Back_9_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Back_9_Ebable);
                }
            }
        }
        private double m_Clamp_Back_9_MoveOutStatus;
        public double Clamp_Back_9_MoveOutStatus
        {
            get { return m_Clamp_Back_9_MoveOutStatus; }
            set
            {
                if (m_Clamp_Back_9_MoveOutStatus != value)
                {
                    m_Clamp_Back_9_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_9_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Back_9_MoveInStatus;
        public double Clamp_Back_9_MoveInStatus
        {
            get { return m_Clamp_Back_9_MoveInStatus; }
            set
            {
                if (m_Clamp_Back_9_MoveInStatus != value)
                {
                    m_Clamp_Back_9_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_9_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Back_10_Ebable;
        public double Clamp_Back_10_Ebable
        {
            get { return m_Clamp_Back_10_Ebable; }
            set
            {
                if (m_Clamp_Back_10_Ebable != value)
                {
                    m_Clamp_Back_10_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Back_10_Ebable);
                }
            }
        }
        private double m_Clamp_Back_10_MoveOutStatus;
        public double Clamp_Back_10_MoveOutStatus
        {
            get { return m_Clamp_Back_10_MoveOutStatus; }
            set
            {
                if (m_Clamp_Back_10_MoveOutStatus != value)
                {
                    m_Clamp_Back_10_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_10_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Back_10_MoveInStatus;
        public double Clamp_Back_10_MoveInStatus
        {
            get { return m_Clamp_Back_10_MoveInStatus; }
            set
            {
                if (m_Clamp_Back_10_MoveInStatus != value)
                {
                    m_Clamp_Back_10_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_10_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Back_11_Ebable;
        public double Clamp_Back_11_Ebable
        {
            get { return m_Clamp_Back_11_Ebable; }
            set
            {
                if (m_Clamp_Back_11_Ebable != value)
                {
                    m_Clamp_Back_11_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Back_11_Ebable);
                }
            }
        }
        private double m_Clamp_Back_11_MoveOutStatus;
        public double Clamp_Back_11_MoveOutStatus
        {
            get { return m_Clamp_Back_11_MoveOutStatus; }
            set
            {
                if (m_Clamp_Back_11_MoveOutStatus != value)
                {
                    m_Clamp_Back_11_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_11_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Back_11_MoveInStatus;
        public double Clamp_Back_11_MoveInStatus
        {
            get { return m_Clamp_Back_11_MoveInStatus; }
            set
            {
                if (m_Clamp_Back_11_MoveInStatus != value)
                {
                    m_Clamp_Back_11_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_11_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Back_12_Ebable;
        public double Clamp_Back_12_Ebable
        {
            get { return m_Clamp_Back_12_Ebable; }
            set
            {
                if (m_Clamp_Back_12_Ebable != value)
                {
                    m_Clamp_Back_12_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Back_12_Ebable);
                }
            }
        }
        private double m_Clamp_Back_12_MoveOutStatus;
        public double Clamp_Back_12_MoveOutStatus
        {
            get { return m_Clamp_Back_12_MoveOutStatus; }
            set
            {
                if (m_Clamp_Back_12_MoveOutStatus != value)
                {
                    m_Clamp_Back_12_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_12_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Back_12_MoveInStatus;
        public double Clamp_Back_12_MoveInStatus
        {
            get { return m_Clamp_Back_12_MoveInStatus; }
            set
            {
                if (m_Clamp_Back_12_MoveInStatus != value)
                {
                    m_Clamp_Back_12_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_12_MoveInStatus);
                }
            }
        }
        private double m_Clamp_Back_13_Ebable;
        public double Clamp_Back_13_Ebable
        {
            get { return m_Clamp_Back_13_Ebable; }
            set
            {
                if (m_Clamp_Back_13_Ebable != value)
                {
                    m_Clamp_Back_13_Ebable = value;
                    RaisePropertyChanged(() => Clamp_Back_13_Ebable);
                }
            }
        }
        private double m_Clamp_Back_13_MoveOutStatus;
        public double Clamp_Back_13_MoveOutStatus
        {
            get { return m_Clamp_Back_13_MoveOutStatus; }
            set
            {
                if (m_Clamp_Back_13_MoveOutStatus != value)
                {
                    m_Clamp_Back_13_MoveOutStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_13_MoveOutStatus);
                }
            }
        }
        private double m_Clamp_Back_13_MoveInStatus;
        public double Clamp_Back_13_MoveInStatus
        {
            get { return m_Clamp_Back_13_MoveInStatus; }
            set
            {
                if (m_Clamp_Back_13_MoveInStatus != value)
                {
                    m_Clamp_Back_13_MoveInStatus = value;
                    RaisePropertyChanged(() => Clamp_Back_13_MoveInStatus);
                }
            }
        }

    }
}
