using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class ParaWorkCountInfo
    {
        public double DayPiece { get; set; }
        public double DayWork { get; set; }
        public double CurPiece { get; set; }
        public double SetPiece { get; set; }

        public double CurPiece2 { get; set; }
        public double TotalPiece { get; set; }
        public double TotalWork { get; set; }
    }
}
