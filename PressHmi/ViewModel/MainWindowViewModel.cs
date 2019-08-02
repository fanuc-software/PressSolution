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
using PressHmi.Roles;
using PressHmi.View.Dialogs;

namespace PressHmi.ViewModel
{
    public class MainWindowViewModel: MyBaseViewModel
    {
        private System.Timers.Timer timerL = new System.Timers.Timer();

        private short _curAlarmIndex;
        private DateTime _lastAlarmUpdataTime;

        private Fanuc _fanuc;
        private IMapper _mapper;
        private Role _role;

        private Page m_MainPanel;
        public Page _MainPanel
        {
            get { return m_MainPanel; }
            set
            {
                if (m_MainPanel != value)
                {
                    m_MainPanel = value;
                    RaisePropertyChanged(() => _MainPanel);
                }
            }
        }

        private string m_time;
        public string _Time
        {
            get { return m_time; }
            set
            {
                if (m_time != value)
                {
                    m_time = value;
                    RaisePropertyChanged(() => _Time);
                }
            }
        }

        private string m_Date;
        public string _Date
        {
            get { return m_Date; }
            set
            {
                if (m_Date != value)
                {
                    m_Date = value;
                    RaisePropertyChanged(() => _Date);
                }
            }
        }

        private string m_disAlarm;
        public string _DisAlarm
        {
            get { return m_disAlarm; }
            set
            {
                if (m_disAlarm != value)
                {
                    m_disAlarm = value;
                    RaisePropertyChanged(() => _DisAlarm);
                }
            }
        }

        private CncStaticInfoDto m_CncStaticInfo=new CncStaticInfoDto();
        public CncStaticInfoDto CncStaticInfo
        {
            get { return m_CncStaticInfo; }
            set
            {
                if (m_CncStaticInfo != value)
                {
                    m_CncStaticInfo = value;
                    RaisePropertyChanged(() => CncStaticInfo);
                }
            }
        }
        
        #region main menu
        private MenuButtonDto m_MainMenu1;
        public MenuButtonDto MainMenu1
        {
            get { return m_MainMenu1; }
            set
            {
                if (m_MainMenu1 != value)
                {
                    m_MainMenu1 = value;
                    RaisePropertyChanged(() => MainMenu1);
                }
            }
        }

        private MenuButtonDto m_MainMenu2;
        public MenuButtonDto MainMenu2
        {
            get { return m_MainMenu2; }
            set
            {
                if (m_MainMenu2 != value)
                {
                    m_MainMenu2 = value;
                    RaisePropertyChanged(() => MainMenu2);
                }
            }
        }

        private MenuButtonDto m_MainMenu3;
        public MenuButtonDto MainMenu3
        {
            get { return m_MainMenu3; }
            set
            {
                if (m_MainMenu3 != value)
                {
                    m_MainMenu3 = value;
                    RaisePropertyChanged(() => MainMenu3);
                }
            }
        }

        private MenuButtonDto m_MainMenu4;
        public MenuButtonDto MainMenu4
        {
            get { return m_MainMenu4; }
            set
            {
                if (m_MainMenu4 != value)
                {
                    m_MainMenu4 = value;
                    RaisePropertyChanged(() => MainMenu4);
                }
            }
        }

        private MenuButtonDto m_MainMenu5;
        public MenuButtonDto MainMenu5
        {
            get { return m_MainMenu5; }
            set
            {
                if (m_MainMenu5 != value)
                {
                    m_MainMenu5 = value;
                    RaisePropertyChanged(() => MainMenu5);
                }
            }
        }

        private MenuButtonDto m_MainMenu6;
        public MenuButtonDto MainMenu6
        {
            get { return m_MainMenu6; }
            set
            {
                if (m_MainMenu6 != value)
                {
                    m_MainMenu6 = value;
                    RaisePropertyChanged(() => MainMenu6);
                }
            }
        }

        private MenuButtonDto m_MainMenu7;
        public MenuButtonDto MainMenu7
        {
            get { return m_MainMenu7; }
            set
            {
                if (m_MainMenu7 != value)
                {
                    m_MainMenu7 = value;
                    RaisePropertyChanged(() => MainMenu7);
                }
            }
        }

