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
    public class ParaMainPageViewModel : ViewModelBase
    {
        private Page m_ParaPanel;
        public Page _ParaPanel
        {
            get { return m_ParaPanel; }
            set
            {
                if (m_ParaPanel != value)
                {
                    m_ParaPanel = value;
                    RaisePropertyChanged(() => _ParaPanel);
                }
            }
        }

        #region para menu
        private MenuButtonDto m_ParaMenu1;
        public MenuButtonDto ParaMenu1
        {
            get { return m_ParaMenu1; }
            set
            {
                if (m_ParaMenu1 != value)
                {
                    m_ParaMenu1 = value;
                    RaisePropertyChanged(() => ParaMenu1);
                }
            }
        }

        private MenuButtonDto m_ParaMenu2;
        public MenuButtonDto ParaMenu2
        {
            get { return m_ParaMenu2; }
            set
            {
                if (m_ParaMenu2 != value)
                {
                    m_ParaMenu2 = value;
                    RaisePropertyChanged(() => ParaMenu2);
                }
            }
        }

        private MenuButtonDto m_ParaMenu3;
        public MenuButtonDto ParaMenu3
        {
            get { return m_ParaMenu3; }
            set
            {
                if (m_ParaMenu3 != value)
                {
                    m_ParaMenu3 = value;
                    RaisePropertyChanged(() => ParaMenu3);
                }
            }
        }

        private MenuButtonDto m_ParaMenu4;
        public MenuButtonDto ParaMenu4
        {
            get { return m_ParaMenu4; }
            set
            {
                if (m_ParaMenu4 != value)
                {
                    m_ParaMenu4 = value;
                    RaisePropertyChanged(() => ParaMenu4);
                }
            }
        }

        private MenuButtonDto m_ParaMenu5;
        public MenuButtonDto ParaMenu5
        {
            get { return m_ParaMenu5; }
            set
            {
                if (m_ParaMenu5 != value)
                {
                    m_ParaMenu5 = value;
                    RaisePropertyChanged(() => ParaMenu5);
                }
            }
        }

        private MenuButtonDto m_ParaMenu6;
        public MenuButtonDto ParaMenu6
        {
            get { return m_ParaMenu6; }
            set
            {
                if (m_ParaMenu6 != value)
                {
                    m_ParaMenu6 = value;
                    RaisePropertyChanged(() => ParaMenu6);
                }
            }
        }

        private MenuButtonDto m_ParaMenu7;
        public MenuButtonDto ParaMenu7
        {
            get { return m_ParaMenu7; }
            set
            {
                if (m_ParaMenu7 != value)
                {
                    m_ParaMenu7 = value;
                    RaisePropertyChanged(() => ParaMenu7);
                }
            }
        }

        private MenuButtonDto m_ParaMenu8;
        public MenuButtonDto ParaMenu8
        {
            get { return m_ParaMenu8; }
            set
            {
                if (m_ParaMenu8 != value)
                {
                    m_ParaMenu8 = value;
                    RaisePropertyChanged(() => ParaMenu8);
                }
            }
        }

        private bool m_ParaMenu1Cheched;
        public bool ParaMenu1Cheched
        {
            get { return m_ParaMenu1Cheched; }
            set
            {
                if (m_ParaMenu1Cheched != value)
                {
                    m_ParaMenu1Cheched = value;
                    RaisePropertyChanged(() => ParaMenu1Cheched);
                }
            }
        }

        private bool m_ParaMenu2Cheched;
        public bool ParaMenu2Cheched
        {
            get { return m_ParaMenu2Cheched; }
            set
            {
                if (m_ParaMenu2Cheched != value)
                {
                    m_ParaMenu2Cheched = value;
                    RaisePropertyChanged(() => ParaMenu2Cheched);
                }
            }
        }

        private bool m_ParaMenu3Cheched;
        public bool ParaMenu3Cheched
        {
            get { return m_ParaMenu3Cheched; }
            set
            {
                if (m_ParaMenu3Cheched != value)
                {
                    m_ParaMenu3Cheched = value;
                    RaisePropertyChanged(() => ParaMenu3Cheched);
                }
            }
        }

        private bool m_ParaMenu4Cheched;
        public bool ParaMenu4Cheched
        {
            get { return m_ParaMenu4Cheched; }
            set
            {
                if (m_ParaMenu4Cheched != value)
                {
                    m_ParaMenu4Cheched = value;
                    RaisePropertyChanged(() => ParaMenu4Cheched);
                }
            }
        }

        private bool m_ParaMenu5Cheched;
        public bool ParaMenu5Cheched
        {
            get { return m_ParaMenu5Cheched; }
            set
            {
                if (m_ParaMenu5Cheched != value)
                {
                    m_ParaMenu5Cheched = value;
                    RaisePropertyChanged(() => ParaMenu5Cheched);
                }
            }
        }

        private bool m_ParaMenu6Cheched;
        public bool ParaMenu6Cheched
        {
            get { return m_ParaMenu6Cheched; }
            set
            {
                if (m_ParaMenu6Cheched != value)
                {
                    m_ParaMenu6Cheched = value;
                    RaisePropertyChanged(() => ParaMenu6Cheched);
                }
            }
        }

        private bool m_ParaMenu7Cheched;
        public bool ParaMenu7Cheched
        {
            get { return m_ParaMenu7Cheched; }
            set
            {
                if (m_ParaMenu7Cheched != value)
                {
                    m_ParaMenu7Cheched = value;
                    RaisePropertyChanged(() => ParaMenu7Cheched);
                }
            }
        }

        private bool m_ParaMenu8Cheched;
        public bool ParaMenu8Cheched
        {
            get { return m_ParaMenu8Cheched; }
            set
            {
                if (m_ParaMenu8Cheched != value)
                {
                    m_ParaMenu8Cheched = value;
                    RaisePropertyChanged(() => ParaMenu8Cheched);
                }
            }
        }

        private void ChangeParaMenuEvent(bool m1 = false, bool m2 = false, bool m3 = false, bool m4 = false, 
            bool m5 = false, bool m6 = false, bool m7 = false, bool m8 = false)
        {
            ParaMenu1Cheched = m1;
            ParaMenu2Cheched = m2;
            ParaMenu3Cheched = m3;
            ParaMenu4Cheched = m4;
            ParaMenu5Cheched = m5;
            ParaMenu6Cheched = m6;
            ParaMenu7Cheched = m7;
            ParaMenu8Cheched = m8;
        }

        private void InitialParaMenu()
        {
            ParaMenu1 = new MenuButtonDto
            {
                Text = "换模设定",
                Cmd = new RelayCommand(OnParaMenu1Click),
                Visibility = "Visible",
            };

            ParaMenu2 = new MenuButtonDto
            {
                Text = "夹模器设定",
                Cmd = new RelayCommand(OnParaMenu2Click),
                Visibility = "Visible",
            };

            ParaMenu3 = new MenuButtonDto
            {
                Text = "合模设定",
                Cmd = new RelayCommand(OnParaMenu3Click),
                Visibility = "Visible",
            };


            ParaMenu4 = new MenuButtonDto
            {
                Text = "分模设定",
                Cmd = new RelayCommand(OnParaMenu4Click),
                Visibility = "Visible",
            };


            ParaMenu5 = new MenuButtonDto
            {
                Text = "保压设定",
                Cmd = new RelayCommand(OnParaMenu5Click),
                Visibility = "Visible",
            };

            ParaMenu6 = new MenuButtonDto
            {
                Text = "自动化气源",
                Cmd = new RelayCommand(OnParaMenu6Click),
                Visibility = "Visible",
            };


            ParaMenu7 = new MenuButtonDto
            {
                Text = "模具液压",
                Cmd = new RelayCommand(OnParaMenu7Click),
                Visibility = "Visible",
            };

            ParaMenu8 = new MenuButtonDto
            {
                Text = "下一页",
                Cmd = new RelayCommand(OnParaMenu8Click),
                Visibility = "Visible",
            };


            OnParaMenu1Click();

        }

        private void InitialParaMenu2()
        {


            ParaMenu1 = new MenuButtonDto
            {
                Text = "计数器",
                Cmd = new RelayCommand(OnParaMenu11Click),
                Visibility = "Visible",
            };

            ParaMenu2 = new MenuButtonDto()
            {
                Text = "工艺管理",
                Cmd = new RelayCommand(OnParaMenu12Click),
                Visibility = "Visible",
            };

            ParaMenu3 = new MenuButtonDto();
            ParaMenu4 = new MenuButtonDto();
            ParaMenu4 = new MenuButtonDto();
            ParaMenu5 = new MenuButtonDto();
            ParaMenu6 = new MenuButtonDto();
            ParaMenu7 = new MenuButtonDto();

            ParaMenu8 = new MenuButtonDto
            {
                Text = "上一页",
                Cmd = new RelayCommand(OnParaMenu18Click),
                Visibility = "Visible",
            };

            OnParaMenu11Click();
        }

        private void OnParaMenu1Click()
        {
            ChangeParaMenuEvent(m1: true);
            _ParaPanel = new ParaSubDieChangePage();
            
        }

        private void OnParaMenu2Click()
        {
            ChangeParaMenuEvent(m2: true);
            _ParaPanel = new ParaSubDieClampPage();
        }

        private void OnParaMenu3Click()
        {
            ChangeParaMenuEvent(m3: true);
            _ParaPanel = new ParaSubDieClosingPage();
        }
        private void OnParaMenu4Click()
        {
            ChangeParaMenuEvent(m4: true);
            _ParaPanel = new ParaSubDiePartingPage();
        }
        private void OnParaMenu5Click()
        {
            ChangeParaMenuEvent(m5: true);
            _ParaPanel = new ParaSubPressureMaintPage();
        }
        private void OnParaMenu6Click()
        {
            ChangeParaMenuEvent(m6: true);
            _ParaPanel = new ParaSubAutoAirSourcePage();
        }

        private void OnParaMenu7Click()
        {
            ChangeParaMenuEvent(m7: true);
            _ParaPanel = new ParaSubDieHydrPage();
        }

        private void OnParaMenu8Click()
        {
            ChangeParaMenuEvent(m8: true);
            InitialParaMenu2();
        }

        private void OnParaMenu11Click()
        {
            ChangeParaMenuEvent(m1: true);
            _ParaPanel = new ParaSubWorkCountPage();
        }

        private void OnParaMenu12Click()
        {
            ChangeParaMenuEvent(m2: true);
            _ParaPanel = new ParaSubWorkCountPage();
        }
        

        private void OnParaMenu18Click()
        {
            ChangeParaMenuEvent(m8: true);
            InitialParaMenu();
        }



        #endregion


        #region ctrl
        public ParaMainPageViewModel()
        {
            InitialParaMenu();
            

        }

        #endregion

    }
}
