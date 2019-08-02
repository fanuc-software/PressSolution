using System;
using System.Collections.ObjectModel;
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
using Abt.Controls.SciChart.Model.DataSeries;
using Newtonsoft.Json;
using System.IO;

namespace PressHmi.ViewModel
{
    public class ParaSubDieClosingPageViewModel : MyBaseViewModel
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }

        public ICommand SectionNumSetCmd { get; set; }
        

        public ICommand TopDeadCentreCmd { get; set; }
        public ICommand Speed_BottomDeadCentreCmd { get; set; }

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

        public ICommand StartSciChartCmd { get; set; }

        #region scichart 
        private double temp_index = 0;

        private IXyDataSeries<double, double> m_PosSeries;
        public IXyDataSeries<double, double> PosSeries
        {
            get { return m_PosSeries; }
            set
            {
                if (m_PosSeries != value)
                {
                    m_PosSeries = value;
                    RaisePropertyChanged(() => PosSeries);
                }
            }
        }

        private IXyDataSeries<double, double> m_SpeedSeries;
        public IXyDataSeries<double, double> SpeedSeries
        {
            get { return m_SpeedSeries; }
            set
            {
                if (m_SpeedSeries != value)
                {
                    m_SpeedSeries = value;
                    RaisePropertyChanged(() => SpeedSeries);
                }
            }
        }


        private void OnData(StateMonitorLineChartData info)
        {
            if (temp_index <= info.Time)
            {
                PosSeries.Append(info.Time, info.Pos);
                SpeedSeries.Append(info.Time, info.Speed);
                temp_index = info.Time;
            }
            else
            {
                PosSeries.Clear();
                SpeedSeries.Clear();
                temp_index = info.Time;
            }
        }
        #endregion



        public ICommand BottomDeadCentreSetCmd { get; set; }
        public ICommand BottomDeadCentre_StopTimeCmd { get; set; }

        private ParaDieClosingInfoDto m_ParaDieClosingInfo = new ParaDieClosingInfoDto();
        public ParaDieClosingInfoDto ParaDieClosingInfo
        {
            get { return m_ParaDieClosingInfo; }
            set
            {
                if (m_ParaDieClosingInfo != value)
                {
                    m_ParaDieClosingInfo = value;
                    RaisePropertyChanged(() => ParaDieClosingInfo);
                }
            }
        }
        
        private ParaDieClosingProcInfoDto m_ParaDieClosingProcInfo = new ParaDieClosingProcInfoDto();
        public ParaDieClosingProcInfoDto ParaDieClosingProcInfo
        {
            get { return m_ParaDieClosingProcInfo; }
            set
            {
                if (m_ParaDieClosingProcInfo != value)
                {
                    m_ParaDieClosingProcInfo = value;
                    RaisePropertyChanged(() => ParaDieClosingProcInfo);
                }
            }
        }

        private ObservableCollection<bool> m_ParaDieClosingProcInfoEnables = new ObservableCollection<bool> ();
        public ObservableCollection<bool> ParaDieClosingProcInfoEnables
        {
            get { return m_ParaDieClosingProcInfoEnables; }
            set
            {
                if (m_ParaDieClosingProcInfoEnables != value)
                {
                    m_ParaDieClosingProcInfoEnables = value;
                    RaisePropertyChanged(() => ParaDieClosingProcInfoEnables);
                }
            }
        }

        public ParaSubDieClosingPageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);
            StartSciChartCmd = new RelayCommand(OnStartSciChart);

            SectionNumSetCmd = new RelayCommand(OnSectionNumSet);
            TopDeadCentreCmd = new RelayCommand(OnTopDeadCentre);
            Speed_BottomDeadCentreCmd = new RelayCommand(OnSpeed_BottomDeadCentre);

            Pos_1SetCmd = new RelayCommand(OnPos_1Set);
            Pos_2SetCmd = new RelayCommand(OnPos_2Set);
            Pos_3SetCmd = new RelayCommand(OnPos_3Set);
            Pos_4SetCmd = new RelayCommand(OnPos_4Set);
            Pos_5SetCmd = new RelayCommand(OnPos_5Set);
            Pos_6SetCmd = new RelayCommand(OnPos_6Set);
            Pos_7SetCmd = new RelayCommand(OnPos_7Set);
            Pos_8SetCmd = new RelayCommand(OnPos_8Set);

            Speed_1SetCmd = new RelayCommand(OnSpeed_1Set);
            Speed_2SetCmd = new RelayCommand(OnSpeed_2Set);
            Speed_3SetCmd = new RelayCommand(OnSpeed_3Set);
            Speed_4SetCmd = new RelayCommand(OnSpeed_4Set);
            Speed_5SetCmd = new RelayCommand(OnSpeed_5Set);
            Speed_6SetCmd = new RelayCommand(OnSpeed_6Set);
            Speed_7SetCmd = new RelayCommand(OnSpeed_7Set);
            Speed_8SetCmd = new RelayCommand(OnSpeed_8Set);

            BottomDeadCentreSetCmd = new RelayCommand(OnBottomDeadCentreSet);
            BottomDeadCentre_StopTimeCmd = new RelayCommand(OnBottomDeadCentre_StopTime);

            for (int i = 0; i < 8; i++) ParaDieClosingProcInfoEnables.Add(false);

            Messenger.Default.Register<ParaDieClosingInfo>(this, "ParaDieClosingInfoMsg", msg =>
            {
                ParaDieClosingInfo = _mapper.Map<ParaDieClosingInfo, ParaDieClosingInfoDto>(msg);
            });

            Messenger.Default.Register<ParaDieClosingProcInfo>(this, "ParaDieClosingProcInfoMsg", msg =>
            {
                ParaDieClosingProcInfo = _mapper.Map<ParaDieClosingProcInfo, ParaDieClosingProcInfoDto>(msg);

                for(int i =0; i<8;i++)
                {
                    if (i < ParaDieClosingProcInfo.SectionNum) ParaDieClosingProcInfoEnables[i] = true;
                    else ParaDieClosingProcInfoEnables[i] = false;
                }
            });

            string jsonBaseInfo;
            using (StreamReader sr = new StreamReader(@"baseinfo.cfg", true))
            {
                jsonBaseInfo = sr.ReadToEnd();
            }
            var _baseInfo = JsonConvert.DeserializeObject<BaseInfo>(jsonBaseInfo);
            var fifo = _baseInfo.SciChartXTimeMax;
            PosSeries = new XyDataSeries<double, double>();
            PosSeries.FifoCapacity = fifo;
            SpeedSeries = new XyDataSeries<double, double>();
            SpeedSeries.FifoCapacity = fifo;

            Messenger.Default.Register<StateMonitorLineChartData>(this, "SimulateLineChartDataMsg", OnData);
        }


        private void OnLoaded()
        {
            _fanuc.ChangePageEvent(paradieclosing: true);
        }

        private void OnUnloaded()
        {
            _fanuc.SimulateMonitorLine_Cancel();
        }

        private void OnStartSciChart()
        {
            _fanuc.SimulateMonitorLine_Start();
        }

        private void OnSectionNumSet()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_SectionNum, _fanuc.CurLimitBom.DJP_SectionNum, "输入合模曲线段数");
            dlg.ShowDialog();
        }


        private void OnTopDeadCentre()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_TopDeadCentre, _fanuc.CurLimitBom.DJP_TopDeadCentre, "输入上死点位置");
            dlg.ShowDialog();
        }

        private void OnPos_1Set()
        {
            var dlg = new SlidingTableDataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_Pos_1, _fanuc.CurLimitBom.DJP_Pos_1, "输入P1位置(mm)");
            dlg.ShowDialog();
        }

        private void OnPos_2Set()
        {
            var dlg = new SlidingTableDataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_Pos_2, _fanuc.CurLimitBom.DJP_Pos_2, "输入P2位置(mm)");
            dlg.ShowDialog();
        }

        private void OnPos_3Set()
        {
            var dlg = new SlidingTableDataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_Pos_3, _fanuc.CurLimitBom.DJP_Pos_3, "输入P3位置(mm)");
            dlg.ShowDialog();
        }

        private void OnPos_4Set()
        {
            var dlg = new SlidingTableDataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_Pos_4, _fanuc.CurLimitBom.DJP_Pos_4, "输入P4位置(mm)");
            dlg.ShowDialog();
        }

        private void OnPos_5Set()
        {
            var dlg = new SlidingTableDataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_Pos_5, _fanuc.CurLimitBom.DJP_Pos_5, "输入P5位置(mm)");
            dlg.ShowDialog();
        }

        private void OnPos_6Set()
        {
            var dlg = new SlidingTableDataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_Pos_6, _fanuc.CurLimitBom.DJP_Pos_6, "输入P6位置(mm)");
            dlg.ShowDialog();
        }

        private void OnPos_7Set()
        {
            var dlg = new SlidingTableDataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_Pos_7, _fanuc.CurLimitBom.DJP_Pos_7, "输入P7位置(mm)");
            dlg.ShowDialog();
        }

        private void OnPos_8Set()
        {
            var dlg = new SlidingTableDataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_Pos_8, _fanuc.CurLimitBom.DJP_Pos_8, "输入P8位置(mm)");
            dlg.ShowDialog();
        }

        private void OnSpeed_1Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_Speed_1, _fanuc.CurLimitBom.DJP_Speed_1, "输入P1速度(%)");
            dlg.ShowDialog();
        }

        private void OnSpeed_2Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_Speed_2, _fanuc.CurLimitBom.DJP_Speed_2, "输入P2速度(%)");
            dlg.ShowDialog();
        }

        private void OnSpeed_3Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_Speed_3, _fanuc.CurLimitBom.DJP_Speed_3, "输入P3速度(%)");
            dlg.ShowDialog();
        }

        private void OnSpeed_4Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_Speed_4, _fanuc.CurLimitBom.DJP_Speed_4, "输入P4速度(%)");
            dlg.ShowDialog();
        }

        private void OnSpeed_5Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_Speed_5, _fanuc.CurLimitBom.DJP_Speed_5, "输入P5速度(%)");
            dlg.ShowDialog();
        }

        private void OnSpeed_6Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_Speed_6, _fanuc.CurLimitBom.DJP_Speed_6, "输入P6速度(%)");
            dlg.ShowDialog();
        }

        private void OnSpeed_7Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_Speed_7, _fanuc.CurLimitBom.DJP_Speed_7, "输入P7速度(%)");
            dlg.ShowDialog();
        }

        private void OnSpeed_8Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_Speed_8, _fanuc.CurLimitBom.DJP_Speed_8, "输入P8速度(%)");
            dlg.ShowDialog();
        }

        

        private void OnBottomDeadCentreSet()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_BottomDeadCentre, _fanuc.CurLimitBom.DJP_BottomDeadCentre, "输入下死点位置(mm)");
            dlg.ShowDialog();
        }

        private void OnBottomDeadCentre_StopTime()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_BottomDeadCentre_StopTime, _fanuc.CurLimitBom.DJP_BottomDeadCentre_StopTime, "输入合模下死点停止时间");
            dlg.ShowDialog();
        }

        private void OnSpeed_BottomDeadCentre()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.DJP_Speed_BottomDeadCentre, _fanuc.CurLimitBom.DJP_Speed_BottomDeadCentre, "输入下死点速度(%)");
            dlg.ShowDialog();
        }
    }
}
