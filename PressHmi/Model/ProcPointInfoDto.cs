using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class ProcPointInfoDto : ViewModelBase
    {
        private double m_Pos;
        public double Pos
        {
            get { return m_Pos; }
            set
            {
                if (m_Pos != value)
                {
                    m_Pos = value;
                    RaisePropertyChanged(() => Pos);
                }
            }
        }

        private double m_Speed;
        public double Speed
        {
            get { return m_Speed; }
            set
            {
                if (m_Speed != value)
                {
                    m_Speed = value;
                    RaisePropertyChanged(() => Speed);
                }
            }
        }

        private double m_StopTime;
        public double StopTime
        {
            get { return m_StopTime; }
            set
            {
                if (m_StopTime != value)
                {
                    m_StopTime = value;
                    RaisePropertyChanged(() => StopTime);
                }
            }
        }
    }
}
