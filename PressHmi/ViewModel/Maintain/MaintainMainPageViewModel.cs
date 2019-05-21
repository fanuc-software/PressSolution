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
    public class MaintainMainPageViewModel : ViewModelBase
    {
        private Page m_MaintainPanel;
        public Page _MaintainPanel
        {
            get { return m_MaintainPanel; }
            set
            {
                if (m_MaintainPanel != value)
                {
                    m_MaintainPanel = value;
                    RaisePropertyChanged(() => _MaintainPanel);
                }
            }
        }

        #region Maintain menu
        private MenuButtonDto m_MaintainMenu1;
        public MenuButtonDto MaintainMenu1
        {
            get { return m_MaintainMenu1; }
            set
            {
                if (m_MaintainMenu1 != value)
                {
                    m_MaintainMenu1 = value;
                    RaisePropertyChanged(() => MaintainMenu1);
                }
            }
        }

        private MenuButtonDto m_MaintainMenu2;
        public MenuButtonDto MaintainMenu2
        {
            get { return m_MaintainMenu2; }
            set
            {
                if (m_MaintainMenu2 != value)
                {
                    m_MaintainMenu2 = value;
                    RaisePropertyChanged(() => MaintainMenu2);
                }
            }
        }

        private MenuButtonDto m_MaintainMenu3;
        public MenuButtonDto MaintainMenu3
        {
            get { return m_MaintainMenu3; }
            set
            {
                if (m_MaintainMenu3 != value)
                {
                    m_MaintainMenu3 = value;
                    RaisePropertyChanged(() => MaintainMenu3);
                }
            }
        }

        private MenuButtonDto m_MaintainMenu4;
        public MenuButtonDto MaintainMenu4
        {
            get { return m_MaintainMenu4; }
            set
            {
                if (m_MaintainMenu4 != value)
                {
                    m_MaintainMenu4 = value;
                    RaisePropertyChanged(() => MaintainMenu4);
                }
            }
        }

        private MenuButtonDto m_MaintainMenu5;
        public MenuButtonDto MaintainMenu5
        {
            get { return m_MaintainMenu5; }
            set
            {
                if (m_MaintainMenu5 != value)
                {
                    m_MaintainMenu5 = value;
                    RaisePropertyChanged(() => MaintainMenu5);
                }
            }
        }

        private MenuButtonDto m_MaintainMenu6;
        public MenuButtonDto MaintainMenu6
        {
            get { return m_MaintainMenu6; }
            set
            {
                if (m_MaintainMenu6 != value)
                {
                    m_MaintainMenu6 = value;
                    RaisePropertyChanged(() => MaintainMenu6);
                }
            }
        }

        private MenuButtonDto m_MaintainMenu7;
        public MenuButtonDto MaintainMenu7
        {
            get { return m_MaintainMenu7; }
            set
            {
                if (m_MaintainMenu7 != value)
                {
                    m_MaintainMenu7 = value;
                    RaisePropertyChanged(() => MaintainMenu7);
                }
            }
        }

        private MenuButtonDto m_MaintainMenu8;
        public MenuButtonDto MaintainMenu8
        {
            get { return m_MaintainMenu8; }
            set
            {
                if (m_MaintainMenu8 != value)
                {
                    m_MaintainMenu8 = value;
                    RaisePropertyChanged(() => MaintainMenu8);
                }
            }
        }

        private bool m_MaintainMenu1Cheched;
        public bool MaintainMenu1Cheched
        {
            get { return m_MaintainMenu1Cheched; }
            set
            {
                if (m_MaintainMenu1Cheched != value)
                {
                    m_MaintainMenu1Cheched = value;
                    RaisePropertyChanged(() => MaintainMenu1Cheched);
                }
            }
        }

        private bool m_MaintainMenu2Cheched;
        public bool MaintainMenu2Cheched
        {
            get { return m_MaintainMenu2Cheched; }
            set
            {
                if (m_MaintainMenu2Cheched != value)
                {
                    m_MaintainMenu2Cheched = value;
                    RaisePropertyChanged(() => MaintainMenu2Cheched);
                }
            }
        }

        private bool m_MaintainMenu3Cheched;
        public bool MaintainMenu3Cheched
        {
            get { return m_MaintainMenu3Cheched; }
            set
            {
                if (m_MaintainMenu3Cheched != value)
                {
                    m_MaintainMenu3Cheched = value;
                    RaisePropertyChanged(() => MaintainMenu3Cheched);
                }
            }
        }

        private bool m_MaintainMenu4Cheched;
        public bool MaintainMenu4Cheched
        {
            get { return m_MaintainMenu4Cheched; }
            set
            {
                if (m_MaintainMenu4Cheched != value)
                {
                    m_MaintainMenu4Cheched = value;
                    RaisePropertyChanged(() => MaintainMenu4Cheched);
                }
            }
        }

        private bool m_MaintainMenu5Cheched;
        public bool MaintainMenu5Cheched
        {
            get { return m_MaintainMenu5Cheched; }
            set
            {
                if (m_MaintainMenu5Cheched != value)
                {
                    m_MaintainMenu5Cheched = value;
                    RaisePropertyChanged(() => MaintainMenu5Cheched);
                }
            }
        }

        private bool m_MaintainMenu6Cheched;
        public bool MaintainMenu6Cheched
        {
            get { return m_MaintainMenu6Cheched; }
            set
            {
                if (m_MaintainMenu6Cheched != value)
                {
                    m_MaintainMenu6Cheched = value;
                    RaisePropertyChanged(() => MaintainMenu6Cheched);
                }
            }
        }

        private bool m_MaintainMenu7Cheched;
        public bool MaintainMenu7Cheched
        {
            get { return m_MaintainMenu7Cheched; }
            set
            {
                if (m_MaintainMenu7Cheched != value)
                {
                    m_MaintainMenu7Cheched = value;
                    RaisePropertyChanged(() => MaintainMenu7Cheched);
                }
            }
        }

        private bool m_MaintainMenu8Cheched;
        public bool MaintainMenu8Cheched
        {
            get { return m_MaintainMenu8Cheched; }
            set
            {
                if (m_MaintainMenu8Cheched != value)
                {
                    m_MaintainMenu8Cheched = value;
                    RaisePropertyChanged(() => MaintainMenu8Cheched);
                }
            }
        }

        private void ChangeMaintainMenuEvent(bool m1 = false, bool m2 = false, bool m3 = false, bool m4 = false, 
            bool m5 = false, bool m6 = false, bool m7 = false, bool m8 = false)
        {
            MaintainMenu1Cheched = m1;
            MaintainMenu2Cheched = m2;
            MaintainMenu3Cheched = m3;
            MaintainMenu4Cheched = m4;
            MaintainMenu5Cheched = m5;
            MaintainMenu6Cheched = m6;
            MaintainMenu7Cheched = m7;
            MaintainMenu8Cheched = m8;
        }

        private void InitialMaintainMenu()
        {
            MaintainMenu1 = new MenuButtonDto
            {
                Text = "数据限制",
                Cmd = new RelayCommand(OnMaintainMenu1Click),
                Visibility = "Visible",
            };

            MaintainMenu2 = new MenuButtonDto
            {
                Text = "CNC屏幕",
                Cmd = new RelayCommand(OnMaintainMenu2Click),
                Visibility = "Visible",
            };


            MaintainMenu3 = new MenuButtonDto
            {
                Text = "",
                Cmd = new RelayCommand(OnMaintainMenu3Click),
                Visibility = "Visible",
            };


            MaintainMenu4 = new MenuButtonDto
            {
                Text = "",
                Cmd = new RelayCommand(OnMaintainMenu4Click),
                Visibility = "Visible",
            };

            MaintainMenu5 = new MenuButtonDto
            {
                Text = "",
                Cmd = new RelayCommand(OnMaintainMenu5Click),
                Visibility = "Visible",
            };


            MaintainMenu6 = new MenuButtonDto
            {
                Text = "",
                Cmd = new RelayCommand(OnMaintainMenu6Click),
                Visibility = "Visible",
            };



            MaintainMenu7 = new MenuButtonDto
            {
                Text = "",
                Cmd = new RelayCommand(OnMaintainMenu7Click),
                Visibility = "Visible",
            };



            MaintainMenu8 = new MenuButtonDto
            {
                Text = "",
                Cmd = new RelayCommand(OnMaintainMenu8Click),
                Visibility = "Visible",
            };


        }

        private void OnMaintainMenu1Click()
        {
            ChangeMaintainMenuEvent(m1: true);
            //_MaintainPanel = new MaintainSubDieChangePage();


        }
        private void OnMaintainMenu2Click()
        {
            ChangeMaintainMenuEvent(m2: true);
            _MaintainPanel = new MaintainSubCsdPage();
        }
        private void OnMaintainMenu3Click()
        {
            ChangeMaintainMenuEvent(m3: true);
            //_MaintainPanel = new MaintainSubDiePartingPage();
        }
        private void OnMaintainMenu4Click()
        {
            ChangeMaintainMenuEvent(m4: true);
            //_MaintainPanel = new MaintainSubPressureMaintPage();
        }
        private void OnMaintainMenu5Click()
        {
            ChangeMaintainMenuEvent(m5: true);
            //_MaintainPanel = new MaintainSubAutoAirSourcePage();
        }

        private void OnMaintainMenu6Click()
        {
            ChangeMaintainMenuEvent(m6: true);
            //_MaintainPanel = new MaintainSubDieHydrPage();
        }

        private void OnMaintainMenu7Click()
        {
            ChangeMaintainMenuEvent(m7: true);
            //_MaintainPanel = new MaintainSubWorkCountPage();
        }

        private void OnMaintainMenu8Click()
        {
            ChangeMaintainMenuEvent(m8: true);
            //_MaintainPanel = new MaintainSubProcManagementPage();
        }

        #endregion


        #region ctrl
        public MaintainMainPageViewModel()
        {
            InitialMaintainMenu();
            OnMaintainMenu1Click();

        }

        #endregion

    }
}
