using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class SParaAnalogInfoDto : ViewModelBase
    {
        private double m_A1_Value;
        public double A1_Value
        {
            get { return m_A1_Value; }
            set
            {
                if (m_A1_Value != value)
                {
                    m_A1_Value = value;
                    RaisePropertyChanged(() => A1_Value);
                }
            }
        }

        private double m_A1_WeightPara1;
        public double A1_WeightPara1
        {
            get { return m_A1_WeightPara1; }
            set
            {
                if (m_A1_WeightPara1 != value)
                {
                    m_A1_WeightPara1 = value;
                    RaisePropertyChanged(() => A1_WeightPara1);
                }
            }
        }

        private double m_A1_WeightPara2;
        public double A1_WeightPara2
        {
            get { return m_A1_WeightPara2; }
            set
            {
                if (m_A1_WeightPara2 != value)
                {
                    m_A1_WeightPara2 = value;
                    RaisePropertyChanged(() => A1_WeightPara2);
                }
            }
        }

        private double m_A1_Weight;
        public double A1_Weight
        {
            get { return m_A1_Weight; }
            set
            {
                if (m_A1_Weight != value)
                {
                    m_A1_Weight = value;
                    RaisePropertyChanged(() => A1_Weight);
                }
            }
        }

        private double m_A2_Value;
        public double A2_Value
        {
            get { return m_A2_Value; }
            set
            {
                if (m_A2_Value != value)
                {
                    m_A2_Value = value;
                    RaisePropertyChanged(() => A2_Value);
                }
            }
        }
        private double m_A2_WeightPara1;
        public double A2_WeightPara1
        {
            get { return m_A2_WeightPara1; }
            set
            {
                if (m_A2_WeightPara1 != value)
                {
                    m_A2_WeightPara1 = value;
                    RaisePropertyChanged(() => A2_WeightPara1);
                }
            }
        }
        private double m_A2_WeightPara2;
        public double A2_WeightPara2
        {
            get { return m_A2_WeightPara2; }
            set
            {
                if (m_A2_WeightPara2 != value)
                {
                    m_A2_WeightPara2 = value;
                    RaisePropertyChanged(() => A2_WeightPara2);
                }
            }
        }
        private double m_A2_Weight;
        public double A2_Weight
        {
            get { return m_A2_Weight; }
            set
            {
                if (m_A2_Weight != value)
                {
                    m_A2_Weight = value;
                    RaisePropertyChanged(() => A2_Weight);
                }
            }
        }
        private double m_A3_Value;
        public double A3_Value
        {
            get { return m_A3_Value; }
            set
            {
                if (m_A3_Value != value)
                {
                    m_A3_Value = value;
                    RaisePropertyChanged(() => A3_Value);
                }
            }
        }
        private double m_A3_WeightPara1;
        public double A3_WeightPara1
        {
            get { return m_A3_WeightPara1; }
            set
            {
                if (m_A3_WeightPara1 != value)
                {
                    m_A3_WeightPara1 = value;
                    RaisePropertyChanged(() => A3_WeightPara1);
                }
            }
        }
        private double m_A3_WeightPara2;
        public double A3_WeightPara2
        {
            get { return m_A3_WeightPara2; }
            set
            {
                if (m_A3_WeightPara2 != value)
                {
                    m_A3_WeightPara2 = value;
                    RaisePropertyChanged(() => A3_WeightPara2);
                }
            }
        }
        private double m_A3_Weight;
        public double A3_Weight
        {
            get { return m_A3_Weight; }
            set
            {
                if (m_A3_Weight != value)
                {
                    m_A3_Weight = value;
                    RaisePropertyChanged(() => A3_Weight);
                }
            }
        }
        private double m_A4_Value;
        public double A4_Value
        {
            get { return m_A4_Value; }
            set
            {
                if (m_A4_Value != value)
                {
                    m_A4_Value = value;
                    RaisePropertyChanged(() => A4_Value);
                }
            }
        }
        private double m_A4_WeightPara1;
        public double A4_WeightPara1
        {
            get { return m_A4_WeightPara1; }
            set
            {
                if (m_A4_WeightPara1 != value)
                {
                    m_A4_WeightPara1 = value;
                    RaisePropertyChanged(() => A4_WeightPara1);
                }
            }
        }
        private double m_A4_WeightPara2;
        public double A4_WeightPara2
        {
            get { return m_A4_WeightPara2; }
            set
            {
                if (m_A4_WeightPara2 != value)
                {
                    m_A4_WeightPara2 = value;
                    RaisePropertyChanged(() => A4_WeightPara2);
                }
            }
        }
        private double m_A4_Weight;
        public double A4_Weight
        {
            get { return m_A4_Weight; }
            set
            {
                if (m_A4_Weight != value)
                {
                    m_A4_Weight = value;
                    RaisePropertyChanged(() => A4_Weight);
                }
            }
        }

        private double m_TotalWeight;
        public double TotalWeight
        {
            get { return m_TotalWeight; }
            set
            {
                if (m_TotalWeight != value)
                {
                    m_TotalWeight = value;
                    RaisePropertyChanged(() => TotalWeight);
                }
            }
        }

        private double m_DetectPosition;
        public double DetectPosition
        {
            get { return m_DetectPosition; }
            set
            {
                if (m_DetectPosition != value)
                {
                    m_DetectPosition = value;
                    RaisePropertyChanged(() => DetectPosition);
                }
            }
        }

        private double m_DetectInPosition;
        public double DetectInPosition
        {
            get { return m_DetectInPosition; }
            set
            {
                if (m_DetectInPosition != value)
                {
                    m_DetectInPosition = value;
                    RaisePropertyChanged(() => DetectInPosition);
                }
            }
        }
        private double m_DetectSensor;
        public double DetectSensor
        {
            get { return m_DetectSensor; }
            set
            {
                if (m_DetectSensor != value)
                {
                    m_DetectSensor = value;
                    RaisePropertyChanged(() => DetectSensor);
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

        private double m_PressureUp;
        public double PressureUp
        {
            get { return m_PressureUp; }
            set
            {
                if (m_PressureUp != value)
                {
                    m_PressureUp = value;
                    RaisePropertyChanged(() => PressureUp);
                }
            }
        }

        private double m_PressureDown;
        public double PressureDown
        {
            get { return m_PressureDown; }
            set
            {
                if (m_PressureDown != value)
                {
                    m_PressureDown = value;
                    RaisePropertyChanged(() => PressureDown);
                }
            }
        }
    }
}
