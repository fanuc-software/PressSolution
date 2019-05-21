using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class StateMonitorInfo
    {

        public bool LineChartFlag { get; set; }

        public double Increment { get; set; }

        public int CylinderMode { get; set; }

        public int LoaderState { get; set; }

        public int WorkStep { get; set; }

        public int WorkTime { get; set; }

        public int SliderPosition { get; set; }

        public int SliderSpeed { get; set; }

        public int SliderPressure { get; set; }

        public int SliderTemperature { get; set; }

        public double DownDelayTime { get; set; }

        public double DownTime { get; set; }

        public double SavePressureCount { get; set; }

        public double UpDelayTime { get; set; }

        public double UpTime { get; set; }
    }
}
