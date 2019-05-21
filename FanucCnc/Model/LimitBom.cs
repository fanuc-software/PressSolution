using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class LimitBom
    {
        #region 换模设定
        [Display(Name = "模块")]
        public LimitBomItem DCP_RapidFeed { get; set; }
        [Display(Name = "DCP_JogFeed")]

        public LimitBomItem DCP_JogFeed { get; set; }

        public LimitBomItem DCP_InstallDieHighSet { get; set; }

        public LimitBomItem DCP_CylinderpRressureSet { get; set; }

        public LimitBomItem DCP_DieWeight { get; set; }

        #endregion

        #region 夹模器设定
        public LimitBomItem CLS_ClampStatus1 { get; set; }
        public LimitBomItem CLS_ClampStatus2 { get; set; }
        public LimitBomItem CLS_ClampRelaxPosition { get; set; }
        public LimitBomItem CLS_ClampRelaxInPosition { get; set; }
        public LimitBomItem CLS_Clamp_Front_1_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Front_1_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_1_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_2_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Front_2_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_2_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_3_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Front_3_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_3_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_4_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Front_4_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_4_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_5_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Front_5_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_5_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_6_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Front_6_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_6_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_7_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Front_7_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_7_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_8_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Front_8_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_8_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_9_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Front_9_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_9_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_10_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Front_10_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_10_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_11_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Front_11_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_11_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_12_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Front_12_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_12_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_13_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Front_13_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Front_13_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_1_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Back_1_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_1_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_2_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Back_2_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_2_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_3_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Back_3_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_3_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_4_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Back_4_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_4_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_5_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Back_5_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_5_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_6_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Back_6_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_6_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_7_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Back_7_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_7_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_8_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Back_8_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_8_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_9_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Back_9_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_9_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_10_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Back_10_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_10_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_11_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Back_11_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_11_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_12_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Back_12_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_12_MoveInStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_13_Ebable { get; set; }
        public LimitBomItem CLS_Clamp_Back_13_MoveOutStatus { get; set; }
        public LimitBomItem CLS_Clamp_Back_13_MoveInStatus { get; set; }
        #endregion

        #region 合模设定
        public LimitBomItem DJP_SectionNum { get; set; }

        public LimitBomItem DJP_PreDelayTime { get; set; }

        public LimitBomItem DJP_SafeTime { get; set; }

        public LimitBomItem DJP_Pos_1 { get; set; }
        public LimitBomItem DJP_Speed_1 { get; set; }
        public LimitBomItem DJP_StopTime_1 { get; set; }

        public LimitBomItem DJP_Pos_2 { get; set; }
        public LimitBomItem DJP_Speed_2 { get; set; }
        public LimitBomItem DJP_StopTime_2 { get; set; }

        public LimitBomItem DJP_Pos_3 { get; set; }
        public LimitBomItem DJP_Speed_3 { get; set; }
        public LimitBomItem DJP_StopTime_3 { get; set; }

        public LimitBomItem DJP_Pos_4 { get; set; }
        public LimitBomItem DJP_Speed_4 { get; set; }
        public LimitBomItem DJP_StopTime_4 { get; set; }

        public LimitBomItem DJP_Pos_5 { get; set; }
        public LimitBomItem DJP_Speed_5 { get; set; }
        public LimitBomItem DJP_StopTime_5 { get; set; }

        public LimitBomItem DJP_Pos_6 { get; set; }
        public LimitBomItem DJP_Speed_6 { get; set; }
        public LimitBomItem DJP_StopTime_6 { get; set; }

        public LimitBomItem DJP_Pos_7 { get; set; }
        public LimitBomItem DJP_Speed_7 { get; set; }
        public LimitBomItem DJP_StopTime_7 { get; set; }

        public LimitBomItem DJP_Pos_8 { get; set; }
        public LimitBomItem DJP_Speed_8 { get; set; }
        public LimitBomItem DJP_StopTime_8 { get; set; }

        public LimitBomItem DJP_BottomDeadCentre { get; set; }

        #endregion

        #region 分模设定
        public LimitBomItem DPP_SectionNum { get; set; }

        public LimitBomItem DPP_PreDelayTime { get; set; }

        public LimitBomItem DPP_SafeTime { get; set; }

        public LimitBomItem DPP_Pos_1 { get; set; }
        public LimitBomItem DPP_Speed_1 { get; set; }
        public LimitBomItem DPP_StopTime_1 { get; set; }

        public LimitBomItem DPP_Pos_2 { get; set; }
        public LimitBomItem DPP_Speed_2 { get; set; }
        public LimitBomItem DPP_StopTime_2 { get; set; }

        public LimitBomItem DPP_Pos_3 { get; set; }
        public LimitBomItem DPP_Speed_3 { get; set; }
        public LimitBomItem DPP_StopTime_3 { get; set; }

        public LimitBomItem DPP_Pos_4 { get; set; }
        public LimitBomItem DPP_Speed_4 { get; set; }
        public LimitBomItem DPP_StopTime_4 { get; set; }

        public LimitBomItem DPP_Pos_5 { get; set; }
        public LimitBomItem DPP_Speed_5 { get; set; }
        public LimitBomItem DPP_StopTime_5 { get; set; }

        public LimitBomItem DPP_Pos_6 { get; set; }
        public LimitBomItem DPP_Speed_6 { get; set; }
        public LimitBomItem DPP_StopTime_6 { get; set; }

        public LimitBomItem DPP_Pos_7 { get; set; }
        public LimitBomItem DPP_Speed_7 { get; set; }
        public LimitBomItem DPP_StopTime_7 { get; set; }

        public LimitBomItem DPP_Pos_8 { get; set; }
        public LimitBomItem DPP_Speed_8 { get; set; }
        public LimitBomItem DPP_StopTime_8 { get; set; }

        public LimitBomItem DPP_BottomDeadCentre { get; set; }

        #endregion

        #region 保压设定
        public LimitBomItem SPP_Pressure { get; set; }

        public LimitBomItem SPP_Time { get; set; }

        public LimitBomItem SPP_PreDelayTime { get; set; }

        public LimitBomItem SPP_ChangeMode { get; set; }

        public LimitBomItem SPP_ChangePressure { get; set; }

        #endregion

        #region 自动化气源
        public LimitBomItem AAS_StartPos_1 { get; set; }
        public LimitBomItem AAS_EndPos_1 { get; set; }

        public LimitBomItem AAS_StartPos_2 { get; set; }
        public LimitBomItem AAS_EndPos_2 { get; set; }

        public LimitBomItem AAS_StartPos_3 { get; set; }
        public LimitBomItem AAS_EndPos_3 { get; set; }

        public LimitBomItem AAS_StartPos_4 { get; set; }
        public LimitBomItem AAS_EndPos_4 { get; set; }

        #endregion

        #region 系统参数 压机设定
        public LimitBomItem SPM_MaxWeight { get; set; }
        public LimitBomItem SPM_MaxTemperature { get; set; }
        public LimitBomItem SPM_MaxError { get; set; }
        public LimitBomItem SPM_PressureSensorPara { get; set; }
        public LimitBomItem SPM_BalanceCylinderAnalog { get; set; }
        public LimitBomItem SPM_BalanceCylinderPressure { get; set; }
        public LimitBomItem SPM_OverflowDelay { get; set; }
        public LimitBomItem SPM_PressureDiffPara { get; set; }
        public LimitBomItem SPM_PressureLowAlarm { get; set; }
        public LimitBomItem SPM_LubricateDetect { get; set; }

        #endregion

        #region 系统参数 润滑设定
        public LimitBomItem SPL_CR_LubricateTime { get; set; }

        public LimitBomItem SPL_CR_SetLubricateInterval { get; set; }

        public LimitBomItem SPL_CR_ActualLubricateInterval { get; set; }

        public LimitBomItem SPL_CR_LubricateDetectTime { get; set; }

        public LimitBomItem SPL_CR_LubricateTotalNum { get; set; }

        public LimitBomItem SPL_CR_PowerOnLubricateTime { get; set; }

        public LimitBomItem SPL_CR_LubricateDetecte { get; set; }

        public LimitBomItem SPL_AC_LubricateTime { get; set; }

        public LimitBomItem SPL_AC_SetLubricateInterval { get; set; }

        public LimitBomItem SPL_AC_ActualLubricateInterval { get; set; }

        public LimitBomItem SPL_AC_LubricateDetectTime { get; set; }

        public LimitBomItem SPL_AC_LubricateTotalNum { get; set; }

        public LimitBomItem SPL_AC_PowerOnLubricateTime { get; set; }

        public LimitBomItem SPL_AC_LubricateDetecte { get; set; }

        public LimitBomItem SPL_AC2_LubricateTime { get; set; }

        public LimitBomItem SPL_AC2_SetLubricateInterval { get; set; }

        public LimitBomItem SPL_AC2_ActualLubricateInterval { get; set; }

        public LimitBomItem SPL_AC2_LubricateDetectTime { get; set; }

        public LimitBomItem SPL_AC2_LubricateTotalNum { get; set; }

        public LimitBomItem SPL_AC2_PowerOnLubricateTime { get; set; }

        public LimitBomItem SPL_AC2_LubricateDetecte { get; set; }

        public LimitBomItem SPL_GR_LubricateReversing { get; set; }

        public LimitBomItem SPL_GR_LubricateDetectTime { get; set; }

        public LimitBomItem SPL_SC_LubricateReversing { get; set; }

        public LimitBomItem SPL_OS_Time { get; set; }

        public LimitBomItem SPL_OS_IntervalTime { get; set; }

        public LimitBomItem SPL_OS_DelayTime { get; set; }

        public LimitBomItem SPL_TS_DelayTime { get; set; }

        public LimitBomItem SPL_TS_StopTime { get; set; }

        public LimitBomItem SPL_TS_RunTime { get; set; }

        #endregion

        #region 系统参数 模拟量设定
        public LimitBomItem SPA_A1_Value { get; set; }
        public LimitBomItem SPA_A1_WeightPara1 { get; set; }
        public LimitBomItem SPA_A1_WeightPara2 { get; set; }
        public LimitBomItem SPA_A1_Weight { get; set; }
        public LimitBomItem SPA_A2_Value { get; set; }
        public LimitBomItem SPA_A2_WeightPara1 { get; set; }
        public LimitBomItem SPA_A2_WeightPara2 { get; set; }
        public LimitBomItem SPA_A2_Weight { get; set; }
        public LimitBomItem SPA_A3_Value { get; set; }
        public LimitBomItem SPA_A3_WeightPara1 { get; set; }
        public LimitBomItem SPA_A3_WeightPara2 { get; set; }
        public LimitBomItem SPA_A3_Weight { get; set; }
        public LimitBomItem SPA_A4_Value { get; set; }
        public LimitBomItem SPA_A4_WeightPara1 { get; set; }
        public LimitBomItem SPA_A4_WeightPara2 { get; set; }
        public LimitBomItem SPA_A4_Weight { get; set; }

        public LimitBomItem SPA_TotalWeight { get; set; }
        public LimitBomItem SPA_DetectPosition { get; set; }
        public LimitBomItem SPA_DetectInPosition { get; set; }
        public LimitBomItem SPA_DetectSensor { get; set; }

        public LimitBomItem SPA_Pressure { get; set; }
        public LimitBomItem SPA_PressureUp { get; set; }
        public LimitBomItem SPA_PressureDown { get; set; }

        #endregion

        #region 系统参数 编码器设定
        public LimitBomItem SPA_IM_RESOLUTION { get; set; }
        public LimitBomItem SPA_IM_MOVEPITCH { get; set; }
        public LimitBomItem SPA_IM_UPPOSITION { get; set; }
        public LimitBomItem SPA_IM_DOWNPOSITION { get; set; }
        public LimitBomItem SPA_IM_SPEEDCHANGEPOSITION { get; set; }

        public LimitBomItem SPA_IM_LIMITUP { get; set; }
        public LimitBomItem SPA_IM_LIMITDOWN { get; set; }
        public LimitBomItem SPA_IM_ERROR { get; set; }
        public LimitBomItem SPA_IM_DIRECTION { get; set; }

        public LimitBomItem SPA_AC_RESOLUTION { get; set; }
        public LimitBomItem SPA_AC_MOVEPITCH { get; set; }
        public LimitBomItem SPA_AC_UPPOSITION { get; set; }
        public LimitBomItem SPA_AC_DOWNPOSITION { get; set; }

        public LimitBomItem SPA_AC_LIMITUP { get; set; }
        public LimitBomItem SPA_AC_LIMITDOWN { get; set; }
        public LimitBomItem SPA_AC_ERROR { get; set; }
        public LimitBomItem SPA_AC_DIRECTION { get; set; }

        #endregion
    }
}
