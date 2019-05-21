using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Ioc;
using AutoMapper;
using PressHmi.Model;
using PressHmi.View;
using FanucCnc;
using FanucCnc.Model;

namespace PressHmi.ViewModel
{
    public class SParaSubLubricatePageViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }

        public ICommand CR_LubricateTimeSetCmd { get; set; }

        public ICommand CR_SetLubricateIntervalSetCmd { get; set; }

        public ICommand CR_ActualLubricateIntervalSetCmd { get; set; }

        public ICommand CR_LubricateDetectTimeSetCmd { get; set; }

        public ICommand CR_LubricateTotalNumSetCmd { get; set; }

        public ICommand CR_PowerOnLubricateTimeSetCmd { get; set; }

        public ICommand CR_LubricateDetecteSetCmd { get; set; }

        public ICommand AC_LubricateTimeSetCmd { get; set; }

        public ICommand AC_SetLubricateIntervalSetCmd { get; set; }

        public ICommand AC_ActualLubricateIntervalSetCmd { get; set; }

        public ICommand AC_LubricateDetectTimeSetCmd { get; set; }

        public ICommand AC_LubricateTotalNumSetCmd { get; set; }

        public ICommand AC_PowerOnLubricateTimeSetCmd { get; set; }

        public ICommand AC_LubricateDetecteSetCmd { get; set; }

        public ICommand AC2_LubricateTimeSetCmd { get; set; }

        public ICommand AC2_SetLubricateIntervalSetCmd { get; set; }

        public ICommand AC2_ActualLubricateIntervalSetCmd { get; set; }

        public ICommand AC2_LubricateDetectTimeSetCmd { get; set; }

        public ICommand AC2_LubricateTotalNumSetCmd { get; set; }

        public ICommand AC2_PowerOnLubricateTimeSetCmd { get; set; }

        public ICommand AC2_LubricateDetecteSetCmd { get; set; }

        public ICommand GR_LubricateReversingSetCmd { get; set; }

        public ICommand GR_LubricateDetectTimeSetCmd { get; set; }

        public ICommand SC_LubricateReversingSetCmd { get; set; }

        public ICommand OS_TimeSetCmd { get; set; }

        public ICommand OS_IntervalTimeSetCmd { get; set; }

        public ICommand OS_DelayTimeSetCmd { get; set; }

        public ICommand TS_DelayTimeSetCmd { get; set; }

        public ICommand TS_StopTimeSetCmd { get; set; }

        public ICommand TS_RunTimeSetCmd { get; set; }


        private SParaLubricateInfoDto m_SParaLubricateInfo = new SParaLubricateInfoDto();
        public SParaLubricateInfoDto SParaLubricateInfo
        {
            get { return m_SParaLubricateInfo; }
            set
            {
                if (m_SParaLubricateInfo != value)
                {
                    m_SParaLubricateInfo = value;
                    RaisePropertyChanged(() => SParaLubricateInfo);
                }
            }
        }

        public SParaSubLubricatePageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);

            CR_LubricateTimeSetCmd =new RelayCommand(OnCR_LubricateTimeSetCmd);

            CR_SetLubricateIntervalSetCmd =new RelayCommand(OnCR_SetLubricateIntervalSetCmd);

            CR_ActualLubricateIntervalSetCmd =new RelayCommand(OnCR_ActualLubricateIntervalSetCmd);

            CR_LubricateDetectTimeSetCmd =new RelayCommand(OnCR_LubricateDetectTimeSetCmd);

            CR_LubricateTotalNumSetCmd =new RelayCommand(OnCR_LubricateTotalNumSetCmd);

            CR_PowerOnLubricateTimeSetCmd =new RelayCommand(OnCR_PowerOnLubricateTimeSetCmd);

            CR_LubricateDetecteSetCmd =new RelayCommand(OnCR_LubricateDetecteSetCmd);

            AC_LubricateTimeSetCmd =new RelayCommand(OnAC_LubricateTimeSetCmd);

            AC_SetLubricateIntervalSetCmd =new RelayCommand(OnAC_SetLubricateIntervalSetCmd);

            AC_ActualLubricateIntervalSetCmd =new RelayCommand(OnAC_ActualLubricateIntervalSetCmd);

            AC_LubricateDetectTimeSetCmd =new RelayCommand(OnAC_LubricateDetectTimeSetCmd);

            AC_LubricateTotalNumSetCmd =new RelayCommand(OnAC_LubricateTotalNumSetCmd);

            AC_PowerOnLubricateTimeSetCmd =new RelayCommand(OnAC_PowerOnLubricateTimeSetCmd);

            AC_LubricateDetecteSetCmd =new RelayCommand(OnAC_LubricateDetecteSetCmd);

            AC2_LubricateTimeSetCmd =new RelayCommand(OnAC2_LubricateTimeSetCmd);

            AC2_SetLubricateIntervalSetCmd =new RelayCommand(OnAC2_SetLubricateIntervalSetCmd);

            AC2_ActualLubricateIntervalSetCmd =new RelayCommand(OnAC2_ActualLubricateIntervalSetCmd);

            AC2_LubricateDetectTimeSetCmd =new RelayCommand(OnAC2_LubricateDetectTimeSetCmd);

            AC2_LubricateTotalNumSetCmd =new RelayCommand(OnAC2_LubricateTotalNumSetCmd);

            AC2_PowerOnLubricateTimeSetCmd =new RelayCommand(OnAC2_PowerOnLubricateTimeSetCmd);

            AC2_LubricateDetecteSetCmd =new RelayCommand(OnAC2_LubricateDetecteSetCmd);

            GR_LubricateReversingSetCmd =new RelayCommand(OnGR_LubricateReversingSetCmd);

            GR_LubricateDetectTimeSetCmd =new RelayCommand(OnGR_LubricateDetectTimeSetCmd);

            SC_LubricateReversingSetCmd =new RelayCommand(OnSC_LubricateReversingSetCmd);

            OS_TimeSetCmd =new RelayCommand(OnOS_TimeSetCmd);

            OS_IntervalTimeSetCmd =new RelayCommand(OnOS_IntervalTimeSetCmd);

            OS_DelayTimeSetCmd =new RelayCommand(OnOS_DelayTimeSetCmd);

            TS_DelayTimeSetCmd =new RelayCommand(OnTS_DelayTimeSetCmd);

            TS_StopTimeSetCmd =new RelayCommand(OnTS_StopTimeSetCmd);

            TS_RunTimeSetCmd =new RelayCommand(OnTS_RunTimeSetCmd);

            Messenger.Default.Register<SParaLubricateInfo>(this, "SParaLubricateInfoMsg", msg =>
            {
                SParaLubricateInfo = _mapper.Map<SParaLubricateInfo, SParaLubricateInfoDto>(msg);
            });

        }

        public void OnCR_LubricateTimeSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc, 
                _fanuc.CurPmcBom.SPL_CR_LubricateTime, 
                _fanuc.CurLimitBom.SPL_CR_LubricateTime, 
                "输入润滑时间(秒)");
            dlg.ShowDialog();
        }

        public void OnCR_SetLubricateIntervalSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc, 
                _fanuc.CurPmcBom.SPL_CR_SetLubricateInterval, 
                _fanuc.CurLimitBom.SPL_CR_SetLubricateInterval, 
                "输入润滑间隔冲次(次)");
            dlg.ShowDialog();
        }

        public void OnCR_ActualLubricateIntervalSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
               _fanuc.CurPmcBom.SPL_CR_ActualLubricateInterval,
               _fanuc.CurLimitBom.SPL_CR_ActualLubricateInterval,
               "输入实际间隔冲次(次)");
            dlg.ShowDialog();
        }

        public void OnCR_LubricateDetectTimeSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
              _fanuc.CurPmcBom.SPL_CR_LubricateDetectTime,
              _fanuc.CurLimitBom.SPL_CR_LubricateDetectTime,
              "输入润滑检测时间(秒)");
            dlg.ShowDialog();

        }

        public void OnCR_LubricateTotalNumSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
             _fanuc.CurPmcBom.SPL_CR_LubricateTotalNum,
             _fanuc.CurLimitBom.SPL_CR_LubricateTotalNum,
             "输入浓油润滑总次数(次)");
            dlg.ShowDialog();

        }

        public void OnCR_PowerOnLubricateTimeSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
            _fanuc.CurPmcBom.SPL_CR_PowerOnLubricateTime,
            _fanuc.CurLimitBom.SPL_CR_PowerOnLubricateTime,
            "输入开机润滑时间(秒)");
            dlg.ShowDialog();
        }

        public void OnCR_LubricateDetecteSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
           _fanuc.CurPmcBom.SPL_CR_LubricateDetecte,
           _fanuc.CurLimitBom.SPL_CR_LubricateDetecte,
           "输入润滑检测()");
            dlg.ShowDialog();
        }

        public void OnAC_LubricateTimeSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                _fanuc.CurPmcBom.SPL_AC_LubricateTime,
                _fanuc.CurLimitBom.SPL_AC_LubricateTime,
                "输入润滑时间(秒)");
            dlg.ShowDialog();
        }

        public void OnAC_SetLubricateIntervalSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                _fanuc.CurPmcBom.SPL_AC_SetLubricateInterval,
                _fanuc.CurLimitBom.SPL_AC_SetLubricateInterval,
                "输入润滑间隔冲次(次)");
            dlg.ShowDialog();
        }

        public void OnAC_ActualLubricateIntervalSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
               _fanuc.CurPmcBom.SPL_AC_ActualLubricateInterval,
               _fanuc.CurLimitBom.SPL_AC_ActualLubricateInterval,
               "输入实际间隔冲次(次)");
            dlg.ShowDialog();
        }

        public void OnAC_LubricateDetectTimeSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
              _fanuc.CurPmcBom.SPL_AC_LubricateDetectTime,
              _fanuc.CurLimitBom.SPL_AC_LubricateDetectTime,
              "输入润滑检测时间(秒)");
            dlg.ShowDialog();

        }

        public void OnAC_LubricateTotalNumSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
             _fanuc.CurPmcBom.SPL_AC_LubricateTotalNum,
             _fanuc.CurLimitBom.SPL_AC_LubricateTotalNum,
             "输入浓油润滑总次数(次)");
            dlg.ShowDialog();

        }

        public void OnAC_PowerOnLubricateTimeSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
            _fanuc.CurPmcBom.SPL_AC_PowerOnLubricateTime,
            _fanuc.CurLimitBom.SPL_AC_PowerOnLubricateTime,
            "输入开机润滑时间(秒)");
            dlg.ShowDialog();
        }

        public void OnAC_LubricateDetecteSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
           _fanuc.CurPmcBom.SPL_AC_LubricateDetecte,
           _fanuc.CurLimitBom.SPL_AC_LubricateDetecte,
           "输入润滑检测()");
            dlg.ShowDialog();
        }

        public void OnAC2_LubricateTimeSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                _fanuc.CurPmcBom.SPL_AC2_LubricateTime,
                _fanuc.CurLimitBom.SPL_AC2_LubricateTime,
                "输入润滑时间(秒)");
            dlg.ShowDialog();
        }

        public void OnAC2_SetLubricateIntervalSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                _fanuc.CurPmcBom.SPL_AC2_SetLubricateInterval,
                _fanuc.CurLimitBom.SPL_AC2_SetLubricateInterval,
                "输入润滑间隔冲次(次)");
            dlg.ShowDialog();
        }

        public void OnAC2_ActualLubricateIntervalSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
               _fanuc.CurPmcBom.SPL_AC2_ActualLubricateInterval,
               _fanuc.CurLimitBom.SPL_AC2_ActualLubricateInterval,
               "输入实际间隔冲次(次)");
            dlg.ShowDialog();
        }

        public void OnAC2_LubricateDetectTimeSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
              _fanuc.CurPmcBom.SPL_AC2_LubricateDetectTime,
              _fanuc.CurLimitBom.SPL_AC2_LubricateDetectTime,
              "输入润滑检测时间(秒)");
            dlg.ShowDialog();

        }

        public void OnAC2_LubricateTotalNumSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
             _fanuc.CurPmcBom.SPL_AC2_LubricateTotalNum,
             _fanuc.CurLimitBom.SPL_AC2_LubricateTotalNum,
             "输入浓油润滑总次数(次)");
            dlg.ShowDialog();

        }

        public void OnAC2_PowerOnLubricateTimeSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
            _fanuc.CurPmcBom.SPL_AC2_PowerOnLubricateTime,
            _fanuc.CurLimitBom.SPL_AC2_PowerOnLubricateTime,
            "输入开机润滑时间(秒)");
            dlg.ShowDialog();
        }

        public void OnAC2_LubricateDetecteSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
           _fanuc.CurPmcBom.SPL_AC2_LubricateDetecte,
           _fanuc.CurLimitBom.SPL_AC2_LubricateDetecte,
           "输入润滑检测()");
            dlg.ShowDialog();
        }

        public void OnGR_LubricateReversingSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                _fanuc.CurPmcBom.SPL_GR_LubricateReversing,
                _fanuc.CurLimitBom.SPL_GR_LubricateReversing,
                "输入导轨泵润滑换向()");
            dlg.ShowDialog();

        }

        public void OnGR_LubricateDetectTimeSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                _fanuc.CurPmcBom.SPL_GR_LubricateDetectTime,
                _fanuc.CurLimitBom.SPL_GR_LubricateDetectTime,
                "输入导轨润滑检测时间()");
            dlg.ShowDialog();
        }

        public void OnSC_LubricateReversingSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
               _fanuc.CurPmcBom.SPL_SC_LubricateReversing,
               _fanuc.CurLimitBom.SPL_SC_LubricateReversing,
               "输入丝杠泵润滑换向()");
            dlg.ShowDialog();
        }

        public void OnOS_TimeSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
              _fanuc.CurPmcBom.SPL_OS_Time,
              _fanuc.CurLimitBom.SPL_OS_Time,
              "补油时间(秒)");
            dlg.ShowDialog();
        }

        public void OnOS_IntervalTimeSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
             _fanuc.CurPmcBom.SPL_OS_IntervalTime,
             _fanuc.CurLimitBom.SPL_OS_IntervalTime,
             "补油间隔时间(秒)");
            dlg.ShowDialog();
        }

        public void OnOS_DelayTimeSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                _fanuc.CurPmcBom.SPL_OS_DelayTime,
                _fanuc.CurLimitBom.SPL_OS_DelayTime,
                "补油延时时间(秒)");
            dlg.ShowDialog();
        }

        public void OnTS_DelayTimeSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
               _fanuc.CurPmcBom.SPL_TS_DelayTime,
               _fanuc.CurLimitBom.SPL_TS_DelayTime,
               "延时时间(秒)");
            dlg.ShowDialog();
        }

        public void OnTS_StopTimeSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
              _fanuc.CurPmcBom.SPL_TS_StopTime,
              _fanuc.CurLimitBom.SPL_TS_StopTime,
              "中转停止时间(秒)");
            dlg.ShowDialog();
        }
        

        public void OnTS_RunTimeSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                _fanuc.CurPmcBom.SPL_TS_RunTime,
                _fanuc.CurLimitBom.SPL_TS_RunTime,
                "中转运行时间(秒)");
            dlg.ShowDialog();
        }

        private void OnLoaded()
        {
            _fanuc.ChangePageEvent(sparalubricate: true);
        }

        private void OnUnloaded()
        {

        }
    }
}
