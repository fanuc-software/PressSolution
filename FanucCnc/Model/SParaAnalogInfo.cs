using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class SParaAnalogInfo
    {
        public double A1_Value { get; set; }
        public double A1_WeightPara1 { get; set; }
        public double A1_WeightPara2 { get; set; }
        public double A1_Weight { get; set; }
        public double A2_Value { get; set; }
        public double A2_WeightPara1 { get; set; }
        public double A2_WeightPara2 { get; set; }
        public double A2_Weight { get; set; }
        public double A3_Value { get; set; }
        public double A3_WeightPara1 { get; set; }
        public double A3_WeightPara2 { get; set; }
        public double A3_Weight { get; set; }
        public double A4_Value { get; set; }
        public double A4_WeightPara1 { get; set; }
        public double A4_WeightPara2 { get; set; }
        public double A4_Weight { get; set; }

        public double TotalWeight { get; set; }
        public double DetectPosition { get; set; }
        public double DetectInPosition { get; set; }
        public double DetectSensor { get; set; }

        public double Pressure { get; set; }
        public double PressureUp { get; set; }
        public double PressureDown { get; set; }
    }
}
