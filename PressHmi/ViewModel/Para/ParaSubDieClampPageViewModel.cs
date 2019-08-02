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
    public class ParaSubDieClampPageViewModel : MyBaseViewModel
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }

        public ICommand Clamp_Front_1_EbableSetCmd { get; set; }
        public ICommand Clamp_Front_2_EbableSetCmd { get; set; }
        public ICommand Clamp_Front_3_EbableSetCmd { get; set; }
        public ICommand Clamp_Front_4_EbableSetCmd { get; set; }
        public ICommand Clamp_Front_5_EbableSetCmd { get; set; }
        public ICommand Clamp_Front_6_EbableSetCmd { get; set; }
        public ICommand Clamp_Front_7_EbableSetCmd { get; set; }
        public ICommand Clamp_Front_8_EbableSetCmd { get; set; }
        public ICommand Clamp_Front_9_EbableSetCmd { get; set; }
        public ICommand Clamp_Front_10_EbableSetCmd { get; set; }
        public ICommand Clamp_Front_11_EbableSetCmd { get; set; }
        public ICommand Clamp_Front_12_EbableSetCmd { get; set; }
        public ICommand Clamp_Front_13_EbableSetCmd { get; set; }

        public ICommand Clamp_Back_1_EbableSetCmd { get; set; }
        public ICommand Clamp_Back_2_EbableSetCmd { get; set; }
        public ICommand Clamp_Back_3_EbableSetCmd { get; set; }
        public ICommand Clamp_Back_4_EbableSetCmd { get; set; }
        public ICommand Clamp_Back_5_EbableSetCmd { get; set; }
        public ICommand Clamp_Back_6_EbableSetCmd { get; set; }
        public ICommand Clamp_Back_7_EbableSetCmd { get; set; }
        public ICommand Clamp_Back_8_EbableSetCmd { get; set; }
        public ICommand Clamp_Back_9_EbableSetCmd { get; set; }
        public ICommand Clamp_Back_10_EbableSetCmd { get; set; }
        public ICommand Clamp_Back_11_EbableSetCmd { get; set; }
        public ICommand Clamp_Back_12_EbableSetCmd { get; set; }
        public ICommand Clamp_Back_13_EbableSetCmd { get; set; }

        public ICommand ClampRelaxPositionSetCmd { get; set; }

        private ParaDieClampInfoDto m_ParaDieClampInfo = new ParaDieClampInfoDto();
        public ParaDieClampInfoDto ParaDieClampInfo
        {
            get { return m_ParaDieClampInfo; }
            set
            {
                if (m_ParaDieClampInfo != value)
                {
                    m_ParaDieClampInfo = value;
                    RaisePropertyChanged(() => ParaDieClampInfo);
                }
            }
        }

        public ParaSubDieClampPageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);
            Clamp_Front_1_EbableSetCmd = new RelayCommand(OnClamp_Front_1_EbableSet);
            Clamp_Front_2_EbableSetCmd = new RelayCommand(OnClamp_Front_2_EbableSet);
            Clamp_Front_3_EbableSetCmd = new RelayCommand(OnClamp_Front_3_EbableSet);
            Clamp_Front_4_EbableSetCmd = new RelayCommand(OnClamp_Front_4_EbableSet);
            Clamp_Front_5_EbableSetCmd = new RelayCommand(OnClamp_Front_5_EbableSet);
            Clamp_Front_6_EbableSetCmd = new RelayCommand(OnClamp_Front_6_EbableSet);
            Clamp_Front_7_EbableSetCmd = new RelayCommand(OnClamp_Front_7_EbableSet);
            Clamp_Front_8_EbableSetCmd = new RelayCommand(OnClamp_Front_8_EbableSet);
            Clamp_Front_9_EbableSetCmd = new RelayCommand(OnClamp_Front_9_EbableSet);
            Clamp_Front_10_EbableSetCmd = new RelayCommand(OnClamp_Front_10_EbableSet);
            Clamp_Front_11_EbableSetCmd = new RelayCommand(OnClamp_Front_11_EbableSet);
            Clamp_Front_12_EbableSetCmd = new RelayCommand(OnClamp_Front_12_EbableSet);
            Clamp_Front_13_EbableSetCmd = new RelayCommand(OnClamp_Front_13_EbableSet);
            Clamp_Back_1_EbableSetCmd = new RelayCommand(OnClamp_Back_1_EbableSet);
            Clamp_Back_2_EbableSetCmd = new RelayCommand(OnClamp_Back_2_EbableSet);
            Clamp_Back_3_EbableSetCmd = new RelayCommand(OnClamp_Back_3_EbableSet);
            Clamp_Back_4_EbableSetCmd = new RelayCommand(OnClamp_Back_4_EbableSet);
            Clamp_Back_5_EbableSetCmd = new RelayCommand(OnClamp_Back_5_EbableSet);
            Clamp_Back_6_EbableSetCmd = new RelayCommand(OnClamp_Back_6_EbableSet);
            Clamp_Back_7_EbableSetCmd = new RelayCommand(OnClamp_Back_7_EbableSet);
            Clamp_Back_8_EbableSetCmd = new RelayCommand(OnClamp_Back_8_EbableSet);
            Clamp_Back_9_EbableSetCmd = new RelayCommand(OnClamp_Back_9_EbableSet);
            Clamp_Back_10_EbableSetCmd = new RelayCommand(OnClamp_Back_10_EbableSet);
            Clamp_Back_11_EbableSetCmd = new RelayCommand(OnClamp_Back_11_EbableSet);
            Clamp_Back_12_EbableSetCmd = new RelayCommand(OnClamp_Back_12_EbableSet);
            Clamp_Back_13_EbableSetCmd = new RelayCommand(OnClamp_Back_13_EbableSet);

            ClampRelaxPositionSetCmd = new RelayCommand(OnClampRelaxPositionSet);


            Messenger.Default.Register<ParaDieClampInfo>(this, "ParaDieClampInfoMsg", msg =>
            {
                ParaDieClampInfo = _mapper.Map<ParaDieClampInfo, ParaDieClampInfoDto>(msg);
            });

        }

        private void OnLoaded()
        {
            _fanuc.ChangePageEvent(paradieclamp: true);
        }

        private void OnUnloaded()
        {

        }

        private void OnClampRelaxPositionSet()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.CLS_ClampRelaxPosition, _fanuc.CurLimitBom.CLS_ClampRelaxPosition, "输入放松允许位置(mm)");
            dlg.ShowDialog();
        }

        private void OnClamp_Front_1_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Front_1_Ebable);
        }

        private void OnClamp_Front_2_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Front_2_Ebable);
        }
        private void OnClamp_Front_3_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Front_3_Ebable);
        }
        private void OnClamp_Front_4_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Front_4_Ebable);
        }
        private void OnClamp_Front_5_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Front_5_Ebable);
        }
        private void OnClamp_Front_6_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Front_6_Ebable);
        }
        private void OnClamp_Front_7_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Front_7_Ebable);
        }
        private void OnClamp_Front_8_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Front_8_Ebable);
        }
        private void OnClamp_Front_9_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Front_9_Ebable);
        }
        private void OnClamp_Front_10_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Front_10_Ebable);
        }
        private void OnClamp_Front_11_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Front_11_Ebable);
        }

        private void OnClamp_Front_12_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Front_12_Ebable);
        }

        private void OnClamp_Front_13_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Front_13_Ebable);
        }

        private void OnClamp_Back_1_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Back_1_Ebable);
        }

        private void OnClamp_Back_2_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Back_2_Ebable);
        }
        private void OnClamp_Back_3_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Back_3_Ebable);
        }
        private void OnClamp_Back_4_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Back_4_Ebable);
        }
        private void OnClamp_Back_5_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Back_5_Ebable);
        }
        private void OnClamp_Back_6_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Back_6_Ebable);
        }
        private void OnClamp_Back_7_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Back_7_Ebable);
        }
        private void OnClamp_Back_8_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Back_8_Ebable);
        }
        private void OnClamp_Back_9_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Back_9_Ebable);
        }
        private void OnClamp_Back_10_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Back_10_Ebable);
        }
        private void OnClamp_Back_11_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Back_11_Ebable);
        }

        private void OnClamp_Back_12_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Back_12_Ebable);
        }

        private void OnClamp_Back_13_EbableSet()
        {
            var ret = _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CLS_Clamp_Back_13_Ebable);
        }
    }
}