        private MenuButtonDto m_MainMenu8;
        public MenuButtonDto MainMenu8
        {
            get { return m_MainMenu8; }
            set
            {
                if (m_MainMenu8 != value)
                {
                    m_MainMenu8 = value;
                    RaisePropertyChanged(() => MainMenu8);
                }
            }
        }

        private bool m_MainMenu1Cheched;
        public bool MainMenu1Cheched
        {
            get { return m_MainMenu1Cheched; }
            set
            {
                if (m_MainMenu1Cheched != value)
                {
                    m_MainMenu1Cheched = value;
                    RaisePropertyChanged(() => MainMenu1Cheched);
                }
            }
        }

        private bool m_MainMenu2Cheched;
        public bool MainMenu2Cheched
        {
            get { return m_MainMenu2Cheched; }
            set
            {
                if (m_MainMenu2Cheched != value)
                {
                    m_MainMenu2Cheched = value;
                    RaisePropertyChanged(() => MainMenu2Cheched);
                }
            }
        }

        private bool m_MainMenu3Cheched;
        public bool MainMenu3Cheched
        {
            get { return m_MainMenu3Cheched; }
            set
            {
                if (m_MainMenu3Cheched != value)
                {
                    m_MainMenu3Cheched = value;
                    RaisePropertyChanged(() => MainMenu3Cheched);
                }
            }
        }

        private bool m_MainMenu4Cheched;
        public bool MainMenu4Cheched
        {
            get { return m_MainMenu4Cheched; }
            set
            {
                if (m_MainMenu4Cheched != value)
                {
                    m_MainMenu4Cheched = value;
                    RaisePropertyChanged(() => MainMenu4Cheched);
                }
            }
        }

        private bool m_MainMenu5Cheched;
        public bool MainMenu5Cheched
        {
            get { return m_MainMenu5Cheched; }
            set
            {
                if (m_MainMenu5Cheched != value)
                {
                    m_MainMenu5Cheched = value;
                    RaisePropertyChanged(() => MainMenu5Cheched);
                }
            }
        }

        private bool m_MainMenu6Cheched;
        public bool MainMenu6Cheched
        {
            get { return m_MainMenu6Cheched; }
            set
            {
                if (m_MainMenu6Cheched != value)
                {
                    m_MainMenu6Cheched = value;
                    RaisePropertyChanged(() => MainMenu6Cheched);
                }
            }
        }

        private bool m_MainMenu7Cheched;
        public bool MainMenu7Cheched
        {
            get { return m_MainMenu7Cheched; }
            set
            {
                if (m_MainMenu7Cheched != value)
                {
                    m_MainMenu7Cheched = value;
                    RaisePropertyChanged(() => MainMenu7Cheched);
                }
            }
        }

        private void ChangeMainMenuEvent(bool m1 = false, bool m2 = false, bool m3 = false, bool m4 = false, bool m5 = false, bool m6 = false, bool m7 = false)
        {
            MainMenu1Cheched = m1;
            MainMenu2Cheched = m2;
            MainMenu3Cheched = m3;
            MainMenu4Cheched = m4;
            MainMenu5Cheched = m5;
            MainMenu6Cheched = m6;
            MainMenu7Cheched = m7;
        }

        private void InitialMainMenu()
        {
            MainMenu7 = new MenuButtonDto
            {
                Text = "屏幕",
                Text2 = "截屏",
                Cmd = new RelayCommand(OnMainMenu7Click),
                Visibility = "Visible",
            };

            MainMenu8 = new MenuButtonDto
            {
                Text = "用户",
                Text2 = "权限",
                Cmd = new RelayCommand(OnMainMenu8Click),
                Visibility = "Visible",
            };

            MainMenu1 = new MenuButtonDto
            {
                Text = "状态",
                Text2 = "监控",
                Cmd = new RelayCommand(OnMainMenu1Click),
                Visibility = "Visible",
            };

            MainMenu2 = new MenuButtonDto
            {
                Text = "参数",
                Text2 = "设置",
                Cmd = new RelayCommand(OnMainMenu2Click),
                Visibility = "Visible",
            };

            MainMenu3 = new MenuButtonDto
            {
                Text = "报警",
                Text2 = "信息",
                Cmd = new RelayCommand(OnMainMenu3Click),
                Visibility = "Visible",
            };

            MainMenu4 = new MenuButtonDto
            {
                Text = "系统",
                Text2 = "维护",
                Cmd = new RelayCommand(OnMainMenu4Click),
                Visibility = "Visible",
            };

            MainMenu5 = new MenuButtonDto
            {
                Text = "系统",
                Text2 = "参数",
                Cmd = new RelayCommand(OnMainMenu5Click),
                Visibility = "Visible",
            };

            MainMenu6 = new MenuButtonDto
            {
                Text = "系统",
                Text2 = "配置",
                Cmd = new RelayCommand(OnMainMenu6Click),
                Visibility = "Visible",
            };

        }

