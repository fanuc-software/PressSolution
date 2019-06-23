using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FanucCnc.Model
{
    public class MacroBom
    {
        [Display(Name = "状态监控-下行延时", AutoGenerateField = true)]
        public MacroBomItem DownDelayTime { get; set; }
        [Display(Name = "状态监控-下行时间", AutoGenerateField = true)]
        public MacroBomItem DownTime { get; set; }
        [Display(Name = "状态监控-保压倒计时", AutoGenerateField = true)]
        public MacroBomItem SavePressureCount { get; set; }
        [Display(Name = "状态监控-上行延时", AutoGenerateField = true)]
        public MacroBomItem UpDelayTime { get; set; }
        [Display(Name = "状态监控-上行时间", AutoGenerateField = true)]
        public MacroBomItem UpTime { get; set; }

        
        [Display(Name = "保压设定-保压压力", AutoGenerateField = true)]
        public MacroBomItem SPP_Pressure { get; set; }
        [Display(Name = "保压设定-保压时间", AutoGenerateField = true)]
        public MacroBomItem SPP_Time { get; set; }
        [Display(Name = "保压设定-保压前延时", AutoGenerateField = true)]
        public MacroBomItem SPP_PreDelayTime { get; set; }
        [Display(Name = "保压设定-保压切换方式", AutoGenerateField = true)]
        public MacroBomItem SPP_ChangeMode { get; set; }
        [Display(Name = "保压设定-保压切换压力", AutoGenerateField = true)]
        public MacroBomItem SPP_ChangePressure { get; set; }
    }
}
