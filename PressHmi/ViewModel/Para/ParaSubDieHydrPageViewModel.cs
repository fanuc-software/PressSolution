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
    public class ParaSubDieHydrPageViewModel : MyBaseViewModel
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }

        public ICommand Pressure_SetCmd { get; set; }
        public ICommand PushPos_SetCmd { get; set; }
        public ICommand PushDelayTime_SetCmd { get; set; }

        public ICommand ModePull_SetCmd { get; set; }
        public ICommand ModePush_SetCmd { get; set; }
        public ICommand ModeNoUse_SetCmd { get; set; }

        private ParaDieHydrInfoDto m_ParaDieHydrInfo = new ParaDieHydrInfoDto();
        public ParaDieHydrInfoDto ParaDieHydrInfo
        {
            get { return m_ParaDieHydrInfo; }
            set
            {
                if (m_ParaDieHydrInfo != value)
                {
                    m_ParaDieHydrInfo = value;
                    RaisePropertyChanged(() => ParaDieHydrInfo);
                }
            }
        }

        public ParaSubDieHydrPageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);

            Pressure_SetCmd = new RelayCommand(OnPressure_Set);
            PushPos_SetCmd = new RelayCommand(OnPushPos_Set);
            PushDelayTime_SetCmd = new RelayCommand(OnPushDelayTime_Set);

            ModePull_SetCmd = new RelayCommand(OnModePull_Set);
            ModePush_SetCmd = new RelayCommand(OnModePush_Set);
            ModeNoUse_SetCmd = new RelayCommand(OnModeNoUse_Set);

            Messenger.Default.Register<ParaDieHydrInfo>(this, "ParaDieHydrInfoInfoMsg", msg =>
            {
                ParaDieHydrInfo = _mapper.Map<ParaDieHydrInfo, ParaDieHydrInfoDto>(msg);
            });

        }

        private void OnLoaded()
        {
            _fanuc.ChangePageEvent(paradiehydr: true);
        }

        private void OnUnloaded()
        {

        }

        private void OnPressure_Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DH_Pressure, _fanuc.CurLimitBom.DH_Pressure, "输入压力设定(MPa)");
            dlg.ShowDialog();
        }

        private void OnPushPos_Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DH_PushPos, _fanuc.CurLimitBom.DH_PushPos, "输入顶出位置(mm)");
            dlg.ShowDialog();
        }

        private void OnPushDelayTime_Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DH_PushDelayTime, _fanuc.CurLimitBom.DH_PushDelayTime, "输入顶出延时(ms)");
            dlg.ShowDialog();
        }

        private void OnModePull_Set()
        {

        }

        private void OnModePush_Set()
        {

        }

        private void OnModeNoUse_Set()
        {

        }
    }
}
