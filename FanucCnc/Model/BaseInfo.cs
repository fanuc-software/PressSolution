using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class BaseInfo
    {
        public string Ip { get; set; }

        public ushort Port { get; set; }

        public ushort Timeout { get; set; }
        
        public double Increment { get; set; }

        public string CsdFolder { get; set; }

        public int SciChartXTimeMax { get; set; }
        
        public short RealTimeSciChartInflgAdrType { get; set; }
        public ushort RealTimeSciChartInflgAdr { get; set; }
        public ushort RealTimeSciChartInflgBit { get; set; }

        public short SimulateSciChartInflgAdrType { get; set; }
        public ushort SimulateSciChartInflgAdr { get; set; }
        public ushort SimulateSciChartInflgBit { get; set; }
    }
}
