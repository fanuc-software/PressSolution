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
using PressHmi.Model;
using PressHmi.View;

namespace PressHmi.ViewModel
{
    public class SystemMainPageViewModel : ViewModelBase
    {
        private Page m_SystemPanel;
        public Page _SystemPanel
        {
            get { return m_SystemPanel; }
            set
            {
                if (m_SystemPanel != value)
                {
                    m_SystemPanel = value;
                    RaisePropertyChanged(() => _SystemPanel);
                }
            }
        }

        #region System menu
        private MenuButtonDto m_SystemMenu1;
        public MenuButtonDto SystemMenu1
        {
            get { return m_SystemMenu1; }
            set
            {
                if (m_SystemMenu1 != value)
                {
                    m_SystemMenu1 = value;
                    RaisePropertyChanged(() => SystemMenu1);
                }
            }
        }

        private MenuButtonDto m_SystemMenu2;
        public MenuButtonDto SystemMenu2
        {
            get { return m_SystemMenu2; }
            set
            {
                if (m_SystemMenu2 != value)
                {
                    m_SystemMenu2 = value;
                    RaisePropertyChanged(() => SystemMenu2);
                }
            }
        }

        private MenuButtonDto m_SystemMenu3;
        public MenuButtonDto SystemMenu3
        {
            get { return m_SystemMenu3; }
            set
            {
                if (m_SystemMenu3 != value)
                {
                    m_SystemMenu3 = value;
                    RaisePropertyChanged(() => SystemMenu3);
                }
            }
        }

        private MenuButtonDto m_SystemMenu4;
        public MenuButtonDto SystemMenu4
        {
            get { return m_SystemMenu4; }
            set
            {
                if (m_SystemMenu4 != value)
                {
                    m_SystemMenu4 = value;
                    RaisePropertyChanged(() => SystemMenu4);
                }
            }
        }

        private MenuButtonDto m_SystemMenu5;
        public MenuButtonDto SystemMenu5
        {
            get { return m_SystemMenu5; }
            set
            {
                if (m_SystemMenu5 != value)
                {
                    m_SystemMenu5 = value;
                    RaisePropertyChanged(() => SystemMenu5);
                }
            }
        }

        private MenuButtonDto m_SystemMenu6;
        public MenuButtonDto SystemMenu6
        {
            get { return m_SystemMenu6; }
            set
            {
                if (m_SystemMenu6 != value)
                {
                    m_SystemMenu6 = value;
                    RaisePropertyChanged(() => SystemMenu6);
                }
            }
        }

        private MenuButtonDto m_SystemMenu7;
        public MenuButtonDto SystemMenu7
        {
            get { return m_SystemMenu7; }
            set
            {
                if (m_SystemMenu7 != value)
                {
                    m_SystemMenu7 = value;
                    RaisePropertyChanged(() => SystemMenu7);
                }
            }
        }

        private MenuButtonDto m_SystemMenu8;
        public MenuButtonDto SystemMenu8
        {
            get { return m_SystemMenu8; }
            set
            {
                if (m_SystemMenu8 != value)
                {
                    m_SystemMenu8 = value;
                    RaisePropertyChanged(() => SystemMenu8);
                }
            }
        }

        private bool m_SystemMenu1Cheched;
        public bool SystemMenu1Cheched
        {
            get { return m_SystemMenu1Cheched; }
            set
            {
                if (m_SystemMenu1Cheched != value)
                {
                    m_SystemMenu1Cheched = value;
                    RaisePropertyChanged(() => SystemMenu1Cheched);
                }
            }
        }

        private bool m_SystemMenu2Cheched;
        public bool SystemMenu2Cheched
        {
            get { return m_SystemMenu2Cheched; }
            set
            {
                if (m_SystemMenu2Cheched != value)
                {
                    m_SystemMenu2Cheched = value;
                    RaisePropertyChanged(() => SystemMenu2Cheched);
                }
            }
        }

        private bool m_SystemMenu3Cheched;
        public bool SystemMenu3Cheched
        {
            get { return m_SystemMenu3Cheched; }
            set
            {
                if (m_SystemMenu3Cheched != value)
                {
                    m_SystemMenu3Cheched = value;
                    RaisePropertyChanged(() => SystemMenu3Cheched);
                }
            }
        }

        private bool m_SystemMenu4Cheched;
        public bool SystemMenu4Cheched
        {
            get { return m_SystemMenu4Cheched; }
            set
            {
                if (m_SystemMenu4Cheched != value)
                {
                    m_SystemMenu4Cheched = value;
                    RaisePropertyChanged(() => SystemMenu4Cheched);
                }
            }
        }

        private bool m_SystemMenu5Cheched;
        public bool SystemMenu5Cheched
        {
            get { return m_SystemMenu5Cheched; }
            set
            {
                if (m_SystemMenu5Cheched != value)
                {
                    m_SystemMenu5Cheched = value;
                    RaisePropertyChanged(() => SystemMenu5Cheched);
                }
            }
        }

