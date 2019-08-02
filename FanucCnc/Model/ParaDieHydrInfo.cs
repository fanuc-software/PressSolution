using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class ParaDieHydrInfo
    {
        public double Mode { get; set; }

        public double Pressure { get; set; }

        public double PushPos { get; set; }

        public double PushDelayTime { get; set; }

        public double ActualPressure { get; set; }

        public double ActualPos { get; set; }

        public double Run { get; set; }

        public double State { get; set; }
    }
}
