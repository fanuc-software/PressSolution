using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FanucCnc.Model
{
    public class PmcBom
    {
        #region 状态栏
        [Display(Name = "状态栏-工作模式", AutoGenerateField = true)]
        public PmcBomItem Mode { get; set; }
        [Display(Name = "状态栏-标题状态", AutoGenerateField = true)]
        public PmcBomItem MainStatus { get; set; }
        [Display(Name = "状态栏-滑块压力", AutoGenerateField = true)]
        public PmcBomItem SliderPressure { get; set; }
        [Display(Name = "状态栏-平衡缸压力", AutoGenerateField = true)]
        public PmcBomItem BalanceCylinderPressure { get; set; }
        [Display(Name = "状态栏-装模高度", AutoGenerateField = true)]
        public PmcBomItem InstallDieHigh { get; set; }
        [Display(Name = "状态栏-总次数", AutoGenerateField = true)]
        public PmcBomItem TotalPiece { get; set; }
        [Display(Name = "状态栏-总生产次数", AutoGenerateField = true)]
        public PmcBomItem TotalWork { get; set; }
        [Display(Name = "状态栏-当日次数", AutoGenerateField = true)]
        public PmcBomItem DayPiece { get; set; }
        [Display(Name = "状态栏-当日生产次数", AutoGenerateField = true)]
        public PmcBomItem DayWork { get; set; }

        #endregion

        #region 状态监控
        [Display(Name = "状态监控-油缸模式", AutoGenerateField = true)]
        public PmcBomItem SMP_CylinderMode { get; set; }
        [Display(Name = "状态监控-送料机械手", AutoGenerateField = true)]
        public PmcBomItem SMP_LoaderState { get; set; }
        [Display(Name = "状态监控-工作步骤", AutoGenerateField = true)]
        public PmcBomItem SMP_WorkStep { get; set; }
        [Display(Name = "状态监控-滑块压力", AutoGenerateField = true)]
        public PmcBomItem SMP_SliderPressure { get; set; }
        [Display(Name = "状态监控-滑块温度", AutoGenerateField = true)]
        public PmcBomItem SMP_SliderTemperature { get; set; }

        #endregion

        #region 夹模器设定
        [Display(Name = "夹模器设定-夹紧1状态", AutoGenerateField = true)]
        public PmcBomItem CLS_ClampStatus1 { get; set; }
        [Display(Name = "夹模器设定-夹紧2状态", AutoGenerateField = true)]
        public PmcBomItem CLS_ClampStatus2 { get; set; }
        [Display(Name = "夹模器设定-放松允许位置", AutoGenerateField = true)]
        public PmcBomItem CLS_ClampRelaxPosition { get; set; }
        [Display(Name = "夹模器设定-放松到位位置", AutoGenerateField = true)]
        public PmcBomItem CLS_ClampRelaxInPosition { get; set; }
        [Display(Name = "夹模器设定-夹紧前1使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_1_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧前1移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_1_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前1移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_1_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前2使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_2_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧前2移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_2_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前2移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_2_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前3使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_3_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧前3移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_3_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前3移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_3_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前4使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_4_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧前4移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_4_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前4移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_4_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前5使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_5_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧前5移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_5_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前5移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_5_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前6使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_6_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧前6移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_6_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前6移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_6_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前7使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_7_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧前7移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_7_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前7移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_7_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前8使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_8_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧前8移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_8_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前8移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_8_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前9使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_9_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧前9移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_9_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前9移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_9_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前10使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_10_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧前10移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_10_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前10移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_10_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前11使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_11_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧前11移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_11_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前11移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_11_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前12使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_12_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧前12移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_12_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前12移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_12_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前13使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_13_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧前13移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_13_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧前13移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Front_13_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后1使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_1_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧后1移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_1_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后1移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_1_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后2使用选择", AutoGenerateField = true)]
        public PmcBomItem  CLS_Clamp_Back_2_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧后2移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem  CLS_Clamp_Back_2_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后2移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem  CLS_Clamp_Back_2_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后3使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_3_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧后3移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_3_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后3移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_3_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后4使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_4_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧后4移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_4_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后4移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_4_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后5使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_5_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧后5移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_5_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后5移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_5_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后6使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_6_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧后6移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_6_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后6移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_6_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后7使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_7_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧后7移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_7_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后7移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_7_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后8使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_8_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧后8移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_8_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后8移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_8_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后9使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_9_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧后9移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_9_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后9移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_9_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后10使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_10_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧后10移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_10_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后10移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_10_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后11使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_11_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧后11移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_11_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后11移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_11_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后12使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_12_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧后12移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_12_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后12移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_12_MoveInStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后13使用选择", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_13_Ebable { get; set; }
        [Display(Name = "夹模器设定-夹紧后13移出夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_13_MoveOutStatus { get; set; }
        [Display(Name = "夹模器设定-夹紧后13移入夹紧前", AutoGenerateField = true)]
        public PmcBomItem CLS_Clamp_Back_13_MoveInStatus { get; set; }
        #endregion

        #region 合模设定
        [Display(Name = "合模设定-合模段数", AutoGenerateField = true)]
        public PmcBomItem DJP_SectionNum { get; set; }
        //[Display(Name = "合模设定-合模前延时", AutoGenerateField = true)]
        //public PmcBomItem DJP_PreDelayTime { get; set; }
        //[Display(Name = "合模设定-合模安全时间", AutoGenerateField = true)]
        //public PmcBomItem DJP_SafeTime { get; set; }

        [Display(Name = "合模规划-上死点", AutoGenerateField = true)]
        public PmcBomItem DJP_TopDeadCentre { get; set; }
        [Display(Name = "合模规划-下死点速度", AutoGenerateField = true)]
        public PmcBomItem DJP_Speed_BottomDeadCentre { get; set; }

        [Display(Name = "合模规划-位置1", AutoGenerateField = true)]
        public PmcBomItem DJP_Pos_1 { get; set; }
        [Display(Name = "合模规划-速度1", AutoGenerateField = true)]
        public PmcBomItem DJP_Speed_1 { get; set; }
        //[Display(Name = "合模规划-停止时间1", AutoGenerateField = true)]
        //public PmcBomItem DJP_StopTime_1 { get; set; }
        [Display(Name = "合模规划-位置2", AutoGenerateField = true)]
        public PmcBomItem DJP_Pos_2 { get; set; }
        [Display(Name = "合模规划-速度2", AutoGenerateField = true)]
        public PmcBomItem DJP_Speed_2 { get; set; }
        //[Display(Name = "合模规划-停止时间2", AutoGenerateField = true)]
        //public PmcBomItem DJP_StopTime_2 { get; set; }
        [Display(Name = "合模规划-位置3", AutoGenerateField = true)]
        public PmcBomItem DJP_Pos_3 { get; set; }
        [Display(Name = "合模规划-速度3", AutoGenerateField = true)]
        public PmcBomItem DJP_Speed_3 { get; set; }
        //[Display(Name = "合模规划-停止时间3", AutoGenerateField = true)]
        //public PmcBomItem DJP_StopTime_3 { get; set; }
        [Display(Name = "合模规划-位置4", AutoGenerateField = true)]
        public PmcBomItem DJP_Pos_4 { get; set; }
        [Display(Name = "合模规划-速度4", AutoGenerateField = true)]
        public PmcBomItem DJP_Speed_4 { get; set; }
        //[Display(Name = "合模规划-停止时间4", AutoGenerateField = true)]
        //public PmcBomItem DJP_StopTime_4 { get; set; }
        [Display(Name = "合模规划-位置5", AutoGenerateField = true)]
        public PmcBomItem DJP_Pos_5 { get; set; }
        [Display(Name = "合模规划-速度5", AutoGenerateField = true)]
        public PmcBomItem DJP_Speed_5 { get; set; }
        //[Display(Name = "合模规划-停止时间5", AutoGenerateField = true)]
        //public PmcBomItem DJP_StopTime_5 { get; set; }
        [Display(Name = "合模规划-位置6", AutoGenerateField = true)]
        public PmcBomItem DJP_Pos_6 { get; set; }
        [Display(Name = "合模规划-速度6", AutoGenerateField = true)]
        public PmcBomItem DJP_Speed_6 { get; set; }
        //[Display(Name = "合模规划-停止时间6", AutoGenerateField = true)]
        //public PmcBomItem DJP_StopTime_6 { get; set; }
        [Display(Name = "合模规划-位置7", AutoGenerateField = true)]
        public PmcBomItem DJP_Pos_7 { get; set; }
        [Display(Name = "合模规划-速度7", AutoGenerateField = true)]
        public PmcBomItem DJP_Speed_7 { get; set; }
        //[Display(Name = "合模规划-停止时间7", AutoGenerateField = true)]
        //public PmcBomItem DJP_StopTime_7 { get; set; }
        [Display(Name = "合模规划-位置8", AutoGenerateField = true)]
        public PmcBomItem DJP_Pos_8 { get; set; }
        [Display(Name = "合模规划-速度8", AutoGenerateField = true)]
        public PmcBomItem DJP_Speed_8 { get; set; }
        //[Display(Name = "合模规划-停止时间8", AutoGenerateField = true)]
        //public PmcBomItem DJP_StopTime_8 { get; set; }
        [Display(Name = "合模规划-下死点", AutoGenerateField = true)]
        public PmcBomItem DJP_BottomDeadCentre { get; set; }
        [Display(Name = "合模规划-下死点保持时间", AutoGenerateField = true)]
        public PmcBomItem DJP_BottomDeadCentre_StopTime { get; set; }
        #endregion

        #region 开模设定
        [Display(Name = "开模设定-开模段数", AutoGenerateField = true)]
        public PmcBomItem DPP_SectionNum { get; set; }
        //[Display(Name = "开模设定-开模前延时", AutoGenerateField = true)]
        //public PmcBomItem DPP_PreDelayTime { get; set; }
        //[Display(Name = "开模设定-开模安全时间", AutoGenerateField = true)]
        //public PmcBomItem DPP_SafeTime { get; set; }
        [Display(Name = "开模设定-下死点", AutoGenerateField = true)]
        public PmcBomItem DPP_BottomDeadCentre { get; set; }
        [Display(Name = "开模设定-上死点速度", AutoGenerateField = true)]
        public PmcBomItem DPP_Speed_TopDeadCentre { get; set; }
        [Display(Name = "开模规划-位置1", AutoGenerateField = true)]
        public PmcBomItem DPP_Pos_1 { get; set; }
        [Display(Name = "开模规划-速度1", AutoGenerateField = true)]
        public PmcBomItem DPP_Speed_1 { get; set; }
        [Display(Name = "开模规划-位置2", AutoGenerateField = true)]
        public PmcBomItem DPP_Pos_2 { get; set; }
        [Display(Name = "开模规划-速度2", AutoGenerateField = true)]
        public PmcBomItem DPP_Speed_2 { get; set; }
        [Display(Name = "开模规划-位置3", AutoGenerateField = true)]
        public PmcBomItem DPP_Pos_3 { get; set; }
        [Display(Name = "开模规划-速度3", AutoGenerateField = true)]
        public PmcBomItem DPP_Speed_3 { get; set; }
        [Display(Name = "开模规划-位置4", AutoGenerateField = true)]
        public PmcBomItem DPP_Pos_4 { get; set; }
        [Display(Name = "开模规划-速度4", AutoGenerateField = true)]
        public PmcBomItem DPP_Speed_4 { get; set; }
        [Display(Name = "开模规划-位置5", AutoGenerateField = true)]
        public PmcBomItem DPP_Pos_5 { get; set; }
        [Display(Name = "开模规划-速度5", AutoGenerateField = true)]
        public PmcBomItem DPP_Speed_5 { get; set; }
        [Display(Name = "开模规划-位置6", AutoGenerateField = true)]
        public PmcBomItem DPP_Pos_6 { get; set; }
        [Display(Name = "开模规划-速度6", AutoGenerateField = true)]
        public PmcBomItem DPP_Speed_6 { get; set; }
        [Display(Name = "开模规划-位置7", AutoGenerateField = true)]
        public PmcBomItem DPP_Pos_7 { get; set; }
        [Display(Name = "开模规划-速度7", AutoGenerateField = true)]
        public PmcBomItem DPP_Speed_7 { get; set; }
        [Display(Name = "开模规划-位置8", AutoGenerateField = true)]
        public PmcBomItem DPP_Pos_8 { get; set; }
        [Display(Name = "开模规划-速度8", AutoGenerateField = true)]
        public PmcBomItem DPP_Speed_8 { get; set; }

        [Display(Name = "开模规划-上死点", AutoGenerateField = true)]
        public PmcBomItem DPP_TopDeadCentre { get; set; }
        #endregion

        #region 换模设定
        [Display(Name = "换模设定-快行速度", AutoGenerateField = true)]
        public PmcBomItem DCP_RapidFeed { get; set; }
        [Display(Name = "换模设定-寸动速度", AutoGenerateField = true)]
        public PmcBomItem DCP_JogFeed { get; set; }
        [Display(Name = "换模设定-装模高度设定值", AutoGenerateField = true)]
        public PmcBomItem DCP_InstallDieHighSet { get; set; }
        [Display(Name = "换模设定-装模高度实际值", AutoGenerateField = true)]
        public PmcBomItem DCP_InstallDieHighActual { get; set; }
        [Display(Name = "换模设定-平衡缸压力设定值", AutoGenerateField = true)]
        public PmcBomItem DCP_CylinderpRressureSet { get; set; }
        [Display(Name = "换模设定-平衡缸压力实际值", AutoGenerateField = true)]
        public PmcBomItem DCP_CylinderpRressureActual { get; set; }
        [Display(Name = "换模设定-上模重量", AutoGenerateField = true)]
        public PmcBomItem DCP_DieWeight { get; set; }
        [Display(Name = "换模设定-机械手安全位置", AutoGenerateField = true)]
        public PmcBomItem DCP_LoaderSafePosition { get; set; }

        #endregion

        #region 自动化气源
        [Display(Name = "自动化气源1-开始位置", AutoGenerateField = true)]
        public PmcBomItem AAS_StartPos_1 { get; set; }
        [Display(Name = "自动化气源1-开始方向", AutoGenerateField = true)]
        public PmcBomItem AAS_StartArr_1 { get; set; }
        [Display(Name = "自动化气源1-结束位置", AutoGenerateField = true)]
        public PmcBomItem AAS_EndPos_1 { get; set; }
        [Display(Name = "自动化气源1-结束方向", AutoGenerateField = true)]
        public PmcBomItem AAS_EndArr_1 { get; set; }
        [Display(Name = "自动化气源1-凸轮动作显示", AutoGenerateField = true)]
        public PmcBomItem AAS_ActionFlag_1 { get; set; }

        [Display(Name = "自动化气源2-开始位置", AutoGenerateField = true)]
        public PmcBomItem AAS_StartPos_2 { get; set; }
        [Display(Name = "自动化气源2-开始方向", AutoGenerateField = true)]
        public PmcBomItem AAS_StartArr_2 { get; set; }
        [Display(Name = "自动化气源2-结束位置", AutoGenerateField = true)]
        public PmcBomItem AAS_EndPos_2 { get; set; }
        [Display(Name = "自动化气源2-结束方向", AutoGenerateField = true)]
        public PmcBomItem AAS_EndArr_2 { get; set; }
        [Display(Name = "自动化气源2-凸轮动作显示", AutoGenerateField = true)]
        public PmcBomItem AAS_ActionFlag_2 { get; set; }

        [Display(Name = "自动化气源3-开始位置", AutoGenerateField = true)]
        public PmcBomItem AAS_StartPos_3 { get; set; }
        [Display(Name = "自动化气源3-开始方向", AutoGenerateField = true)]
        public PmcBomItem AAS_StartArr_3 { get; set; }
        [Display(Name = "自动化气源3-结束位置", AutoGenerateField = true)]
        public PmcBomItem AAS_EndPos_3 { get; set; }
        [Display(Name = "自动化气源3-结束方向", AutoGenerateField = true)]
        public PmcBomItem AAS_EndArr_3 { get; set; }
        [Display(Name = "自动化气源3-凸轮动作显示", AutoGenerateField = true)]
        public PmcBomItem AAS_ActionFlag_3 { get; set; }

        [Display(Name = "自动化气源4-开始位置", AutoGenerateField = true)]
        public PmcBomItem AAS_StartPos_4 { get; set; }
        [Display(Name = "自动化气源4-开始方向", AutoGenerateField = true)]
        public PmcBomItem AAS_StartArr_4 { get; set; }
        [Display(Name = "自动化气源4-结束位置", AutoGenerateField = true)]
        public PmcBomItem AAS_EndPos_4 { get; set; }
        [Display(Name = "自动化气源4-结束方向", AutoGenerateField = true)]
        public PmcBomItem AAS_EndArr_4 { get; set; }
        [Display(Name = "自动化气源4-凸轮动作显示", AutoGenerateField = true)]
        public PmcBomItem AAS_ActionFlag_4 { get; set; }
        #endregion

        #region 模具液压设定
        [Display(Name = "工作模式选择", AutoGenerateField = true)]
        public PmcBomItem DH_Mode { get; set; }

        [Display(Name = "压力设定", AutoGenerateField = true)]
        public PmcBomItem DH_Pressure { get; set; }

        [Display(Name = "顶出位置", AutoGenerateField = true)]
        public PmcBomItem DH_PushPos { get; set; }

        [Display(Name = "顶出延时", AutoGenerateField = true)]
        public PmcBomItem DH_PushDelayTime { get; set; }

        [Display(Name = "实际压力", AutoGenerateField = true)]
        public PmcBomItem DH_ActualPressure { get; set; }

        [Display(Name = "实际位置", AutoGenerateField = true)]
        public PmcBomItem DH_ActualPos { get; set; }

        [Display(Name = "系统运行指示灯", AutoGenerateField = true)]
        public PmcBomItem DH_Run { get; set; }

        [Display(Name = "系统运行状态", AutoGenerateField = true)]
        public PmcBomItem DH_State { get; set; }
        #endregion

        #region 工件计数
        [Display(Name = "工件计数-当日次数", AutoGenerateField = true)]
        public PmcBomItem WPP_DayPiece { get; set; }
        [Display(Name = "工件计数-当日生产次数", AutoGenerateField = true)]
        public PmcBomItem WPP_DayWork { get; set; }
        [Display(Name = "工件计数-当前次数(预置计数器)", AutoGenerateField = true)]
        public PmcBomItem WPP_CurPiece { get; set; }
        [Display(Name = "工件计数-设定次数(预置计数器)", AutoGenerateField = true)]
        public PmcBomItem WPP_SetPiece { get; set; }

        [Display(Name = "工件计数-当日次数(工件计数器)", AutoGenerateField = true)]
        public PmcBomItem WPP_CurPiece2 { get; set; }
        [Display(Name = "工件计数-总次数", AutoGenerateField = true)]
        public PmcBomItem WPP_TotalPiece { get; set; }
        [Display(Name = "工件计数-总生产次数", AutoGenerateField = true)]
        public PmcBomItem WPP_TotalWork { get; set; }

        #endregion

        #region 系统参数 压机设定
        [Display(Name = "压机设定-最大吨位", AutoGenerateField = true)]
        public PmcBomItem SPM_MaxWeight { get; set; }
        [Display(Name = "压机设定-最大温度", AutoGenerateField = true)]
        public PmcBomItem SPM_MaxTemperature { get; set; }
        [Display(Name = "压机设定-允许误差设定", AutoGenerateField = true)]
        public PmcBomItem SPM_MaxError { get; set; }
        [Display(Name = "压机设定-压力传感器转换值", AutoGenerateField = true)]
        public PmcBomItem SPM_PressureSensorPara { get; set; }
        [Display(Name = "压机设定-平衡缸模拟量值", AutoGenerateField = true)]
        public PmcBomItem SPM_BalanceCylinderAnalog { get; set; }
        [Display(Name = "压机设定-平衡缸压力", AutoGenerateField = true)]
        public PmcBomItem SPM_BalanceCylinderPressure { get; set; }
        [Display(Name = "压机设定-溢流延时", AutoGenerateField = true)]
        public PmcBomItem SPM_OverflowDelay { get; set; }
        [Display(Name = "压机设定-压力差调节", AutoGenerateField = true)]
        public PmcBomItem SPM_PressureDiffPara { get; set; }
        [Display(Name = "压机设定-低压报警", AutoGenerateField = true)]
        public PmcBomItem SPM_PressureLowAlarm { get; set; }
        [Display(Name = "压机设定-润滑检测", AutoGenerateField = true)]
        public PmcBomItem SPM_LubricateDetect { get; set; }

        #endregion

        #region 系统参数 润滑设定
        [Display(Name = "润滑设定-杆系润滑时间", AutoGenerateField = true)]
        public PmcBomItem SPL_CR_LubricateTime { get; set; }
        [Display(Name = "润滑设定-杆系润滑间隔冲次", AutoGenerateField = true)]
        public PmcBomItem SPL_CR_SetLubricateInterval { get; set; }
        [Display(Name = "润滑设定-杆系实际间隔冲次", AutoGenerateField = true)]
        public PmcBomItem SPL_CR_ActualLubricateInterval { get; set; }
        [Display(Name = "润滑设定-杆系润滑检查时间", AutoGenerateField = true)]
        public PmcBomItem SPL_CR_LubricateDetectTime { get; set; }
        [Display(Name = "润滑设定-杆系浓油润滑总次数", AutoGenerateField = true)]
        public PmcBomItem SPL_CR_LubricateTotalNum { get; set; }
        [Display(Name = "润滑设定-杆系开机润滑时间", AutoGenerateField = true)]
        public PmcBomItem SPL_CR_PowerOnLubricateTime { get; set; }
        [Display(Name = "润滑设定-杆系润滑检测", AutoGenerateField = true)]
        public PmcBomItem SPL_CR_LubricateDetecte { get; set; }
        [Display(Name = "润滑设定-气垫润滑泵润滑时间", AutoGenerateField = true)]
        public PmcBomItem SPL_AC_LubricateTime { get; set; }
        [Display(Name = "润滑设定-气垫润滑泵润滑间隔冲次", AutoGenerateField = true)]
        public PmcBomItem SPL_AC_SetLubricateInterval { get; set; }
        [Display(Name = "润滑设定-气垫润滑泵实际间隔冲次", AutoGenerateField = true)]
        public PmcBomItem SPL_AC_ActualLubricateInterval { get; set; }
        [Display(Name = "润滑设定-气垫润滑泵润滑检查时间", AutoGenerateField = true)]
        public PmcBomItem SPL_AC_LubricateDetectTime { get; set; }
        [Display(Name = "润滑设定-气垫润滑泵浓油润滑总次数", AutoGenerateField = true)]
        public PmcBomItem SPL_AC_LubricateTotalNum { get; set; }
        [Display(Name = "润滑设定-气垫润滑泵开机润滑时间", AutoGenerateField = true)]
        public PmcBomItem SPL_AC_PowerOnLubricateTime { get; set; }
        [Display(Name = "润滑设定-气垫润滑泵润滑检测", AutoGenerateField = true)]
        public PmcBomItem SPL_AC_LubricateDetecte { get; set; }
        [Display(Name = "润滑设定-气垫润滑稀油润滑时间", AutoGenerateField = true)]
        public PmcBomItem SPL_AC2_LubricateTime { get; set; }
        [Display(Name = "润滑设定-气垫润滑稀油润滑间隔冲次", AutoGenerateField = true)]
        public PmcBomItem SPL_AC2_SetLubricateInterval { get; set; }
        [Display(Name = "润滑设定-气垫润滑稀油实际间隔冲次", AutoGenerateField = true)]
        public PmcBomItem SPL_AC2_ActualLubricateInterval { get; set; }
        [Display(Name = "润滑设定-气垫润滑稀油润滑检查时间", AutoGenerateField = true)]
        public PmcBomItem SPL_AC2_LubricateDetectTime { get; set; }
        [Display(Name = "润滑设定-气垫润滑稀油浓油润滑总次数", AutoGenerateField = true)]
        public PmcBomItem SPL_AC2_LubricateTotalNum { get; set; }
        [Display(Name = "润滑设定-气垫润滑稀油开机润滑时间", AutoGenerateField = true)]
        public PmcBomItem SPL_AC2_PowerOnLubricateTime { get; set; }
        [Display(Name = "润滑设定-气垫润滑稀油润滑检测", AutoGenerateField = true)]
        public PmcBomItem SPL_AC2_LubricateDetecte { get; set; }
        [Display(Name = "润滑设定-导轨泵润滑换向", AutoGenerateField = true)]
        public PmcBomItem SPL_GR_LubricateReversing { get; set; }
        [Display(Name = "润滑设定-导轨泵润滑检测时间", AutoGenerateField = true)]
        public PmcBomItem SPL_GR_LubricateDetectTime { get; set; }
        [Display(Name = "润滑设定-丝杠泵润滑换向", AutoGenerateField = true)]
        public PmcBomItem SPL_SC_LubricateReversing { get; set; }
        [Display(Name = "润滑设定-补油阀控制补油控制", AutoGenerateField = true)]
        public PmcBomItem SPL_OS_Time { get; set; }
        [Display(Name = "润滑设定-补油阀控制补油间隔", AutoGenerateField = true)]
        public PmcBomItem SPL_OS_IntervalTime { get; set; }
        [Display(Name = "润滑设定-补油阀控制补油延时时间", AutoGenerateField = true)]
        public PmcBomItem SPL_OS_DelayTime { get; set; }
        [Display(Name = "润滑设定-中转泵延时时间", AutoGenerateField = true)]
        public PmcBomItem SPL_TS_DelayTime { get; set; }
        [Display(Name = "润滑设定-中转泵停止时间", AutoGenerateField = true)]
        public PmcBomItem SPL_TS_StopTime { get; set; }
        [Display(Name = "润滑设定-中转泵远行时间", AutoGenerateField = true)]
        public PmcBomItem SPL_TS_RunTime { get; set; }

        #endregion

        #region 系统参数 模拟量设定
        [Display(Name = "模拟量设定-模拟量1", AutoGenerateField = true)]
        public PmcBomItem SPA_A1_Value { get; set; }
        [Display(Name = "模拟量设定-吨位乘值1", AutoGenerateField = true)]
        public PmcBomItem SPA_A1_WeightPara1 { get; set; }
        [Display(Name = "模拟量设定-吨位除值1", AutoGenerateField = true)]
        public PmcBomItem SPA_A1_WeightPara2 { get; set; }
        [Display(Name = "模拟量设定-吨位1", AutoGenerateField = true)]
        public PmcBomItem SPA_A1_Weight { get; set; }
        [Display(Name = "模拟量设定-模拟量2", AutoGenerateField = true)]
        public PmcBomItem SPA_A2_Value { get; set; }
        [Display(Name = "模拟量设定-吨位乘值2", AutoGenerateField = true)]
        public PmcBomItem SPA_A2_WeightPara1 { get; set; }
        [Display(Name = "模拟量设定-吨位除值2", AutoGenerateField = true)]
        public PmcBomItem SPA_A2_WeightPara2 { get; set; }
        [Display(Name = "模拟量设定-吨位2", AutoGenerateField = true)]
        public PmcBomItem SPA_A2_Weight { get; set; }
        [Display(Name = "模拟量设定-模拟量3", AutoGenerateField = true)]
        public PmcBomItem SPA_A3_Value { get; set; }
        [Display(Name = "模拟量设定-吨位乘值3", AutoGenerateField = true)]
        public PmcBomItem SPA_A3_WeightPara1 { get; set; }
        [Display(Name = "模拟量设定-吨位除值3", AutoGenerateField = true)]
        public PmcBomItem SPA_A3_WeightPara2 { get; set; }
        [Display(Name = "模拟量设定-吨位3", AutoGenerateField = true)]
        public PmcBomItem SPA_A3_Weight { get; set; }
        [Display(Name = "模拟量设定-模拟量4", AutoGenerateField = true)]
        public PmcBomItem SPA_A4_Value { get; set; }
        [Display(Name = "模拟量设定-吨位乘值4", AutoGenerateField = true)]
        public PmcBomItem SPA_A4_WeightPara1 { get; set; }
        [Display(Name = "模拟量设定-吨位除值4", AutoGenerateField = true)]
        public PmcBomItem SPA_A4_WeightPara2 { get; set; }
        [Display(Name = "模拟量设定-吨位4", AutoGenerateField = true)]
        public PmcBomItem SPA_A4_Weight { get; set; }

        [Display(Name = "模拟量设定-总吨位", AutoGenerateField = true)]
        public PmcBomItem SPA_TotalWeight { get; set; }
        [Display(Name = "模拟量设定-吨位检测位置", AutoGenerateField = true)]
        public PmcBomItem SPA_DetectPosition { get; set; }
        [Display(Name = "模拟量设定-吨位检测到位位置", AutoGenerateField = true)]
        public PmcBomItem SPA_DetectInPosition { get; set; }
        [Display(Name = "模拟量设定-吨位检测传感器类型", AutoGenerateField = true)]
        public PmcBomItem SPA_DetectSensor { get; set; }
        [Display(Name = "模拟量设定-保压压力", AutoGenerateField = true)]
        public PmcBomItem SPA_Pressure { get; set; }
        [Display(Name = "模拟量设定-压力上偏差", AutoGenerateField = true)]
        public PmcBomItem SPA_PressureUp { get; set; }
        [Display(Name = "模拟量设定-压力下偏差", AutoGenerateField = true)]
        public PmcBomItem SPA_PressureDown { get; set; }

        #endregion

        #region 系统参数 编码器设定
        [Display(Name = "编码器设定-装模高度编码器每圈分辨率", AutoGenerateField = true)]
        public PmcBomItem SPA_IM_RESOLUTION { get; set; }
        [Display(Name = "编码器设定-装模高度编码器每圈移动量", AutoGenerateField = true)]
        public PmcBomItem SPA_IM_MOVEPITCH{ get; set; }
        [Display(Name = "编码器设定-装模高度编码器上升到达位置", AutoGenerateField = true)]
        public PmcBomItem SPA_IM_UPPOSITION { get; set; }
        [Display(Name = "编码器设定-装模高度编码器下降到达位置", AutoGenerateField = true)]
        public PmcBomItem SPA_IM_DOWNPOSITION { get; set; }
        [Display(Name = "编码器设定-装模高度编码器速度切换点", AutoGenerateField = true)]
        public PmcBomItem SPA_IM_SPEEDCHANGEPOSITION { get; set; }
        [Display(Name = "编码器设定-装模高度编码器模高上限", AutoGenerateField = true)]
        public PmcBomItem SPA_IM_LIMITUP { get; set; }
        [Display(Name = "编码器设定-装模高度编码器模高下限", AutoGenerateField = true)]
        public PmcBomItem SPA_IM_LIMITDOWN { get; set; }
        [Display(Name = "编码器设定-装模高度编码器偏差值", AutoGenerateField = true)]
        public PmcBomItem SPA_IM_ERROR { get; set; }
        [Display(Name = "编码器设定-装模高度编码器编码器方向", AutoGenerateField = true)]
        public PmcBomItem SPA_IM_DIRECTION { get; set; }
        [Display(Name = "编码器设定-气垫高度编码器每圈分辨率", AutoGenerateField = true)]
        public PmcBomItem SPA_AC_RESOLUTION { get; set; }
        [Display(Name = "编码器设定-气垫高度编码器每圈移动量", AutoGenerateField = true)]
        public PmcBomItem SPA_AC_MOVEPITCH { get; set; }
        [Display(Name = "编码器设定-气垫高度编码器上升到达位置", AutoGenerateField = true)]
        public PmcBomItem SPA_AC_UPPOSITION { get; set; }
        [Display(Name = "编码器设定-气垫高度编码器下降到达位置", AutoGenerateField = true)]
        public PmcBomItem SPA_AC_DOWNPOSITION { get; set; }
        [Display(Name = "编码器设定-气垫高度编码器模高上限", AutoGenerateField = true)]
        public PmcBomItem SPA_AC_LIMITUP { get; set; }
        [Display(Name = "编码器设定-气垫高度编码器模高下限", AutoGenerateField = true)]
        public PmcBomItem SPA_AC_LIMITDOWN { get; set; }
        [Display(Name = "编码器设定-气垫高度编码器偏差值", AutoGenerateField = true)]
        public PmcBomItem SPA_AC_ERROR { get; set; }
        [Display(Name = "编码器设定-气垫高度编码器编码器方向", AutoGenerateField = true)]
        public PmcBomItem SPA_AC_DIRECTION { get; set; }

        #endregion
    }
}
