using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class PmcBom
    {
        #region 状态栏
        public PmcBomItem Mode { get; set; }

        public PmcBomItem MainStatus { get; set; }

        public PmcBomItem SliderPressure { get; set; }

        public PmcBomItem BalanceCylinderPressure { get; set; }

        public PmcBomItem InstallDieHigh { get; set; }

        public PmcBomItem TotalPiece { get; set; }

        public PmcBomItem TotalWork { get; set; }

        public PmcBomItem DayPiece { get; set; }

        public PmcBomItem DayWork { get; set; }

        #endregion

        #region 状态监控
        public PmcBomItem SMP_CylinderMode { get; set; }

        public PmcBomItem SMP_LoaderState { get; set; }

        public PmcBomItem SMP_WorkStep { get; set; }

        public PmcBomItem SMP_SliderPressure { get; set; }

        public PmcBomItem SMP_SliderTemperature { get; set; }

        #endregion

        #region 夹模器设定
        public PmcBomItem CLS_ClampStatus1 { get; set; }
        public PmcBomItem CLS_ClampStatus2 { get; set; }
        public PmcBomItem CLS_ClampRelaxPosition { get; set; }
        public PmcBomItem CLS_ClampRelaxInPosition { get; set; }     
        public PmcBomItem CLS_Clamp_Front_1_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Front_1_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_1_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_2_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Front_2_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_2_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_3_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Front_3_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_3_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_4_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Front_4_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_4_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_5_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Front_5_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_5_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_6_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Front_6_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_6_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_7_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Front_7_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_7_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_8_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Front_8_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_8_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_9_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Front_9_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_9_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_10_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Front_10_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_10_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_11_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Front_11_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_11_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_12_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Front_12_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_12_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_13_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Front_13_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Front_13_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_1_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Back_1_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_1_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_2_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Back_2_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_2_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_3_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Back_3_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_3_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_4_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Back_4_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_4_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_5_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Back_5_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_5_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_6_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Back_6_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_6_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_7_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Back_7_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_7_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_8_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Back_8_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_8_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_9_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Back_9_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_9_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_10_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Back_10_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_10_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_11_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Back_11_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_11_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_12_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Back_12_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_12_MoveInStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_13_Ebable { get; set; }
        public PmcBomItem CLS_Clamp_Back_13_MoveOutStatus { get; set; }
        public PmcBomItem CLS_Clamp_Back_13_MoveInStatus { get; set; }
        #endregion

        #region 换模设定
        public PmcBomItem DCP_RapidFeed { get; set; }
        
        public PmcBomItem DCP_JogFeed { get; set; }

        public PmcBomItem DCP_InstallDieHighSet { get; set; }

        public PmcBomItem DCP_InstallDieHighActual { get; set; }

        public PmcBomItem DCP_CylinderpRressureSet { get; set; }

        public PmcBomItem DCP_CylinderpRressureActual { get; set; }

        public PmcBomItem DCP_DieWeight { get; set; }

        public PmcBomItem DCP_LoaderSafePosition { get; set; }

        #endregion

        #region 自动化气源
        public PmcBomItem AAS_StartPos_1 { get; set; }
        public PmcBomItem AAS_StartArr_1 { get; set; }
        public PmcBomItem AAS_EndPos_1 { get; set; }
        public PmcBomItem AAS_EndArr_1 { get; set; }
        public PmcBomItem AAS_ActionFlag_1 { get; set; }

        public PmcBomItem AAS_StartPos_2 { get; set; }
        public PmcBomItem AAS_StartArr_2 { get; set; }
        public PmcBomItem AAS_EndPos_2 { get; set; }
        public PmcBomItem AAS_EndArr_2 { get; set; }
        public PmcBomItem AAS_ActionFlag_2 { get; set; }

        public PmcBomItem AAS_StartPos_3 { get; set; }
        public PmcBomItem AAS_StartArr_3 { get; set; }
        public PmcBomItem AAS_EndPos_3 { get; set; }
        public PmcBomItem AAS_EndArr_3 { get; set; }
        public PmcBomItem AAS_ActionFlag_3 { get; set; }

        public PmcBomItem AAS_StartPos_4 { get; set; }
        public PmcBomItem AAS_StartArr_4 { get; set; }
        public PmcBomItem AAS_EndPos_4 { get; set; }
        public PmcBomItem AAS_EndArr_4 { get; set; }
        public PmcBomItem AAS_ActionFlag_4 { get; set; }
        #endregion

        #region 工件计数
        public PmcBomItem WPP_DayPiece { get; set; }
        public PmcBomItem WPP_DayWork { get; set; }
        public PmcBomItem WPP_CurPiece { get; set; }
        public PmcBomItem WPP_SetPiece { get; set; }

        public PmcBomItem WPP_CurPiece2 { get; set; }
        public PmcBomItem WPP_TotalPiece { get; set; }
        public PmcBomItem WPP_TotalWork { get; set; }

        #endregion

        #region 系统参数 压机设定
        public PmcBomItem SPM_MaxWeight { get; set; }
        public PmcBomItem SPM_MaxTemperature { get; set; }
        public PmcBomItem SPM_MaxError { get; set; }
        public PmcBomItem SPM_PressureSensorPara { get; set; }
        public PmcBomItem SPM_BalanceCylinderAnalog { get; set; }
        public PmcBomItem SPM_BalanceCylinderPressure { get; set; }
        public PmcBomItem SPM_OverflowDelay { get; set; }
        public PmcBomItem SPM_PressureDiffPara { get; set; }

        public PmcBomItem SPM_PressureLowAlarm { get; set; }
        public PmcBomItem SPM_LubricateDetect { get; set; }

        #endregion

        #region 系统参数 润滑设定
        public PmcBomItem SPL_CR_LubricateTime { get; set; }

        public PmcBomItem SPL_CR_SetLubricateInterval { get; set; }

        public PmcBomItem SPL_CR_ActualLubricateInterval { get; set; }

        public PmcBomItem SPL_CR_LubricateDetectTime { get; set; }

        public PmcBomItem SPL_CR_LubricateTotalNum { get; set; }

        public PmcBomItem SPL_CR_PowerOnLubricateTime { get; set; }

        public PmcBomItem SPL_CR_LubricateDetecte { get; set; }

        public PmcBomItem SPL_AC_LubricateTime { get; set; }

        public PmcBomItem SPL_AC_SetLubricateInterval { get; set; }

        public PmcBomItem SPL_AC_ActualLubricateInterval { get; set; }

        public PmcBomItem SPL_AC_LubricateDetectTime { get; set; }

        public PmcBomItem SPL_AC_LubricateTotalNum { get; set; }

        public PmcBomItem SPL_AC_PowerOnLubricateTime { get; set; }

        public PmcBomItem SPL_AC_LubricateDetecte { get; set; }

        public PmcBomItem SPL_AC2_LubricateTime { get; set; }

        public PmcBomItem SPL_AC2_SetLubricateInterval { get; set; }

        public PmcBomItem SPL_AC2_ActualLubricateInterval { get; set; }

        public PmcBomItem SPL_AC2_LubricateDetectTime { get; set; }

        public PmcBomItem SPL_AC2_LubricateTotalNum { get; set; }

        public PmcBomItem SPL_AC2_PowerOnLubricateTime { get; set; }

        public PmcBomItem SPL_AC2_LubricateDetecte { get; set; }

        public PmcBomItem SPL_GR_LubricateReversing { get; set; }

        public PmcBomItem SPL_GR_LubricateDetectTime { get; set; }

        public PmcBomItem SPL_SC_LubricateReversing { get; set; }

        public PmcBomItem SPL_OS_Time { get; set; }

        public PmcBomItem SPL_OS_IntervalTime { get; set; }

        public PmcBomItem SPL_OS_DelayTime { get; set; }

        public PmcBomItem SPL_TS_DelayTime { get; set; }

        public PmcBomItem SPL_TS_StopTime { get; set; }

        public PmcBomItem SPL_TS_RunTime { get; set; }

        #endregion

        #region 系统参数 模拟量设定
        public PmcBomItem SPA_A1_Value { get; set; }
        public PmcBomItem SPA_A1_WeightPara1 { get; set; }
        public PmcBomItem SPA_A1_WeightPara2 { get; set; }
        public PmcBomItem SPA_A1_Weight { get; set; }
        public PmcBomItem SPA_A2_Value { get; set; }
        public PmcBomItem SPA_A2_WeightPara1 { get; set; }
        public PmcBomItem SPA_A2_WeightPara2 { get; set; }
        public PmcBomItem SPA_A2_Weight { get; set; }
        public PmcBomItem SPA_A3_Value { get; set; }
        public PmcBomItem SPA_A3_WeightPara1 { get; set; }
        public PmcBomItem SPA_A3_WeightPara2 { get; set; }
        public PmcBomItem SPA_A3_Weight { get; set; }
        public PmcBomItem SPA_A4_Value { get; set; }
        public PmcBomItem SPA_A4_WeightPara1 { get; set; }
        public PmcBomItem SPA_A4_WeightPara2 { get; set; }
        public PmcBomItem SPA_A4_Weight { get; set; }
               
        public PmcBomItem SPA_TotalWeight { get; set; }
        public PmcBomItem SPA_DetectPosition { get; set; }
        public PmcBomItem SPA_DetectInPosition { get; set; }
        public PmcBomItem SPA_DetectSensor { get; set; }
               
        public PmcBomItem SPA_Pressure { get; set; }
        public PmcBomItem SPA_PressureUp { get; set; }
        public PmcBomItem SPA_PressureDown { get; set; }

        #endregion

        #region 系统参数 编码器设定
        public PmcBomItem SPA_IM_RESOLUTION { get; set; }
        public PmcBomItem SPA_IM_MOVEPITCH{ get; set; }
        public PmcBomItem SPA_IM_UPPOSITION { get; set; }
        public PmcBomItem SPA_IM_DOWNPOSITION { get; set; }
        public PmcBomItem SPA_IM_SPEEDCHANGEPOSITION { get; set; }

        public PmcBomItem SPA_IM_LIMITUP { get; set; }
        public PmcBomItem SPA_IM_LIMITDOWN { get; set; }
        public PmcBomItem SPA_IM_ERROR { get; set; }
        public PmcBomItem SPA_IM_DIRECTION { get; set; }

        public PmcBomItem SPA_AC_RESOLUTION { get; set; }
        public PmcBomItem SPA_AC_MOVEPITCH { get; set; }
        public PmcBomItem SPA_AC_UPPOSITION { get; set; }
        public PmcBomItem SPA_AC_DOWNPOSITION { get; set; }

        public PmcBomItem SPA_AC_LIMITUP { get; set; }
        public PmcBomItem SPA_AC_LIMITDOWN { get; set; }
        public PmcBomItem SPA_AC_ERROR { get; set; }
        public PmcBomItem SPA_AC_DIRECTION { get; set; }

        #endregion
    }
}
