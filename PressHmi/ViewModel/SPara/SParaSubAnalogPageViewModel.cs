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
    public class SParaSubAnalogPageViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }

        public ICommand A1_ValueSetCmd { get; set; }
        public ICommand A1_WeightPara1SetCmd { get; set; }
        public ICommand A1_WeightPara2SetCmd { get; set; }
        public ICommand A1_WeightSetCmd { get; set; }
        public ICommand A2_ValueSetCmd { get; set; }
        public ICommand A2_WeightPara1SetCmd { get; set; }
        public ICommand A2_WeightPara2SetCmd { get; set; }
        public ICommand A2_WeightSetCmd { get; set; }
        public ICommand A3_ValueSetCmd { get; set; }
        public ICommand A3_WeightPara1SetCmd { get; set; }
        public ICommand A3_WeightPara2SetCmd { get; set; }
        public ICommand A3_WeightSetCmd { get; set; }
        public ICommand A4_ValueSetCmd { get; set; }
        public ICommand A4_WeightPara1SetCmd { get; set; }
        public ICommand A4_WeightPara2SetCmd { get; set; }
        public ICommand A4_WeightSetCmd { get; set; }
        public ICommand TotalWeightSetCmd { get; set; }
        public ICommand DetectPositionSetCmd { get; set; }
        public ICommand DetectInPositionSetCmd { get; set; }
        public ICommand DetectSensorSetCmd { get; set; }
        public ICommand PressureSetCmd { get; set; }
        public ICommand PressureUpSetCmd { get; set; }
        public ICommand PressureDownSetCmd { get; set; }

        private SParaAnalogInfoDto m_SParaAnalogInfo = new SParaAnalogInfoDto();
        public SParaAnalogInfoDto SParaAnalogInfo
        {
            get { return m_SParaAnalogInfo; }
            set
            {
                if (m_SParaAnalogInfo != value)
                {
                    m_SParaAnalogInfo = value;
                    RaisePropertyChanged(() => SParaAnalogInfo);
                }
            }
        }

        public SParaSubAnalogPageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);
            

            A1_ValueSetCmd= new RelayCommand(OnA1_ValueSetCmd);
            A1_WeightPara1SetCmd= new RelayCommand(OnA1_WeightPara1SetCmd);
            A1_WeightPara2SetCmd= new RelayCommand(OnA1_WeightPara2SetCmd);
            A1_WeightSetCmd= new RelayCommand(OnA1_WeightSetCmd);
            A2_ValueSetCmd= new RelayCommand(OnA2_ValueSetCmd);
            A2_WeightPara1SetCmd= new RelayCommand(OnA2_WeightPara1SetCmd);
            A2_WeightPara2SetCmd= new RelayCommand(OnA2_WeightPara2SetCmd);
            A2_WeightSetCmd= new RelayCommand(OnA2_WeightSetCmd);
            A3_ValueSetCmd= new RelayCommand(OnA3_ValueSetCmd);
            A3_WeightPara1SetCmd= new RelayCommand(OnA3_WeightPara1SetCmd);
            A3_WeightPara2SetCmd= new RelayCommand(OnA3_WeightPara2SetCmd);
            A3_WeightSetCmd= new RelayCommand(OnA3_WeightSetCmd);
            A4_ValueSetCmd= new RelayCommand(OnA4_ValueSetCmd);
            A4_WeightPara1SetCmd= new RelayCommand(OnA4_WeightPara1SetCmd);
            A4_WeightPara2SetCmd= new RelayCommand(OnA4_WeightPara2SetCmd);
            A4_WeightSetCmd= new RelayCommand(OnA4_WeightSetCmd);
            TotalWeightSetCmd= new RelayCommand(OnTotalWeightSetCmd);
            DetectPositionSetCmd= new RelayCommand(OnDetectPositionSetCmd);
            DetectInPositionSetCmd= new RelayCommand(OnDetectInPositionSetCmd);
            DetectSensorSetCmd= new RelayCommand(OnDetectSensorSetCmd);
            PressureSetCmd= new RelayCommand(OnPressureSetCmd);
            PressureUpSetCmd= new RelayCommand(OnPressureUpSetCmd);
            PressureDownSetCmd= new RelayCommand(OnPressureDownSetCmd);

            Messenger.Default.Register<SParaAnalogInfo>(this, "SParaAnalogInfoMsg", msg =>
            {
                SParaAnalogInfo = _mapper.Map<SParaAnalogInfo, SParaAnalogInfoDto>(msg);
            });

        }

        private void OnLoaded()
        {
            _fanuc.ChangePageEvent(sparaanalog: true);
        }

        private void OnUnloaded()
        {

        }

        private void OnA1_ValueSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_A1_Value,
                    _fanuc.CurLimitBom.SPA_A1_Value,
                    "模拟量标定1--输入模拟量V");
            dlg.ShowDialog();
        }

        private void OnA1_WeightPara1SetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_A1_WeightPara1,
                    _fanuc.CurLimitBom.SPA_A1_WeightPara1,
                    "模拟量标定1--吨位乘值");
            dlg.ShowDialog();
        }

        private void OnA1_WeightPara2SetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_A1_WeightPara2,
                    _fanuc.CurLimitBom.SPA_A1_WeightPara2,
                    "模拟量标定1--吨位除值");
            dlg.ShowDialog();
        }

        private void OnA1_WeightSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_A1_Weight,
                    _fanuc.CurLimitBom.SPA_A1_Weight,
                    "模拟量标定1--吨位T");
            dlg.ShowDialog();
        }

        private void OnA2_ValueSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_A2_Value,
                    _fanuc.CurLimitBom.SPA_A2_Value,
                    "模拟量标定2--输入模拟量V");
            dlg.ShowDialog();
        }

        private void OnA2_WeightPara1SetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_A2_WeightPara1,
                    _fanuc.CurLimitBom.SPA_A2_WeightPara1,
                    "模拟量标定2--吨位乘值");
            dlg.ShowDialog();
        }

        private void OnA2_WeightPara2SetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_A2_WeightPara2,
                    _fanuc.CurLimitBom.SPA_A2_WeightPara2,
                    "模拟量标定2--吨位除值");
            dlg.ShowDialog();
        }

        private void OnA2_WeightSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_A2_Weight,
                    _fanuc.CurLimitBom.SPA_A2_Weight,
                    "模拟量标定2--吨位T");
            dlg.ShowDialog();
        }

        private void OnA3_ValueSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_A3_Value,
                    _fanuc.CurLimitBom.SPA_A3_Value,
                    "模拟量标定3--输入模拟量V");
            dlg.ShowDialog();
        }

        private void OnA3_WeightPara1SetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_A3_WeightPara1,
                    _fanuc.CurLimitBom.SPA_A3_WeightPara1,
                    "模拟量标定3--吨位乘值");
            dlg.ShowDialog();
        }

        private void OnA3_WeightPara2SetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_A3_WeightPara2,
                    _fanuc.CurLimitBom.SPA_A3_WeightPara2,
                    "模拟量标定3--吨位除值");
            dlg.ShowDialog();
        }

        private void OnA3_WeightSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_A3_Weight,
                    _fanuc.CurLimitBom.SPA_A3_Weight,
                    "模拟量标定3--吨位T");
            dlg.ShowDialog();
        }

        private void OnA4_ValueSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_A4_Value,
                    _fanuc.CurLimitBom.SPA_A4_Value,
                    "模拟量标定4--输入模拟量V");
            dlg.ShowDialog();
        }

        private void OnA4_WeightPara1SetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_A4_WeightPara1,
                    _fanuc.CurLimitBom.SPA_A4_WeightPara1,
                    "模拟量标定4--吨位乘值");
            dlg.ShowDialog();
        }

        private void OnA4_WeightPara2SetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_A4_WeightPara2,
                    _fanuc.CurLimitBom.SPA_A4_WeightPara2,
                    "模拟量标定4--吨位除值");
            dlg.ShowDialog();
        }

        private void OnA4_WeightSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_A4_Weight,
                    _fanuc.CurLimitBom.SPA_A4_Weight,
                    "模拟量标定4--吨位T");
            dlg.ShowDialog();
        }

        private void OnTotalWeightSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_TotalWeight,
                    _fanuc.CurLimitBom.SPA_TotalWeight,
                    "检测设定--总吨位");
            dlg.ShowDialog();
        }
        private void OnDetectPositionSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_DetectPosition,
                    _fanuc.CurLimitBom.SPA_DetectPosition,
                    "检测设定--吨位检测位置");
            dlg.ShowDialog();
        }
        private void OnDetectInPositionSetCmd()
        {

        }
        private void OnDetectSensorSetCmd()
        {

        }
        private void OnPressureSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_Pressure,
                    _fanuc.CurLimitBom.SPA_Pressure,
                    "HPM设定--保压压力");
            dlg.ShowDialog();
        }
        private void OnPressureUpSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_PressureUp,
                    _fanuc.CurLimitBom.SPA_PressureUp,
                    "HPM设定--压力上偏差");
            dlg.ShowDialog();
        }
        private void OnPressureDownSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_PressureDown,
                    _fanuc.CurLimitBom.SPA_PressureDown,
                    "HPM设定--压力下偏差");
            dlg.ShowDialog();
        }


    }
}
