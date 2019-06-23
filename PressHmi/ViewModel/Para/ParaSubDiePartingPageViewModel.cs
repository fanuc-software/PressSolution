using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Collections.ObjectModel;
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
    public class ParaSubDiePartingPageViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }

        public ICommand SectionNumSetCmd { get; set; }
        public ICommand PreDelayTimeSetCmd { get; set; }
        public ICommand SafeTimeSetCmd { get; set; }
        public ICommand BottomDeadCentreSetCmd { get; set; }
        public ICommand Speed_BottomDeadCentreSetCmd { get; set; }

        public ICommand Pos_1SetCmd { get; set; }
        public ICommand Pos_2SetCmd { get; set; }
        public ICommand Pos_3SetCmd { get; set; }
        public ICommand Pos_4SetCmd { get; set; }
        public ICommand Pos_5SetCmd { get; set; }
        public ICommand Pos_6SetCmd { get; set; }
        public ICommand Pos_7SetCmd { get; set; }
        public ICommand Pos_8SetCmd { get; set; }

        public ICommand Speed_1SetCmd { get; set; }
        public ICommand Speed_2SetCmd { get; set; }
        public ICommand Speed_3SetCmd { get; set; }
        public ICommand Speed_4SetCmd { get; set; }
        public ICommand Speed_5SetCmd { get; set; }
        public ICommand Speed_6SetCmd { get; set; }
        public ICommand Speed_7SetCmd { get; set; }
        public ICommand Speed_8SetCmd { get; set; }

        public ICommand StopTime_1SetCmd { get; set; }
        public ICommand StopTime_2SetCmd { get; set; }
        public ICommand StopTime_3SetCmd { get; set; }
        public ICommand StopTime_4SetCmd { get; set; }
        public ICommand StopTime_5SetCmd { get; set; }
        public ICommand StopTime_6SetCmd { get; set; }
        public ICommand StopTime_7SetCmd { get; set; }
        public ICommand StopTime_8SetCmd { get; set; }

        public ICommand TopDeadCentreSetCmd { get; set; }

        private ParaDiePartingInfoDto m_ParaDiePartingInfo = new ParaDiePartingInfoDto();
        public ParaDiePartingInfoDto ParaDiePartingInfo
        {
            get { return m_ParaDiePartingInfo; }
            set
            {
                if (m_ParaDiePartingInfo != value)
                {
                    m_ParaDiePartingInfo = value;
                    RaisePropertyChanged(() => ParaDiePartingInfo);
                }
            }
        }

        private ParaDiePartingProcInfoDto m_ParaDiePartingProcInfo = new ParaDiePartingProcInfoDto();
        public ParaDiePartingProcInfoDto ParaDiePartingProcInfo
        {
            get { return m_ParaDiePartingProcInfo; }
            set
            {
                if (m_ParaDiePartingProcInfo != value)
                {
                    m_ParaDiePartingProcInfo = value;
                    RaisePropertyChanged(() => ParaDiePartingProcInfo);
                }
            }

        }

        private ObservableCollection<bool> m_ParaDiePartingProcInfoEnables = new ObservableCollection<bool>();
        public ObservableCollection<bool> ParaDiePartingProcInfoEnables
        {
            get { return m_ParaDiePartingProcInfoEnables; }
            set
            {
                if (m_ParaDiePartingProcInfoEnables != value)
                {
                    m_ParaDiePartingProcInfoEnables = value;
                    RaisePropertyChanged(() => ParaDiePartingProcInfoEnables);
                }
            }
        }

        public ParaSubDiePartingPageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);

            SectionNumSetCmd = new RelayCommand(OnSectionNumSet);
            //PreDelayTimeSetCmd = new RelayCommand(OnPreDelayTimeSet);
            //SafeTimeSetCmd = new RelayCommand(OnSafeTimeSet);
            BottomDeadCentreSetCmd = new RelayCommand(OnBottomDeadCentreSet);
            Speed_BottomDeadCentreSetCmd = new RelayCommand(OnSpeed_BottomDeadCentreSet);
            TopDeadCentreSetCmd = new RelayCommand(OnTopDeadCentreSet);

            Pos_1SetCmd = new RelayCommand(OnPos_1Set);
            //Pos_2SetCmd = new RelayCommand(OnPos_2Set);
            //Pos_3SetCmd = new RelayCommand(OnPos_3Set);
            //Pos_4SetCmd = new RelayCommand(OnPos_4Set);
            //Pos_5SetCmd = new RelayCommand(OnPos_5Set);
            //Pos_6SetCmd = new RelayCommand(OnPos_6Set);
            //Pos_7SetCmd = new RelayCommand(OnPos_7Set);
            //Pos_8SetCmd = new RelayCommand(OnPos_8Set);

            Speed_1SetCmd = new RelayCommand(OnSpeed_1Set);
            //Speed_2SetCmd = new RelayCommand(OnSpeed_2Set);
            //Speed_3SetCmd = new RelayCommand(OnSpeed_3Set);
            //Speed_4SetCmd = new RelayCommand(OnSpeed_4Set);
            //Speed_5SetCmd = new RelayCommand(OnSpeed_5Set);
            //Speed_6SetCmd = new RelayCommand(OnSpeed_6Set);
            //Speed_7SetCmd = new RelayCommand(OnSpeed_7Set);
            //Speed_8SetCmd = new RelayCommand(OnSpeed_8Set);

            //StopTime_1SetCmd = new RelayCommand(OnStopTime_1Set);
            //StopTime_2SetCmd = new RelayCommand(OnStopTime_2Set);
            //StopTime_3SetCmd = new RelayCommand(OnStopTime_3Set);
            //StopTime_4SetCmd = new RelayCommand(OnStopTime_4Set);
            //StopTime_5SetCmd = new RelayCommand(OnStopTime_5Set);
            //StopTime_6SetCmd = new RelayCommand(OnStopTime_6Set);
            //StopTime_7SetCmd = new RelayCommand(OnStopTime_7Set);
            //StopTime_8SetCmd = new RelayCommand(OnStopTime_8Set);

            BottomDeadCentreSetCmd = new RelayCommand(OnBottomDeadCentreSet);

            for (int i = 0; i < 8; i++) ParaDiePartingProcInfoEnables.Add(false);


            Messenger.Default.Register<ParaDiePartingInfo>(this, "ParaDiePartingInfoMsg", msg =>
            {
                ParaDiePartingInfo = _mapper.Map<ParaDiePartingInfo, ParaDiePartingInfoDto>(msg);
            });

            Messenger.Default.Register<ParaDiePartingProcInfo>(this, "ParaDiePartingProcInfoMsg", msg =>
            {
                ParaDiePartingProcInfo = _mapper.Map<ParaDiePartingProcInfo, ParaDiePartingProcInfoDto>(msg);

                for (int i = 0; i < 8; i++)
                {
                    if (i < ParaDiePartingProcInfo.SectionNum) ParaDiePartingProcInfoEnables[i] = true;
                    else ParaDiePartingProcInfoEnables[i] = false;
                }
            });

        }


        private void OnLoaded()
        {
            _fanuc.ChangePageEvent(paradieparting: true);
        }

        private void OnUnloaded()
        {

        }


        private void OnSectionNumSet()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_SectionNum, _fanuc.CurLimitBom.DPP_SectionNum, "输入开模曲线段数");
            dlg.ShowDialog();
        }

        private void OnSpeed_BottomDeadCentreSet()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_BottomDeadCentre, _fanuc.CurLimitBom.DPP_BottomDeadCentre, "输入开模下死点位置");
            dlg.ShowDialog();
        }

        private void OnTopDeadCentreSet()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_Speed_BottomDeadCentre, _fanuc.CurLimitBom.DPP_Speed_BottomDeadCentre, "输入开模下死点速度");
            dlg.ShowDialog();
        }


        //private void OnPreDelayTimeSet()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom., _fanuc.CurLimitBom.DPP_PreDelayTime, "输入开模前延时(s)");
        //    dlg.ShowDialog();

        //}
        //private void OnSafeTimeSet()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_SafeTime, _fanuc.CurLimitBom.DPP_SafeTime, "输入开模安全时间(s)");
        //    dlg.ShowDialog();
        //}


        private void OnPos_1Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_Pos_1, _fanuc.CurLimitBom.DPP_Pos_1, "输入P1位置(mm)");
            dlg.ShowDialog();
        }

        //private void OnPos_2Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_Pos_2, _fanuc.CurLimitBom.DPP_Pos_2, "输入P2位置(mm)");
        //    dlg.ShowDialog();
        //}

        //private void OnPos_3Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_Pos_3, _fanuc.CurLimitBom.DPP_Pos_3, "输入P3位置(mm)");
        //    dlg.ShowDialog();
        //}

        //private void OnPos_4Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_Pos_4, _fanuc.CurLimitBom.DPP_Pos_4, "输入P4位置(mm)");
        //    dlg.ShowDialog();
        //}

        //private void OnPos_5Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_Pos_5, _fanuc.CurLimitBom.DPP_Pos_5, "输入P5位置(mm)");
        //    dlg.ShowDialog();
        //}

        //private void OnPos_6Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_Pos_6, _fanuc.CurLimitBom.DPP_Pos_6, "输入P6位置(mm)");
        //    dlg.ShowDialog();
        //}

        //private void OnPos_7Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_Pos_7, _fanuc.CurLimitBom.DPP_Pos_7, "输入P7位置(mm)");
        //    dlg.ShowDialog();
        //}

        //private void OnPos_8Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_Pos_8, _fanuc.CurLimitBom.DPP_Pos_8, "输入P8位置(mm)");
        //    dlg.ShowDialog();
        //}

        private void OnSpeed_1Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_Speed_1, _fanuc.CurLimitBom.DPP_Speed_1, "输入P1速度(%)");
            dlg.ShowDialog();
        }

        //private void OnSpeed_2Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_Speed_2, _fanuc.CurLimitBom.DPP_Speed_2, "输入P2速度(%)");
        //    dlg.ShowDialog();
        //}

        //private void OnSpeed_3Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_Speed_3, _fanuc.CurLimitBom.DPP_Speed_3, "输入P3速度(%)");
        //    dlg.ShowDialog();
        //}

        //private void OnSpeed_4Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_Speed_4, _fanuc.CurLimitBom.DPP_Speed_4, "输入P4速度(%)");
        //    dlg.ShowDialog();
        //}

        //private void OnSpeed_5Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_Speed_5, _fanuc.CurLimitBom.DPP_Speed_5, "输入P5速度(%)");
        //    dlg.ShowDialog();
        //}

        //private void OnSpeed_6Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_Speed_6, _fanuc.CurLimitBom.DPP_Speed_6, "输入P6速度(%)");
        //    dlg.ShowDialog();
        //}

        //private void OnSpeed_7Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_Speed_7, _fanuc.CurLimitBom.DPP_Speed_7, "输入P7速度(%)");
        //    dlg.ShowDialog();
        //}

        //private void OnSpeed_8Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_Speed_8, _fanuc.CurLimitBom.DPP_Speed_8, "输入P8速度(%)");
        //    dlg.ShowDialog();
        //}

        //private void OnStopTime_1Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_StopTime_1, _fanuc.CurLimitBom.DPP_StopTime_1, "输入P1停止时间(s)");
        //    dlg.ShowDialog();
        //}

        //private void OnStopTime_2Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_StopTime_2, _fanuc.CurLimitBom.DPP_StopTime_2, "输入P2停止时间(s)");
        //    dlg.ShowDialog();
        //}

        //private void OnStopTime_3Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_StopTime_3, _fanuc.CurLimitBom.DPP_StopTime_3, "输入P3停止时间(s)");
        //    dlg.ShowDialog();
        //}

        //private void OnStopTime_4Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_StopTime_4, _fanuc.CurLimitBom.DPP_StopTime_4, "输入P4停止时间(s)");
        //    dlg.ShowDialog();
        //}

        //private void OnStopTime_5Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_StopTime_5, _fanuc.CurLimitBom.DPP_StopTime_5, "输入P5停止时间(s)");
        //    dlg.ShowDialog();
        //}

        //private void OnStopTime_6Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_StopTime_6, _fanuc.CurLimitBom.DPP_StopTime_6, "输入P6停止时间(s)");
        //    dlg.ShowDialog();
        //}

        //private void OnStopTime_7Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_StopTime_7, _fanuc.CurLimitBom.DPP_StopTime_7, "输入P7停止时间(s)");
        //    dlg.ShowDialog();
        //}

        //private void OnStopTime_8Set()
        //{
        //    var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_StopTime_8, _fanuc.CurLimitBom.DPP_StopTime_8, "输入P8停止时间(s)");
        //    dlg.ShowDialog();
        //}

        private void OnBottomDeadCentreSet()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DPP_BottomDeadCentre, _fanuc.CurLimitBom.DPP_BottomDeadCentre, "输入下死点位置(mm)");
            dlg.ShowDialog();
        }


    }
}
