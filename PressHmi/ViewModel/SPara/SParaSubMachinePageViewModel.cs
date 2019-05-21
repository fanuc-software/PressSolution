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
    public class SParaSubMachinePageViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;
        
        public ICommand MaxWeightSetCmd { get; set; }
        public ICommand MaxTemperatureSetCmd { get; set; }
        public ICommand MaxErrorSetCmd { get; set; }
        public ICommand PressureSensorParaSetCmd { get; set; }
        public ICommand BalanceCylinderAnalogSetCmd { get; set; }
        public ICommand BalanceCylinderPressureSetCmd { get; set; }
        public ICommand OverflowDelaySetCmd { get; set; }
        public ICommand PressureDiffParaSetCmd { get; set; }
        public ICommand PressureLowAlarmSetCmd { get; set; }
        public ICommand LubricateDetectSetCmd { get; set; }

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }

        private SParaMachineInfoDto m_SParaMachineInfo = new SParaMachineInfoDto();
        public SParaMachineInfoDto SParaMachineInfo
        {
            get { return m_SParaMachineInfo; }
            set
            {
                if (m_SParaMachineInfo != value)
                {
                    m_SParaMachineInfo = value;
                    RaisePropertyChanged(() => SParaMachineInfo);
                }
            }
        }

        public SParaSubMachinePageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);

            MaxWeightSetCmd = new RelayCommand(OnMaxWeightSetCmd);
            MaxTemperatureSetCmd = new RelayCommand(OnMaxTemperatureSetCmd);
            MaxErrorSetCmd = new RelayCommand(OnMaxErrorSetCmd);
            PressureSensorParaSetCmd = new RelayCommand(OnPressureSensorParaSetCmd);
            BalanceCylinderAnalogSetCmd = new RelayCommand(OnBalanceCylinderAnalogSetCmd);
            BalanceCylinderPressureSetCmd = new RelayCommand(OnBalanceCylinderPressureSetCmd);
            OverflowDelaySetCmd = new RelayCommand(OnOverflowDelaySetCmd);
            PressureDiffParaSetCmd = new RelayCommand(OnPressureDiffParaSetCmd);
            PressureLowAlarmSetCmd = new RelayCommand(OnPressureLowAlarmSetCmd);
            LubricateDetectSetCmd = new RelayCommand(OnLubricateDetectSetCmd);

            Messenger.Default.Register<SParaMachineInfo>(this, "SParaMachineInfoMsg", msg =>
            {
                SParaMachineInfo = _mapper.Map<SParaMachineInfo, SParaMachineInfoDto>(msg);
            });

        }

        private void OnMaxWeightSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.SPM_MaxWeight, _fanuc.CurLimitBom.SPM_MaxWeight, "输入最大吨位(T)");
            dlg.ShowDialog();
        }

        private void OnMaxTemperatureSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.SPM_MaxTemperature, _fanuc.CurLimitBom.SPM_MaxTemperature, "输入最大温度(℃)");
            dlg.ShowDialog();
        }

        private void OnMaxErrorSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.SPM_MaxError, _fanuc.CurLimitBom.SPM_MaxError, "输入允许误差设定()");
            dlg.ShowDialog();
        }

        private void OnPressureSensorParaSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.SPM_PressureSensorPara, _fanuc.CurLimitBom.SPM_PressureSensorPara, "输入压力传感器转换值()");
            dlg.ShowDialog();
        }

        private void OnBalanceCylinderAnalogSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.SPM_PressureLowAlarm, _fanuc.CurLimitBom.SPM_PressureLowAlarm, "输入平衡缸模拟量()");
            dlg.ShowDialog();
        }

        private void OnBalanceCylinderPressureSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.SPM_BalanceCylinderPressure, _fanuc.CurLimitBom.SPM_BalanceCylinderPressure, "输入平衡缸压力()");
            dlg.ShowDialog();
        }

        private void OnOverflowDelaySetCmd()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.SPM_OverflowDelay, _fanuc.CurLimitBom.SPM_OverflowDelay, "输入溢流延时()");
            dlg.ShowDialog();
        }

        private void OnPressureDiffParaSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.SPM_PressureDiffPara, _fanuc.CurLimitBom.SPM_PressureDiffPara, "输入压力差调节()");
            dlg.ShowDialog();
        }

        private void OnPressureLowAlarmSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.SPM_PressureLowAlarm, _fanuc.CurLimitBom.SPM_PressureLowAlarm, "低压报警()");
            dlg.ShowDialog();
        }

        private void OnLubricateDetectSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.SPM_LubricateDetect, _fanuc.CurLimitBom.SPM_LubricateDetect, "输入润滑检测()");
            dlg.ShowDialog();
        }

        private void OnLoaded()
        {
            _fanuc.ChangePageEvent(sparamachine: true);
        }

        private void OnUnloaded()
        {

        }
    }
}
