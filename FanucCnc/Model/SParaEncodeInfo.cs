using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class SParaEncodeInfo
    {
        public double IM_RESOLUTION { get; set; }
        public double IM_MOVEPITCH { get; set; }
        public double IM_UPPOSITION { get; set; }
        public double IM_DOWNPOSITION { get; set; }
        public double IM_SPEEDCHANGEPOSITION { get; set; }
        public double IM_LIMITUP { get; set; }
        public double IM_LIMITDOWN { get; set; }
        public double IM_ERROR { get; set; }
        public double IM_DIRECTION { get; set; }
        public double AC_RESOLUTION { get; set; }
        public double AC_MOVEPITCH { get; set; }
        public double AC_UPPOSITION { get; set; }
        public double AC_DOWNPOSITION { get; set; }
        public double AC_LIMITUP { get; set; }
        public double AC_LIMITDOWN { get; set; }
        public double AC_ERROR { get; set; }
        public double AC_DIRECTION { get; set; }
    }
}