        private bool m_SystemMenu6Cheched;
        public bool SystemMenu6Cheched
        {
            get { return m_SystemMenu6Cheched; }
            set
            {
                if (m_SystemMenu6Cheched != value)
                {
                    m_SystemMenu6Cheched = value;
                    RaisePropertyChanged(() => SystemMenu6Cheched);
                }
            }
        }

        private bool m_SystemMenu7Cheched;
        public bool SystemMenu7Cheched
        {
            get { return m_SystemMenu7Cheched; }
            set
            {
                if (m_SystemMenu7Cheched != value)
                {
                    m_SystemMenu7Cheched = value;
                    RaisePropertyChanged(() => SystemMenu7Cheched);
                }
            }
        }

        private bool m_SystemMenu8Cheched;
        public bool SystemMenu8Cheched
        {
            get { return m_SystemMenu8Cheched; }
            set
            {
                if (m_SystemMenu8Cheched != value)
                {
                    m_SystemMenu8Cheched = value;
                    RaisePropertyChanged(() => SystemMenu8Cheched);
                }
            }
        }

        private void ChangeSystemMenuEvent(bool m1 = false, bool m2 = false, bool m3 = false, bool m4 = false, 
            bool m5 = false, bool m6 = false, bool m7 = false, bool m8 = false)
        {
            SystemMenu1Cheched = m1;
            SystemMenu2Cheched = m2;
            SystemMenu3Cheched = m3;
            SystemMenu4Cheched = m4;
            SystemMenu5Cheched = m5;
            SystemMenu6Cheched = m6;
            SystemMenu7Cheched = m7;
            SystemMenu8Cheched = m8;
        }

        private void InitialSystemMenu()
        {
            SystemMenu1 = new MenuButtonDto
            {
                Text = "基础设定",
                Cmd = new RelayCommand(OnSystemMenu1Click),
                Visibility = "Visible",
            };

            SystemMenu2 = new MenuButtonDto
            {
                Text = "PMC配置",
                Cmd = new RelayCommand(OnSystemMenu2Click),
                Visibility = "Visible",
            };


            SystemMenu3 = new MenuButtonDto
            {
                Text = "变量配置",
                Cmd = new RelayCommand(OnSystemMenu3Click),
                Visibility = "Visible",
            };


            SystemMenu4 = new MenuButtonDto
            {
                Text = "密码设定",
                Cmd = new RelayCommand(OnSystemMenu4Click),
                Visibility = "Visible",
            };

            SystemMenu5 = new MenuButtonDto
            {
                Text = "系统操作",
                Cmd = new RelayCommand(OnSystemMenu5Click),
                Visibility = "Visible",
            };


            SystemMenu6 = new MenuButtonDto
            {
                Text = "",
                Cmd = new RelayCommand(OnSystemMenu6Click),
                Visibility = "Visible",
            };



            SystemMenu7 = new MenuButtonDto
            {
                Text = "",
                Cmd = new RelayCommand(OnSystemMenu7Click),
                Visibility = "Visible",
            };



            SystemMenu8 = new MenuButtonDto
            {
                Text = "",
                Cmd = new RelayCommand(OnSystemMenu8Click),
                Visibility = "Visible",
            };


        }

        private void OnSystemMenu1Click()
        {
            ChangeSystemMenuEvent(m1: true);


        }
        private void OnSystemMenu2Click()
        {
            ChangeSystemMenuEvent(m2: true);
            //_SystemPanel = new SystemSubDieClosingPage();
        }
        private void OnSystemMenu3Click()
        {
            ChangeSystemMenuEvent(m3: true);
            //_SystemPanel = new SystemSubDiePartingPage();
        }
        private void OnSystemMenu4Click()
        {
            ChangeSystemMenuEvent(m4: true);
            //_SystemPanel = new SystemSubPressureMaintPage();
        }
        private void OnSystemMenu5Click()
        {
            ChangeSystemMenuEvent(m5: true);
            //_SystemPanel = new SystemSubAutoAirSourcePage();
        }

        private void OnSystemMenu6Click()
        {
            ChangeSystemMenuEvent(m6: true);
            //_SystemPanel = new SystemSubDieHydrPage();
        }

        private void OnSystemMenu7Click()
        {
            ChangeSystemMenuEvent(m7: true);
            //_SystemPanel = new SystemSubWorkCountPage();
        }

        private void OnSystemMenu8Click()
        {
            ChangeSystemMenuEvent(m8: true);
            //_SystemPanel = new SystemSubProcManagementPage();
        }

        #endregion


        #region ctrl
        public SystemMainPageViewModel()
        {
            InitialSystemMenu();
            OnSystemMenu1Click();

        }

        #endregion

    }
}
