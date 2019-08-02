using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;
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
    public class ParaSubDieChangePageViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }
        
        public ICommand RapidFeedSetCmd { get; set; }
        public ICommand JogFeedSetCmd { get; set; }
        public ICommand InstallDieHighSetCmd { get; set; }
        public ICommand CylinderpRressureSetCmd { get; set; }
        public ICommand DieWeightSetCmd { get; set; }

        private ParaDieChangeInfoDto m_ParaDieChangeInfo = new ParaDieChangeInfoDto();
        public ParaDieChangeInfoDto ParaDieChangeInfo
        {
            get { return m_ParaDieChangeInfo; }
            set
            {
                if (m_ParaDieChangeInfo != value)
                {
                    m_ParaDieChangeInfo = value;
                    RaisePropertyChanged(() => ParaDieChangeInfo);
                }
            }
        }



        public ParaSubDieChangePageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);

            RapidFeedSetCmd = new RelayCommand(OnRapidFeedSet);
            JogFeedSetCmd = new RelayCommand(OnJogFeedSet);
            InstallDieHighSetCmd = new RelayCommand(OnInstallDieHighSet);
            CylinderpRressureSetCmd = new RelayCommand(OnCylinderpRressureSet);
            DieWeightSetCmd = new RelayCommand(OnDieWeightSet);


            Messenger.Default.Register<ParaDieChangeInfo>(this, "ParaDieChangeInfoMsg", msg =>
            {
                ParaDieChangeInfo = _mapper.Map<ParaDieChangeInfo, ParaDieChangeInfoDto>(msg);
            });

        }


        private void OnLoaded()
        {
            _fanuc.ChangePageEvent(paradiechange: true);
        }

        private void OnUnloaded()
        {

        }

        private void OnRapidFeedSet()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DCP_RapidFeed,_fanuc.CurLimitBom.DCP_RapidFeed,"输入快行速度(%)");
            dlg.ShowDialog();
        }

        private void OnJogFeedSet()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DCP_JogFeed, _fanuc.CurLimitBom.DCP_JogFeed, "输入寸动速度(%)");
            dlg.ShowDialog();
        }

        private void OnInstallDieHighSet()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DCP_InstallDieHighSet, _fanuc.CurLimitBom.DCP_InstallDieHighSet, "输入装模高度设定值(mm)");
            dlg.ShowDialog();
        }

        private void OnCylinderpRressureSet()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DCP_CylinderpRressureSet, _fanuc.CurLimitBom.DCP_CylinderpRressureSet, "输入平衡缸压力设定值(MPa)");
            dlg.ShowDialog();
        }

        private void OnDieWeightSet()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DCP_DieWeight, _fanuc.CurLimitBom.DCP_DieWeight, "输入上模重量(T)");
            dlg.ShowDialog();
        }

    }
}
