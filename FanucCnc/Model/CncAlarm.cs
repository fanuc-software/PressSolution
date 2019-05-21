using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class CncAlarm
    {
        public short Type { get; set; }
        public int Alm_No { get; set; }
        public short Axis { get; set; }
        public string Alm_Msg { get; set; }
    }
}
