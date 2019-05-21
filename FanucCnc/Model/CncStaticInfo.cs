using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class CncStaticInfo
    {
        public double Increment { get; set; }

        public double LampStatus { get; set; }

        public bool CncAlarmFlag { get; set; }

        private List<CncAlarm> _CncAlarmList = new List<CncAlarm>();
        public List<CncAlarm> CncAlarmList
        {
            get { return _CncAlarmList; }
            set
            {
                _CncAlarmList = value;
            }
        }

        public int Mode { get; set; }
        public int MainStatus { get; set; }
        public int SliderPosition { get; set; }
        public int SliderSpeed { get; set; }
        public double SliderPressure { get; set; }
        public double BalanceCylinderPressure { get; set; }
        public double InstallDieHigh { get; set; }
        public int TotalPiece { get; set; }
        public int TotalWork { get; set; }
        public int DayPiece { get; set; }
        public int DayWork { get; set; }
    }
}
