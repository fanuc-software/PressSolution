using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class ParaDiePartingInfoDto : ViewModelBase
    {
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
            get
            {
                return SectionNum.ToString("0");
            }
        }

        //private double m_PreDelayTime;
        //public double PreDelayTime
        //{
        //    get { return m_PreDelayTime; }
        //    set
        //    {
        //        if (m_PreDelayTime != value)
        //        {
        //            m_PreDelayTime = value;
        //            RaisePropertyChanged(() => PreDelayTime);
        //        }
        //    }
        //}

        //public string StrPreDelayTime
        //{
        //    get
        //    {
        //        return PreDelayTime.ToString("0.000");
        //    }
        //}

        //private double m_SafeTime;
        //public double SafeTime
        //{
        //    get { return m_SafeTime; }
        //    set
        //    {
        //        if (m_SafeTime != value)
        //        {
        //            m_SafeTime = value;
        //            RaisePropertyChanged(() => SafeTime);
        //        }
        //    }
        //}

        //public string StrSafeTime
        //{
        //    get
        //    {
        //        return SafeTime.ToString("0.000");
        //    }
        //}
    }
}
