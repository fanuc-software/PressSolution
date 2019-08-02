using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class ParaDiePartingProcInfoDto : ViewModelBase
    {
        public double SectionNum { get; set; }

        private double m_BottomDeadCentre;
        public double BottomDeadCentre
        {
            get { return m_BottomDeadCentre; }
            set
            {
                if (m_BottomDeadCentre != value)
                {
                    m_BottomDeadCentre = value;
                    RaisePropertyChanged(() => BottomDeadCentre);
                }
            }
        }

        private double m_Speed_TopDeadCentre;
        public double Speed_TopDeadCentre
        {
            get { return m_Speed_TopDeadCentre; }
            set
            {
                if (m_Speed_TopDeadCentre != value)
                {
                    m_Speed_TopDeadCentre = value;
                    RaisePropertyChanged(() => Speed_TopDeadCentre);
                }
            }
        }

        private double m_TopDeadCentre;
        public double TopDeadCentre
        {
            get { return m_TopDeadCentre; }
            set
            {
                if (m_TopDeadCentre != value)
                {
                    m_TopDeadCentre = value;
                    RaisePropertyChanged(() => TopDeadCentre);
                }
            }
        }

        #region p1

        private double m_Pos_1;
        public double Pos_1
        {
            get { return m_Pos_1; }
            set
            {
                if (m_Pos_1 != value)
                {
                    m_Pos_1 = value;
                    RaisePropertyChanged(() => Pos_1);
                }
            }
        }

        private double m_Speed_1;
        public double Speed_1
        {
            get { return m_Speed_1; }
            set
            {
                if (m_Speed_1 != value)
                {
                    m_Speed_1 = value;
                    RaisePropertyChanged(() => Speed_1);
                }
            }
        }

        //private double m_StopTime_1;
        //public double StopTime_1
        //{
        //    get { return m_StopTime_1; }
        //    set
        //    {
        //        if (m_StopTime_1 != value)
        //        {
        //            m_StopTime_1 = value;
        //            RaisePropertyChanged(() => StopTime_1);
        //        }
        //    }
        //}

        #endregion

        #region p2

        private double m_Pos_2;
        public double Pos_2
        {
            get { return m_Pos_2; }
            set
            {
                if (m_Pos_2 != value)
                {
                    m_Pos_2 = value;
                    RaisePropertyChanged(() => Pos_2);
                }
            }
        }

        private double m_Speed_2;
        public double Speed_2
        {
            get { return m_Speed_2; }
            set
            {
                if (m_Speed_2 != value)
                {
                    m_Speed_2 = value;
                    RaisePropertyChanged(() => Speed_2);
                }
            }
        }

        //private double m_StopTime_2;
        //public double StopTime_2
        //{
        //    get { return m_StopTime_2; }
        //    set
        //    {
        //        if (m_StopTime_2 != value)
        //        {
        //            m_StopTime_2 = value;
        //            RaisePropertyChanged(() => StopTime_2);
        //        }
        //    }
        //}

        #endregion

        #region p3

        private double m_Pos_3;
        public double Pos_3
        {
            get { return m_Pos_3; }
            set
            {
                if (m_Pos_3 != value)
                {
                    m_Pos_3 = value;
                    RaisePropertyChanged(() => Pos_3);
                }
            }
        }

        private double m_Speed_3;
        public double Speed_3
        {
            get { return m_Speed_3; }
            set
            {
                if (m_Speed_3 != value)
                {
                    m_Speed_3 = value;
                    RaisePropertyChanged(() => Speed_3);
                }
            }
        }

        //private double m_StopTime_3;
        //public double StopTime_3
        //{
        //    get { return m_StopTime_3; }
        //    set
        //    {
        //        if (m_StopTime_3 != value)
        //        {
        //            m_StopTime_3 = value;
        //            RaisePropertyChanged(() => StopTime_3);
        //        }
        //    }
        //}

        #endregion

        #region p4

        private double m_Pos_4;
        public double Pos_4
        {
            get { return m_Pos_4; }
            set
            {
                if (m_Pos_4 != value)
                {
                    m_Pos_4 = value;
                    RaisePropertyChanged(() => Pos_4);
                }
            }
        }

        private double m_Speed_4;
        public double Speed_4
        {
            get { return m_Speed_4; }
            set
            {
                if (m_Speed_4 != value)
                {
                    m_Speed_4 = value;
                    RaisePropertyChanged(() => Speed_4);
                }
            }
        }

        //private double m_StopTime_4;
        //public double StopTime_4
        //{
        //    get { return m_StopTime_4; }
        //    set
        //    {
        //        if (m_StopTime_4 != value)
        //        {
        //            m_StopTime_4 = value;
        //            RaisePropertyChanged(() => StopTime_4);
        //        }
        //    }
        //}

        #endregion

        #region p5

        private double m_Pos_5;
        public double Pos_5
        {
            get { return m_Pos_5; }
            set
            {
                if (m_Pos_5 != value)
                {
                    m_Pos_5 = value;
                    RaisePropertyChanged(() => Pos_5);
                }
            }
        }

        private double m_Speed_5;
        public double Speed_5
        {
            get { return m_Speed_5; }
            set
            {
                if (m_Speed_5 != value)
                {
                    m_Speed_5 = value;
                    RaisePropertyChanged(() => Speed_5);
                }
            }
        }

        //private double m_StopTime_5;
        //public double StopTime_5
        //{
        //    get { return m_StopTime_5; }
        //    set
        //    {
        //        if (m_StopTime_5 != value)
        //        {
        //            m_StopTime_5 = value;
        //            RaisePropertyChanged(() => StopTime_5);
        //        }
        //    }
        //}

        #endregion

        #region p6

        private double m_Pos_6;
        public double Pos_6
        {
            get { return m_Pos_6; }
            set
            {
                if (m_Pos_6 != value)
                {
                    m_Pos_6 = value;
                    RaisePropertyChanged(() => Pos_6);
                }
            }
        }

        private double m_Speed_6;
        public double Speed_6
        {
            get { return m_Speed_6; }
            set
            {
                if (m_Speed_6 != value)
                {
                    m_Speed_6 = value;
                    RaisePropertyChanged(() => Speed_6);
                }
            }
        }

        //private double m_StopTime_6;
        //public double StopTime_6
        //{
        //    get { return m_StopTime_6; }
        //    set
        //    {
        //        if (m_StopTime_6 != value)
        //        {
        //            m_StopTime_6 = value;
        //            RaisePropertyChanged(() => StopTime_6);
        //        }
        //    }
        //}

        #endregion

        #region p7

        private double m_Pos_7;
        public double Pos_7
        {
            get { return m_Pos_7; }
            set
            {
                if (m_Pos_7 != value)
                {
                    m_Pos_7 = value;
                    RaisePropertyChanged(() => Pos_7);
                }
            }
        }

        private double m_Speed_7;
        public double Speed_7
        {
            get { return m_Speed_7; }
            set
            {
                if (m_Speed_7 != value)
                {
                    m_Speed_7 = value;
                    RaisePropertyChanged(() => Speed_7);
                }
            }
        }

        //private double m_StopTime_7;
        //public double StopTime_7
        //{
        //    get { return m_StopTime_7; }
        //    set
        //    {
        //        if (m_StopTime_7 != value)
        //        {
        //            m_StopTime_7 = value;
        //            RaisePropertyChanged(() => StopTime_7);
        //        }
        //    }
        //}

        #endregion

        #region p8

        private double m_Pos_8;
        public double Pos_8
        {
            get { return m_Pos_8; }
            set
            {
                if (m_Pos_8 != value)
                {
                    m_Pos_8 = value;
                    RaisePropertyChanged(() => Pos_8);
                }
            }
        }

        private double m_Speed_8;
        public double Speed_8
        {
            get { return m_Speed_8; }
            set
            {
                if (m_Speed_8 != value)
                {
                    m_Speed_8 = value;
                    RaisePropertyChanged(() => Speed_8);
                }
            }
        }

        //private double m_StopTime_8;
        //public double StopTime_8
        //{
        //    get { return m_StopTime_8; }
        //    set
        //    {
        //        if (m_StopTime_8 != value)
        //        {
        //            m_StopTime_8 = value;
        //            RaisePropertyChanged(() => StopTime_8);
        //        }
        //    }
        //}

        #endregion

    }
}
