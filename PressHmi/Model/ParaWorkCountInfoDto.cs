using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class ParaWorkCountInfoDto : ViewModelBase
    {
        private int m_DayPiece;
        public int DayPiece
        {
            get { return m_DayPiece; }
            set
            {
                if (m_DayPiece != value)
                {
                    m_DayPiece = value;
                    RaisePropertyChanged(() => DayPiece);
                }
            }
        }

        private int m_DayWork;
        public int DayWork
        {
            get { return m_DayWork; }
            set
            {
                if (m_DayWork != value)
                {
                    m_DayWork = value;
                    RaisePropertyChanged(() => DayWork);
                }
            }
        }

        private int m_CurPiece;
        public int CurPiece
        {
            get { return m_CurPiece; }
            set
            {
                if (m_CurPiece != value)
                {
                    m_CurPiece = value;
                    RaisePropertyChanged(() => CurPiece);
                }
            }
        }

        private int m_SetPiece;
        public int SetPiece
        {
            get { return m_SetPiece; }
            set
            {
                if (m_SetPiece != value)
                {
                    m_SetPiece = value;
                    RaisePropertyChanged(() => SetPiece);
                }
            }
        }

        private int m_CurPiece2;
        public int CurPiece2
        {
            get { return m_CurPiece2; }
            set
            {
                if (m_CurPiece2 != value)
                {
                    m_CurPiece2 = value;
                    RaisePropertyChanged(() => CurPiece2);
                }
            }
        }

        private int m_TotalPiece;
        public int TotalPiece
        {
            get { return m_TotalPiece; }
            set
            {
                if (m_TotalPiece != value)
                {
                    m_TotalPiece = value;
                    RaisePropertyChanged(() => TotalPiece);
                }
            }
        }

        private int m_TotalWork;
        public int TotalWork
        {
            get { return m_TotalWork; }
            set
            {
                if (m_TotalWork != value)
                {
                    m_TotalWork = value;
                    RaisePropertyChanged(() => TotalWork);
                }
            }
        }

    }
}
