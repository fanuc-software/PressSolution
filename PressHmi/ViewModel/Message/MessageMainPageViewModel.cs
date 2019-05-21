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
    public class MessageMainPageViewModel : ViewModelBase
    {
        private Page m_MessagePanel;
        public Page _MessagePanel
        {
            get { return m_MessagePanel; }
            set
            {
                if (m_MessagePanel != value)
                {
                    m_MessagePanel = value;
                    RaisePropertyChanged(() => _MessagePanel);
                }
            }
        }

        #region Message menu
        private MenuButtonDto m_MessageMenu1;
        public MenuButtonDto MessageMenu1
        {
            get { return m_MessageMenu1; }
            set
            {
                if (m_MessageMenu1 != value)
                {
                    m_MessageMenu1 = value;
                    RaisePropertyChanged(() => MessageMenu1);
                }
            }
        }

        private MenuButtonDto m_MessageMenu2;
        public MenuButtonDto MessageMenu2
        {
            get { return m_MessageMenu2; }
            set
            {
                if (m_MessageMenu2 != value)
                {
                    m_MessageMenu2 = value;
                    RaisePropertyChanged(() => MessageMenu2);
                }
            }
        }

        private MenuButtonDto m_MessageMenu3;
        public MenuButtonDto MessageMenu3
        {
            get { return m_MessageMenu3; }
            set
            {
                if (m_MessageMenu3 != value)
                {
                    m_MessageMenu3 = value;
                    RaisePropertyChanged(() => MessageMenu3);
                }
            }
        }

        private MenuButtonDto m_MessageMenu4;
        public MenuButtonDto MessageMenu4
        {
            get { return m_MessageMenu4; }
            set
            {
                if (m_MessageMenu4 != value)
                {
                    m_MessageMenu4 = value;
                    RaisePropertyChanged(() => MessageMenu4);
                }
            }
        }

        private MenuButtonDto m_MessageMenu5;
        public MenuButtonDto MessageMenu5
        {
            get { return m_MessageMenu5; }
            set
            {
                if (m_MessageMenu5 != value)
                {
                    m_MessageMenu5 = value;
                    RaisePropertyChanged(() => MessageMenu5);
                }
            }
        }

        private MenuButtonDto m_MessageMenu6;
        public MenuButtonDto MessageMenu6
        {
            get { return m_MessageMenu6; }
            set
            {
                if (m_MessageMenu6 != value)
                {
                    m_MessageMenu6 = value;
                    RaisePropertyChanged(() => MessageMenu6);
                }
            }
        }

        private MenuButtonDto m_MessageMenu7;
        public MenuButtonDto MessageMenu7
        {
            get { return m_MessageMenu7; }
            set
            {
                if (m_MessageMenu7 != value)
                {
                    m_MessageMenu7 = value;
                    RaisePropertyChanged(() => MessageMenu7);
                }
            }
        }

        private MenuButtonDto m_MessageMenu8;
        public MenuButtonDto MessageMenu8
        {
            get { return m_MessageMenu8; }
            set
            {
                if (m_MessageMenu8 != value)
                {
                    m_MessageMenu8 = value;
                    RaisePropertyChanged(() => MessageMenu8);
                }
            }
        }

        private bool m_MessageMenu1Cheched;
        public bool MessageMenu1Cheched
        {
            get { return m_MessageMenu1Cheched; }
            set
            {
                if (m_MessageMenu1Cheched != value)
                {
                    m_MessageMenu1Cheched = value;
                    RaisePropertyChanged(() => MessageMenu1Cheched);
                }
            }
        }

        private bool m_MessageMenu2Cheched;
        public bool MessageMenu2Cheched
        {
            get { return m_MessageMenu2Cheched; }
            set
            {
                if (m_MessageMenu2Cheched != value)
                {
                    m_MessageMenu2Cheched = value;
                    RaisePropertyChanged(() => MessageMenu2Cheched);
                }
            }
        }

        private bool m_MessageMenu3Cheched;
        public bool MessageMenu3Cheched
        {
            get { return m_MessageMenu3Cheched; }
            set
            {
                if (m_MessageMenu3Cheched != value)
                {
                    m_MessageMenu3Cheched = value;
                    RaisePropertyChanged(() => MessageMenu3Cheched);
                }
            }
        }

        private bool m_MessageMenu4Cheched;
        public bool MessageMenu4Cheched
        {
            get { return m_MessageMenu4Cheched; }
            set
            {
                if (m_MessageMenu4Cheched != value)
                {
                    m_MessageMenu4Cheched = value;
                    RaisePropertyChanged(() => MessageMenu4Cheched);
                }
            }
        }

        private bool m_MessageMenu5Cheched;
        public bool MessageMenu5Cheched
        {
            get { return m_MessageMenu5Cheched; }
            set
            {
                if (m_MessageMenu5Cheched != value)
                {
                    m_MessageMenu5Cheched = value;
                    RaisePropertyChanged(() => MessageMenu5Cheched);
                }
            }
        }

        private bool m_MessageMenu6Cheched;
        public bool MessageMenu6Cheched
        {
            get { return m_MessageMenu6Cheched; }
            set
            {
                if (m_MessageMenu6Cheched != value)
                {
                    m_MessageMenu6Cheched = value;
                    RaisePropertyChanged(() => MessageMenu6Cheched);
                }
            }
        }

        private bool m_MessageMenu7Cheched;
        public bool MessageMenu7Cheched
        {
            get { return m_MessageMenu7Cheched; }
            set
            {
                if (m_MessageMenu7Cheched != value)
                {
                    m_MessageMenu7Cheched = value;
                    RaisePropertyChanged(() => MessageMenu7Cheched);
                }
            }
        }

        private bool m_MessageMenu8Cheched;
        public bool MessageMenu8Cheched
        {
            get { return m_MessageMenu8Cheched; }
            set
            {
                if (m_MessageMenu8Cheched != value)
                {
                    m_MessageMenu8Cheched = value;
                    RaisePropertyChanged(() => MessageMenu8Cheched);
                }
            }
        }

        private void ChangeMessageMenuEvent(bool m1 = false, bool m2 = false, bool m3 = false, bool m4 = false, 
            bool m5 = false, bool m6 = false, bool m7 = false, bool m8 = false)
        {
            MessageMenu1Cheched = m1;
            MessageMenu2Cheched = m2;
            MessageMenu3Cheched = m3;
            MessageMenu4Cheched = m4;
            MessageMenu5Cheched = m5;
            MessageMenu6Cheched = m6;
            MessageMenu7Cheched = m7;
            MessageMenu8Cheched = m8;
        }

        private void InitialMessageMenu()
        {
            MessageMenu1 = new MenuButtonDto
            {
                Text = "当前报警",
                Cmd = new RelayCommand(OnMessageMenu1Click),
                Visibility = "Visible",
            };

            MessageMenu2 = new MenuButtonDto
            {
                Text = "操作信息",
                Cmd = new RelayCommand(OnMessageMenu2Click),
                Visibility = "Visible",
            };


            MessageMenu3 = new MenuButtonDto
            {
                Text = "报警履历",
                Cmd = new RelayCommand(OnMessageMenu3Click),
                Visibility = "Visible",
            };


            MessageMenu4 = new MenuButtonDto
            {
                Text = "",
                Cmd = new RelayCommand(OnMessageMenu4Click),
                Visibility = "Visible",
            };

            MessageMenu5 = new MenuButtonDto
            {
                Text = "",
                Cmd = new RelayCommand(OnMessageMenu5Click),
                Visibility = "Visible",
            };


            MessageMenu6 = new MenuButtonDto
            {
                Text = "",
                Cmd = new RelayCommand(OnMessageMenu6Click),
                Visibility = "Visible",
            };



            MessageMenu7 = new MenuButtonDto
            {
                Text = "",
                Cmd = new RelayCommand(OnMessageMenu7Click),
                Visibility = "Visible",
            };



            MessageMenu8 = new MenuButtonDto
            {
                Text = "",
                Cmd = new RelayCommand(OnMessageMenu8Click),
                Visibility = "Visible",
            };


        }

        private void OnMessageMenu1Click()
        {
            ChangeMessageMenuEvent(m1: true);
            _MessagePanel = new MessageSubAlarmPage();


        }
        private void OnMessageMenu2Click()
        {
            ChangeMessageMenuEvent(m2: true);
            //_MessagePanel = new MessageSubDieClosingPage();
        }
        private void OnMessageMenu3Click()
        {
            ChangeMessageMenuEvent(m3: true);
            //_MessagePanel = new MessageSubDiePartingPage();
        }
        private void OnMessageMenu4Click()
        {
            ChangeMessageMenuEvent(m4: true);
            //_MessagePanel = new MessageSubPressureMaintPage();
        }
        private void OnMessageMenu5Click()
        {
            ChangeMessageMenuEvent(m5: true);
            //_MessagePanel = new MessageSubAutoAirSourcePage();
        }

        private void OnMessageMenu6Click()
        {
            ChangeMessageMenuEvent(m6: true);
            //_MessagePanel = new MessageSubDieHydrPage();
        }

        private void OnMessageMenu7Click()
        {
            ChangeMessageMenuEvent(m7: true);
            //_MessagePanel = new MessageSubWorkCountPage();
        }

        private void OnMessageMenu8Click()
        {
            ChangeMessageMenuEvent(m8: true);
            //_MessagePanel = new MessageSubProcManagementPage();
        }

        #endregion


        #region ctrl
        public MessageMainPageViewModel()
        {
            InitialMessageMenu();
            OnMessageMenu1Click();

        }

        #endregion

    }
}
