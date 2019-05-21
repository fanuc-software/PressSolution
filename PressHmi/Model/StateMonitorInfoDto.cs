using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class StateMonitorInfoDto : ViewModelBase
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

        public double Increment { get; set; }

        private int m_CylinderMode;
        public int CylinderMode
        {
            get { return m_CylinderMode; }
            set
            {
                if (m_CylinderMode != value)
                {
                    m_CylinderMode = value;
                    RaisePropertyChanged(() => CylinderMode);
                }
            }
        }
        
        private int m_LoaderState;
        public int LoaderState
        {
            get { return m_LoaderState; }
            set
            {
                if (m_LoaderState != value)
                {
                    m_LoaderState = value;
                    RaisePropertyChanged(() => LoaderState);
                }
            }
        }
        

        private int m_WorkStep;
        public int WorkStep
        {
            get { return m_WorkStep; }
            set
            {
                if (m_WorkStep != value)
                {
                    m_WorkStep = value;
                    RaisePropertyChanged(() => WorkStep);
                }
            }
        }
        

        private int m_WorkTime;
        public int WorkTime
        {
            get { return m_WorkTime; }
            set
            {
                if (m_WorkTime != value)
                {
                    m_WorkTime = value;
                    RaisePropertyChanged(() => WorkTime);
                }
            }
        }
        

        private int m_SliderPosition;
        public int SliderPosition
        {
            get { return m_SliderPosition; }
            set
            {
                if (m_SliderPosition != value)
                {
                    m_SliderPosition = value;
                    RaisePropertyChanged(() => SliderPosition);
                }
            }
        }

        


        private int m_SliderSpeed;
        public int SliderSpeed
        {
            get { return m_SliderSpeed; }
            set
            {
                if (m_SliderSpeed != value)
                {
                    m_SliderSpeed = value;
                    RaisePropertyChanged(() => SliderSpeed);
                }
            }
        }
        


        private int m_SliderPressure;
        public int SliderPressure
        {
            get { return m_SliderPressure; }
            set
            {
                if (m_SliderPressure != value)
                {
                    m_SliderPressure = value;
                    RaisePropertyChanged(() => SliderPressure);
                }
            }
        }

        

        private int m_SliderTemperature;
        public int SliderTemperature
        {
            get { return m_SliderTemperature; }
            set
            {
                if (m_SliderTemperature != value)
                {
                    m_SliderTemperature = value;
                    RaisePropertyChanged(() => SliderTemperature);
                }
            }
        }
        

        private double m_DownDelayTime;
        public double DownDelayTime
        {
            get { return m_DownDelayTime; }
            set
            {
                if (m_DownDelayTime != value)
                {
                    m_DownDelayTime = value;
                    RaisePropertyChanged(() => DownDelayTime);
                }
            }
        }
        
        private double m_DownTime;
        public double DownTime
        {
            get { return m_DownTime; }
            set
            {
                if (m_DownTime != value)
                {
                    m_DownTime = value;
                    RaisePropertyChanged(() => DownTime);
                }
            }
        }

        

        private double m_SavePressureCount;
        public double SavePressureCount
        {
            get { return m_SavePressureCount; }
            set
            {
                if (m_SavePressureCount != value)
                {
                    m_SavePressureCount = value;
                    RaisePropertyChanged(() => SavePressureCount);
                }
            }
        }
        

        private double m_UpDelayTime;
        public double UpDelayTime
        {
            get { return m_UpDelayTime; }
            set
            {
                if (m_UpDelayTime != value)
                {
                    m_UpDelayTime = value;
                    RaisePropertyChanged(() => UpDelayTime);
                }
            }
        }
        

        private double m_UpTime;
        public double UpTime
        {
            get { return m_UpTime; }
            set
            {
                if (m_UpTime != value)
                {
                    m_UpTime = value;
                    RaisePropertyChanged(() => UpTime);
                }
            }
        }

    }
}
