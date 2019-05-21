using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class ProcPointInfo
    {
        public int Index { get; set; }

        public double Pos { get; set; }

        public double Speed { get; set; }

        public double StopTime { get; set; }
    }
}
