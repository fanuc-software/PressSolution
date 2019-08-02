using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class ParaDieClosingInfoDto : ViewModelBase
    {
        private bool m_LineChartFlag;
        public bool LineChartFlag
        {
            get { return m_LineChartFlag; }
            set
            {
                if (m_LineChartFlag != value)
                {
                    m_LineChartFlag = value;
                    RaisePropertyChanged(() => LineChartFlag);
                }
            }
        }

        private double m_SectionNum;
        public double SectionNum
        {
            get { return m_SectionNum; }
            set
            {
                if (m_SectionNum != value)
                {
                    m_SectionNum = value;
                    RaisePropertyChanged(() => SectionNum);
                }
            }
        }

        public string StrSectionNum
        {
            get {
                return SectionNum.ToString("0");
            }
        }

    }
}