        private void OnMainMenu1Click()
        {
            ChangeMainMenuEvent(m1: true);
            _MainPanel = new StateMonitorPage();
        }
        private void OnMainMenu2Click()
        {
            ChangeMainMenuEvent(m2: true);
            _MainPanel = new ParaMainPage();
        }
        private void OnMainMenu3Click()
        {
            ChangeMainMenuEvent(m3: true);
            _MainPanel = new MessageMainPage();
        }
        private void OnMainMenu4Click()
        {
            ChangeMainMenuEvent(m4: true);
            _MainPanel = new MaintainMainPage();
        }
        private void OnMainMenu5Click()
        {
            ChangeMainMenuEvent(m5: true);
            _MainPanel = new SParaMainPage();

        }
        private void OnMainMenu6Click()
        {
            ChangeMainMenuEvent(m6: true);
            _MainPanel = new SystemMainPage();
        }

        private void OnMainMenu7Click()
        {

        }

        private void OnMainMenu8Click()
        {
            var auth = new OperatorAuthDialog();
            auth.ShowDialog();
        }


        #endregion

        #region ctrl
        public MainWindowViewModel(IMapper mapper, Fanuc fanuc, Role role)
        {
            _fanuc = fanuc;
            _mapper = mapper;
            _role = role;

            InitialMainMenu();
            OnMainMenu1Click();

            System.Timers.Timer timerB = new System.Timers.Timer();//刷新时间
            timerB.Interval = System.Convert.ToDouble(500);
            timerB.Elapsed += new System.Timers.ElapsedEventHandler(RefreshTime);
            timerB.Enabled = true;

            Messenger.Default.Register<CncStaticInfo>(this, "CncStaticInfoMsg", msg =>
            {
                CncStaticInfo = _mapper.Map<CncStaticInfo, CncStaticInfoDto>(msg);

                //报警信息转换
                var al_timespan = (DateTime.Now - _lastAlarmUpdataTime).TotalSeconds;
                if (al_timespan > 3)
                {
                    if (CncStaticInfo.CncAlarmList.Count == 0)
                    {
                        _DisAlarm = "";
                    }
                    else
                    {
                        try
                        {
                            string[] alm_type = { "SW", "PW", "IO", "PS", "OT", "OH", "SV", "SR", "MC", "SP", "DS", "IE", "BG", "SN", "", "EX", "", "", "", "PC" };
                            string[] alm_axis = { "", "(X)", "(Y)", "(Z)" };
                            if (_curAlarmIndex >= CncStaticInfo.CncAlarmList.Count) _curAlarmIndex = 0;
                            _DisAlarm = alm_type[CncStaticInfo.CncAlarmList[_curAlarmIndex].Type] +
                                    CncStaticInfo.CncAlarmList[_curAlarmIndex].Alm_No.ToString("0000") +
                                    @" " + CncStaticInfo.CncAlarmList[_curAlarmIndex].Alm_Msg;


                            _curAlarmIndex++;
                        }
                        catch { }
                    }
                    _lastAlarmUpdataTime = DateTime.Now;
                }
            });

        }

        #endregion

        private void RefreshTime(object sender, System.Timers.ElapsedEventArgs e)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                _Date = DateTime.Now.ToString("yy/MM/dd");
                _Time = DateTime.Now.ToString("HH:mm:ss");
            });
        }

    }
}
