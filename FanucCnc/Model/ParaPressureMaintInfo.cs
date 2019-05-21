using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class ParaPressureMaintInfo
    {
        public double Pressure { get; set; }

        public double Time { get; set; }

        public double PreDelayTime { get; set; }

        public double ChangeMode { get; set; }

        public double ChangePressure { get; set; }
    }
}
