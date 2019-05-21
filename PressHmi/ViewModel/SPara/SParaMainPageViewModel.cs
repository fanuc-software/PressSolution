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

    public class SParaMainPageViewModel : ViewModelBase
    {
        private Page m_SParaPanel;
        public Page _SParaPanel
        {
            get { return m_SParaPanel; }
            set
            {
                if (m_SParaPanel != value)
                {
                    m_SParaPanel = value;
                    RaisePropertyChanged(() => _SParaPanel);
                }
            }
        }

        #region SPara menu
        private MenuButtonDto m_SParaMenu1;
        public MenuButtonDto SParaMenu1
        {
            get { return m_SParaMenu1; }
            set
            {
                if (m_SParaMenu1 != value)
                {
                    m_SParaMenu1 = value;
                    RaisePropertyChanged(() => SParaMenu1);
                }
            }
        }

        private MenuButtonDto m_SParaMenu2;
        public MenuButtonDto SParaMenu2
        {
            get { return m_SParaMenu2; }
            set
            {
                if (m_SParaMenu2 != value)
                {
                    m_SParaMenu2 = value;
                    RaisePropertyChanged(() => SParaMenu2);
                }
            }
        }

        private MenuButtonDto m_SParaMenu3;
        public MenuButtonDto SParaMenu3
        {
            get { return m_SParaMenu3; }
            set
            {
                if (m_SParaMenu3 != value)
                {
                    m_SParaMenu3 = value;
                    RaisePropertyChanged(() => SParaMenu3);
                }
            }
        }

        private MenuButtonDto m_SParaMenu4;
        public MenuButtonDto SParaMenu4
        {
            get { return m_SParaMenu4; }
            set
            {
                if (m_SParaMenu4 != value)
                {
                    m_SParaMenu4 = value;
                    RaisePropertyChanged(() => SParaMenu4);
                }
            }
        }

        private MenuButtonDto m_SParaMenu5;
        public MenuButtonDto SParaMenu5
        {
            get { return m_SParaMenu5; }
            set
            {
                if (m_SParaMenu5 != value)
                {
                    m_SParaMenu5 = value;
                    RaisePropertyChanged(() => SParaMenu5);
                }
            }
        }

        private MenuButtonDto m_SParaMenu6;
        public MenuButtonDto SParaMenu6
        {
            get { return m_SParaMenu6; }
            set
            {
                if (m_SParaMenu6 != value)
                {
                    m_SParaMenu6 = value;
                    RaisePropertyChanged(() => SParaMenu6);
                }
            }
        }

        private MenuButtonDto m_SParaMenu7;
        public MenuButtonDto SParaMenu7
        {
            get { return m_SParaMenu7; }
            set
            {
                if (m_SParaMenu7 != value)
                {
                    m_SParaMenu7 = value;
                    RaisePropertyChanged(() => SParaMenu7);
                }
            }
        }

        private MenuButtonDto m_SParaMenu8;
        public MenuButtonDto SParaMenu8
        {
            get { return m_SParaMenu8; }
            set
            {
                if (m_SParaMenu8 != value)
                {
                    m_SParaMenu8 = value;
                    RaisePropertyChanged(() => SParaMenu8);
                }
            }
        }

        private bool m_SParaMenu1Cheched;
        public bool SParaMenu1Cheched
        {
            get { return m_SParaMenu1Cheched; }
            set
            {
                if (m_SParaMenu1Cheched != value)
                {
                    m_SParaMenu1Cheched = value;
                    RaisePropertyChanged(() => SParaMenu1Cheched);
                }
            }
        }

        private bool m_SParaMenu2Cheched;
        public bool SParaMenu2Cheched
        {
            get { return m_SParaMenu2Cheched; }
            set
            {
                if (m_SParaMenu2Cheched != value)
                {
                    m_SParaMenu2Cheched = value;
                    RaisePropertyChanged(() => SParaMenu2Cheched);
                }
            }
        }

        private bool m_SParaMenu3Cheched;
        public bool SParaMenu3Cheched
        {
            get { return m_SParaMenu3Cheched; }
            set
            {
                if (m_SParaMenu3Cheched != value)
                {
                    m_SParaMenu3Cheched = value;
                    RaisePropertyChanged(() => SParaMenu3Cheched);
                }
            }
        }

        private bool m_SParaMenu4Cheched;
        public bool SParaMenu4Cheched
        {
            get { return m_SParaMenu4Cheched; }
            set
            {
                if (m_SParaMenu4Cheched != value)
                {
                    m_SParaMenu4Cheched = value;
                    RaisePropertyChanged(() => SParaMenu4Cheched);
                }
            }
        }

        private bool m_SParaMenu5Cheched;
        public bool SParaMenu5Cheched
        {
            get { return m_SParaMenu5Cheched; }
            set
            {
                if (m_SParaMenu5Cheched != value)
                {
                    m_SParaMenu5Cheched = value;
                    RaisePropertyChanged(() => SParaMenu5Cheched);
                }
            }
        }

        private bool m_SParaMenu6Cheched;
        public bool SParaMenu6Cheched
        {
            get { return m_SParaMenu6Cheched; }
            set
            {
                if (m_SParaMenu6Cheched != value)
                {
                    m_SParaMenu6Cheched = value;
                    RaisePropertyChanged(() => SParaMenu6Cheched);
                }
            }
        }

        private bool m_SParaMenu7Cheched;
        public bool SParaMenu7Cheched
        {
            get { return m_SParaMenu7Cheched; }
            set
            {
                if (m_SParaMenu7Cheched != value)
                {
                    m_SParaMenu7Cheched = value;
                    RaisePropertyChanged(() => SParaMenu7Cheched);
                }
            }
        }

        private bool m_SParaMenu8Cheched;
        public bool SParaMenu8Cheched
        {
            get { return m_SParaMenu8Cheched; }
            set
            {
                if (m_SParaMenu8Cheched != value)
                {
                    m_SParaMenu8Cheched = value;
                    RaisePropertyChanged(() => SParaMenu8Cheched);
                }
            }
        }

        private void ChangeSParaMenuEvent(bool m1 = false, bool m2 = false, bool m3 = false, bool m4 = false,
            bool m5 = false, bool m6 = false, bool m7 = false, bool m8 = false)
        {
            SParaMenu1Cheched = m1;
            SParaMenu2Cheched = m2;
            SParaMenu3Cheched = m3;
            SParaMenu4Cheched = m4;
            SParaMenu5Cheched = m5;
            SParaMenu6Cheched = m6;
            SParaMenu7Cheched = m7;
            SParaMenu8Cheched = m8;
        }

        private void InitialSParaMenu()
        {
            SParaMenu1 = new MenuButtonDto
            {
                Text = "压力设定",
                Cmd = new RelayCommand(OnSParaMenu1Click),
                Visibility = "Visible",
            };

            SParaMenu2 = new MenuButtonDto
            {
                Text = "润滑设定",
                Cmd = new RelayCommand(OnSParaMenu2Click),
                Visibility = "Visible",
            };


            SParaMenu3 = new MenuButtonDto
            {
                Text = "模拟量设定",
                Cmd = new RelayCommand(OnSParaMenu3Click),
                Visibility = "Visible",
            };


            SParaMenu4 = new MenuButtonDto
            {
                Text = "编码器设定",
                Cmd = new RelayCommand(OnSParaMenu4Click),
                Visibility = "Visible",
            };

            SParaMenu5 = new MenuButtonDto
            {
                Text = "控制设定",
                Cmd = new RelayCommand(OnSParaMenu5Click),
                Visibility = "Visible",
            };


            SParaMenu6 = new MenuButtonDto
            {
                Text = "",
                Cmd = new RelayCommand(OnSParaMenu6Click),
                Visibility = "Visible",
            };



            SParaMenu7 = new MenuButtonDto
            {
                Text = "",
                Cmd = new RelayCommand(OnSParaMenu7Click),
                Visibility = "Visible",
            };



            SParaMenu8 = new MenuButtonDto
            {
                Text = "",
                Cmd = new RelayCommand(OnSParaMenu8Click),
                Visibility = "Visible",
            };


        }

        private void OnSParaMenu1Click()
        {
            ChangeSParaMenuEvent(m1: true);
            _SParaPanel = new SParaSubMachinePage();

        }
        private void OnSParaMenu2Click()
        {
            ChangeSParaMenuEvent(m2: true);
            _SParaPanel = new SParaSubLubricatePage();
        }
        private void OnSParaMenu3Click()
        {
            ChangeSParaMenuEvent(m3: true);
            _SParaPanel = new SParaSubAnalogPage();
        }
        private void OnSParaMenu4Click()
        {
            ChangeSParaMenuEvent(m4: true);
            _SParaPanel = new SParaSubEncodePage();
        }
        private void OnSParaMenu5Click()
        {
            ChangeSParaMenuEvent(m5: true);
            //_SParaPanel = new SParaSubAutoAirSourcePage();
        }

        private void OnSParaMenu6Click()
        {
            ChangeSParaMenuEvent(m6: true);
            //_SParaPanel = new SParaSubDieHydrPage();
        }

        private void OnSParaMenu7Click()
        {
            ChangeSParaMenuEvent(m7: true);
            //_SParaPanel = new SParaSubWorkCountPage();
        }

        private void OnSParaMenu8Click()
        {
            ChangeSParaMenuEvent(m8: true);
            //_SParaPanel = new SParaSubProcManagementPage();
        }

        #endregion


        #region ctrl
        public SParaMainPageViewModel()
        {
            InitialSParaMenu();
            OnSParaMenu1Click();

        }

        #endregion

    }
}
