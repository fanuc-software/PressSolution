using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class ParaDieChangeInfo
    {
        public double Increment { get; set; }

        public int RapidFeed { get; set; }

        public int JogFeed { get; set; }

        public double InstallDieHighSet { get; set; }


        public double InstallDieHighActual { get; set; }

        public double CylinderpRressureSet { get; set; }

        public double CylinderpRressureActual { get; set; }

        public double DieWeight { get; set; }

        public double LoaderSafePosition { get; set; }
    }
}
