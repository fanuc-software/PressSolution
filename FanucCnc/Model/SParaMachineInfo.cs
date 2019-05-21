using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class SParaMachineInfo
    {
        public double MaxWeight { get; set; }
        public double MaxTemperature { get; set; }
        public double MaxError { get; set; }
        public double PressureSensorPara { get; set; }
        public double BalanceCylinderAnalog { get; set; }
        public double BalanceCylinderPressure { get; set; }
        public double OverflowDelay { get; set; }
        public double PressureDiffPara { get; set; }
        public double PressureLowAlarm { get; set; }
        public double LubricateDetect { get; set; }
    }
}
