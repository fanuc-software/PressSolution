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
        [Display(Name = "合模设定-合模段数", AutoGenerateField = true)]
        public MacroBomItem DJP_SectionNum { get; set; }
        [Display(Name = "合模设定-合模前延时", AutoGenerateField = true)]
        public MacroBomItem DJP_PreDelayTime { get; set; }
        [Display(Name = "合模设定-合模安全时间", AutoGenerateField = true)]
        public MacroBomItem DJP_SafeTime { get; set; }
        [Display(Name = "合模规划-位置1", AutoGenerateField = true)]
        public MacroBomItem DJP_Pos_1 { get; set; }
        [Display(Name = "合模规划-速度1", AutoGenerateField = true)]
        public MacroBomItem DJP_Speed_1 { get; set; }
        [Display(Name = "合模规划-停止时间1", AutoGenerateField = true)]
        public MacroBomItem DJP_StopTime_1 { get; set; }
        [Display(Name = "合模规划-位置2", AutoGenerateField = true)]
        public MacroBomItem DJP_Pos_2 { get; set; }
        [Display(Name = "合模规划-速度2", AutoGenerateField = true)]
        public MacroBomItem DJP_Speed_2 { get; set; }
        [Display(Name = "合模规划-停止时间2", AutoGenerateField = true)]
        public MacroBomItem DJP_StopTime_2 { get; set; }
        [Display(Name = "合模规划-位置3", AutoGenerateField = true)]
        public MacroBomItem DJP_Pos_3 { get; set; }
        [Display(Name = "合模规划-速度3", AutoGenerateField = true)]
        public MacroBomItem DJP_Speed_3 { get; set; }
        [Display(Name = "合模规划-停止时间3", AutoGenerateField = true)]
        public MacroBomItem DJP_StopTime_3 { get; set; }
        [Display(Name = "合模规划-位置4", AutoGenerateField = true)]
        public MacroBomItem DJP_Pos_4 { get; set; }
        [Display(Name = "合模规划-速度4", AutoGenerateField = true)]
        public MacroBomItem DJP_Speed_4 { get; set; }
        [Display(Name = "合模规划-停止时间4", AutoGenerateField = true)]
        public MacroBomItem DJP_StopTime_4 { get; set; }
        [Display(Name = "合模规划-位置5", AutoGenerateField = true)]
        public MacroBomItem DJP_Pos_5 { get; set; }
        [Display(Name = "合模规划-速度5", AutoGenerateField = true)]
        public MacroBomItem DJP_Speed_5 { get; set; }
        [Display(Name = "合模规划-停止时间5", AutoGenerateField = true)]
        public MacroBomItem DJP_StopTime_5 { get; set; }
        [Display(Name = "合模规划-位置6", AutoGenerateField = true)]
        public MacroBomItem DJP_Pos_6 { get; set; }
        [Display(Name = "合模规划-速度6", AutoGenerateField = true)]
        public MacroBomItem DJP_Speed_6 { get; set; }
        [Display(Name = "合模规划-停止时间6", AutoGenerateField = true)]
        public MacroBomItem DJP_StopTime_6 { get; set; }
        [Display(Name = "合模规划-位置7", AutoGenerateField = true)]
        public MacroBomItem DJP_Pos_7 { get; set; }
        [Display(Name = "合模规划-速度7", AutoGenerateField = true)]
        public MacroBomItem DJP_Speed_7 { get; set; }
        [Display(Name = "合模规划-停止时间7", AutoGenerateField = true)]
        public MacroBomItem DJP_StopTime_7 { get; set; }
        [Display(Name = "合模规划-位置8", AutoGenerateField = true)]
        public MacroBomItem DJP_Pos_8 { get; set; }
        [Display(Name = "合模规划-速度8", AutoGenerateField = true)]
        public MacroBomItem DJP_Speed_8 { get; set; }
        [Display(Name = "合模规划-停止时间8", AutoGenerateField = true)]
        public MacroBomItem DJP_StopTime_8 { get; set; }
        [Display(Name = "合模规划-下死点", AutoGenerateField = true)]
        public MacroBomItem DJP_BottomDeadCentre { get; set; }

        [Display(Name = "开模设定-开模段数", AutoGenerateField = true)]
        public MacroBomItem DPP_SectionNum { get; set; }
        [Display(Name = "开模设定-开模前延时", AutoGenerateField = true)]
        public MacroBomItem DPP_PreDelayTime { get; set; }
        [Display(Name = "开模设定-开模安全时间", AutoGenerateField = true)]
        public MacroBomItem DPP_SafeTime { get; set; }
        [Display(Name = "开模规划-位置1", AutoGenerateField = true)]
        public MacroBomItem DPP_Pos_1 { get; set; }
        [Display(Name = "开模规划-速度1", AutoGenerateField = true)]
        public MacroBomItem DPP_Speed_1 { get; set; }
        [Display(Name = "开模规划-停止时间1", AutoGenerateField = true)]
        public MacroBomItem DPP_StopTime_1 { get; set; }
        [Display(Name = "开模规划-位置2", AutoGenerateField = true)]
        public MacroBomItem DPP_Pos_2 { get; set; }
        [Display(Name = "开模规划-速度2", AutoGenerateField = true)]
        public MacroBomItem DPP_Speed_2 { get; set; }
        [Display(Name = "开模规划-停止时间2", AutoGenerateField = true)]
        public MacroBomItem DPP_StopTime_2 { get; set; }
        [Display(Name = "开模规划-位置3", AutoGenerateField = true)]
        public MacroBomItem DPP_Pos_3 { get; set; }
        [Display(Name = "开模规划-速度3", AutoGenerateField = true)]
        public MacroBomItem DPP_Speed_3 { get; set; }
        [Display(Name = "开模规划-停止时间3", AutoGenerateField = true)]
        public MacroBomItem DPP_StopTime_3 { get; set; }
        [Display(Name = "开模规划-位置4", AutoGenerateField = true)]
        public MacroBomItem DPP_Pos_4 { get; set; }
        [Display(Name = "开模规划-速度4", AutoGenerateField = true)]
        public MacroBomItem DPP_Speed_4 { get; set; }
        [Display(Name = "开模规划-停止时间4", AutoGenerateField = true)]
        public MacroBomItem DPP_StopTime_4 { get; set; }
        [Display(Name = "开模规划-位置5", AutoGenerateField = true)]
        public MacroBomItem DPP_Pos_5 { get; set; }
        [Display(Name = "开模规划-速度5", AutoGenerateField = true)]
        public MacroBomItem DPP_Speed_5 { get; set; }
        [Display(Name = "开模规划-停止时间5", AutoGenerateField = true)]
        public MacroBomItem DPP_StopTime_5 { get; set; }
        [Display(Name = "开模规划-位置6", AutoGenerateField = true)]
        public MacroBomItem DPP_Pos_6 { get; set; }
        [Display(Name = "开模规划-速度6", AutoGenerateField = true)]
        public MacroBomItem DPP_Speed_6 { get; set; }
        [Display(Name = "开模规划-停止时间6", AutoGenerateField = true)]
        public MacroBomItem DPP_StopTime_6 { get; set; }
        [Display(Name = "开模规划-位置7", AutoGenerateField = true)]
        public MacroBomItem DPP_Pos_7 { get; set; }
        [Display(Name = "开模规划-速度7", AutoGenerateField = true)]
        public MacroBomItem DPP_Speed_7 { get; set; }
        [Display(Name = "开模规划-停止时间7", AutoGenerateField = true)]
        public MacroBomItem DPP_StopTime_7 { get; set; }
        [Display(Name = "开模规划-位置8", AutoGenerateField = true)]
        public MacroBomItem DPP_Pos_8 { get; set; }
        [Display(Name = "开模规划-速度8", AutoGenerateField = true)]
        public MacroBomItem DPP_Speed_8 { get; set; }
        [Display(Name = "开模规划-停止时间8", AutoGenerateField = true)]
        public MacroBomItem DPP_StopTime_8 { get; set; }
        [Display(Name = "开模规划-上死点", AutoGenerateField = true)]
        public MacroBomItem DPP_BottomDeadCentre { get; set; }
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
