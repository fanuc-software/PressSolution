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
    public class ParaSubPressureMaintPageViewModel : MyBaseViewModel
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }

        public ICommand PressureSetCmd { get; set; }
        public ICommand TimeSetCmd { get; set; }
        public ICommand PreDelayTimeSetCmd { get; set; }
        public ICommand ChangeModeSetCmd { get; set; }
        public ICommand ChangePressureSetCmd { get; set; }

        private ParaPressureMaintInfoDto m_ParaPressureMaintInfo = new ParaPressureMaintInfoDto();
        public ParaPressureMaintInfoDto ParaPressureMaintInfo
        {
            get { return m_ParaPressureMaintInfo; }
            set
            {
                if (m_ParaPressureMaintInfo != value)
                {
                    m_ParaPressureMaintInfo = value;
                    RaisePropertyChanged(() => ParaPressureMaintInfo);
                }
            }
        }

        public ParaSubPressureMaintPageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);

            PressureSetCmd = new RelayCommand(OnPressureSet);
            TimeSetCmd = new RelayCommand(OnTimeSet);
            PreDelayTimeSetCmd = new RelayCommand(OnPreDelayTimeSet);
            ChangeModeSetCmd = new RelayCommand(OnChangeModeSet);
            ChangePressureSetCmd = new RelayCommand(OnChangePressureSet);


            Messenger.Default.Register<ParaPressureMaintInfo>(this, "ParaPressureMaintInfoMsg", msg =>
            {
                ParaPressureMaintInfo = _mapper.Map<ParaPressureMaintInfo, ParaPressureMaintInfoDto>(msg);
            });

        }


        private void OnLoaded()
        {
            _fanuc.ChangePageEvent(parapressuremaint: true);
        }

        private void OnUnloaded()
        {

        }


        private void OnPressureSet()
        {
            var dlg = new MacroDataInputDialog(_fanuc, _fanuc.CurMacroBom.SPP_Pressure, _fanuc.CurLimitBom.SPP_Pressure, "输入保压压力(T)");
            dlg.ShowDialog();
        }

        private void OnTimeSet()
        {
            var dlg = new MacroDataInputDialog(_fanuc, _fanuc.CurMacroBom.SPP_Time, _fanuc.CurLimitBom.SPP_Time, "输入保压时间(s)");
            dlg.ShowDialog();

        }
        private void OnPreDelayTimeSet()
        {
            var dlg = new MacroDataInputDialog(_fanuc, _fanuc.CurMacroBom.SPP_PreDelayTime, _fanuc.CurLimitBom.SPP_PreDelayTime, "输入保压前延时(s)");
            dlg.ShowDialog();
        }

        private void OnChangeModeSet()
        {
            var dlg = new MacroDataInputDialog(_fanuc, _fanuc.CurMacroBom.SPP_ChangeMode, _fanuc.CurLimitBom.SPP_ChangeMode, "输入保压切换方式");
            dlg.ShowDialog();
        }

        private void OnChangePressureSet()
        {
            var dlg = new MacroDataInputDialog(_fanuc, _fanuc.CurMacroBom.SPP_ChangePressure, _fanuc.CurLimitBom.SPP_ChangePressure, "输入保压切换压力(T)");
            dlg.ShowDialog();
        }

    }
}
