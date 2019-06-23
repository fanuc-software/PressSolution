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
    public class MaintainSubCsdPageViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }
        public ICommand CncMenuCommand { get; set; }
        public ICommand NumericAlphabetCommand { get; set; }

        private bool m_ShiftChecked;
        public bool ShiftChecked
        {
            get { return m_ShiftChecked; }
            set
            {
                if (m_ShiftChecked != value)
                {
                    m_ShiftChecked = value;
                    RaisePropertyChanged(() => ShiftChecked);
                }
            }
        }
        
        #region 画面切换与数字/字母切换
        private bool m_CncMenuChecked;
        public bool CncMenuChecked
        {
            get { return m_CncMenuChecked; }
            set
            {
                if (m_CncMenuChecked != value)
                {
                    m_CncMenuChecked = value;
                    RaisePropertyChanged(() => CncMenuChecked);
                }
            }
        }

        private string m_NumericVisible;
        public string NumericVisible
        {
            get { return m_NumericVisible; }
            set
            {
                if (m_NumericVisible != value)
                {
                    m_NumericVisible = value;
                    RaisePropertyChanged(() => NumericVisible);
                }
            }
        }

        private string m_AlphabetVisible;
        public string AlphabetVisible
        {
            get { return m_AlphabetVisible; }
            set
            {
                if (m_AlphabetVisible != value)
                {
                    m_AlphabetVisible = value;
                    RaisePropertyChanged(() => AlphabetVisible);
                }
            }
        }

        private bool m_NumericAlphabetChecked;
        public bool NumericAlphabetChecked
        {
            get { return m_NumericAlphabetChecked; }
            set
            {
                if (m_NumericAlphabetChecked != value)
                {
                    m_NumericAlphabetChecked = value;
                    RaisePropertyChanged(() => NumericAlphabetChecked);
                }
            }
        }



        private void ChangeNumberAlphabet(bool btncheched =false)
        {
            AlphabetVisible = btncheched == true ? "Visible" : "Hidden";
            NumericVisible = btncheched == false ? "Visible" : "Hidden";
        }

        #endregion

        #region 数字键盘
        public ICommand Numberic_0_Command{ get; set; }
        public ICommand Numberic_1_Command { get; set; }
        public ICommand Numberic_2_Command { get; set; }
        public ICommand Numberic_3_Command { get; set; }
        public ICommand Numberic_4_Command { get; set; }
        public ICommand Numberic_5_Command { get; set; }
        public ICommand Numberic_6_Command { get; set; }
        public ICommand Numberic_7_Command { get; set; }
        public ICommand Numberic_8_Command { get; set; }
        public ICommand Numberic_9_Command { get; set; }
        public ICommand Numberic_PLUS_Command { get; set; }
        public ICommand Numberic_MINUS_Command { get; set; }
        public ICommand Numberic_STAR_Command { get; set; }
        public ICommand Numberic_SLASH_Command { get; set; }
        public ICommand Numberic_POINT_Command { get; set; }
        public ICommand Numberic_EQUAL_Command { get; set; }

        private void InitialNumberic()
        {
            Numberic_0_Command = new RelayCommand(OnNumberic_0);
            Numberic_1_Command = new RelayCommand(OnNumberic_1);
            Numberic_2_Command = new RelayCommand(OnNumberic_2);
            Numberic_3_Command = new RelayCommand(OnNumberic_3);
            Numberic_4_Command = new RelayCommand(OnNumberic_4);
            Numberic_5_Command = new RelayCommand(OnNumberic_5);
            Numberic_6_Command = new RelayCommand(OnNumberic_6);
            Numberic_7_Command = new RelayCommand(OnNumberic_7);
            Numberic_8_Command = new RelayCommand(OnNumberic_8);
            Numberic_9_Command = new RelayCommand(OnNumberic_9);

            Numberic_PLUS_Command = new RelayCommand(OnNumberic_PLUS);
            Numberic_MINUS_Command = new RelayCommand(OnNumberic_MINUS);
            Numberic_STAR_Command = new RelayCommand(OnNumberic_STAR);
            Numberic_SLASH_Command = new RelayCommand(OnNumberic_SLASH);
            Numberic_POINT_Command = new RelayCommand(OnNumberic_POINT);
            Numberic_EQUAL_Command = new RelayCommand(OnNumberic_EQUAL);
        }

        private void OnNumberic_0()
        {

        }
        private void OnNumberic_1()
        {

        }
        private void OnNumberic_2()
        {

        }
        private void OnNumberic_3()
        {

        }

        private void OnNumberic_4()
        {

        }

        private void OnNumberic_5()
        {

        }
        private void OnNumberic_6()
        {

        }
        private void OnNumberic_7()
        {

        }
        private void OnNumberic_8()
        {

        }

        private void OnNumberic_9()
        {

        }

        private void OnNumberic_PLUS()
        {

        }

        private void OnNumberic_MINUS()
        {

        }

        private void OnNumberic_STAR()
        {

        }

        private void OnNumberic_EQUAL()
        {

        }

        private void OnNumberic_SLASH()
        {

        }

        private void OnNumberic_POINT()
        {

        }

        #endregion

        #region COMMON键盘
        public ICommand COMMON_UP_Command { get; set; }
        public ICommand COMMON_DOWN_Command { get; set; }
        public ICommand COMMON_LEFT_Command { get; set; }
        public ICommand COMMON_RIGHT_Command { get; set; }
        public ICommand COMMON_RESET_Command { get; set; }
        public ICommand COMMON_ALTER_Command { get; set; }
        public ICommand COMMON_DEL_Command { get; set; }
        public ICommand COMMON_CAN_Command { get; set; }
        public ICommand COMMON_INSERT_Command { get; set; }
        public ICommand COMMON_INPUT_Command { get; set; }

        private void InitialCommon()
        {
            COMMON_UP_Command = new RelayCommand(OnCOMMON_UP);
            COMMON_DOWN_Command = new RelayCommand(OnCOMMON_DOWN);
            COMMON_LEFT_Command = new RelayCommand(OnCOMMON_LEFT);
            COMMON_RIGHT_Command = new RelayCommand(OnCOMMON_RIGHT);
            COMMON_RESET_Command = new RelayCommand(OnCOMMON_RESET);
            COMMON_ALTER_Command = new RelayCommand(OnCOMMON_ALTER);
            COMMON_DEL_Command = new RelayCommand(OnCOMMON_DEL);
            COMMON_CAN_Command = new RelayCommand(OnCOMMON_CAN);
            COMMON_INSERT_Command = new RelayCommand(OnCOMMON_INSERT);
            COMMON_INPUT_Command = new RelayCommand(OnCOMMON_INPUT);
        }

        private void OnCOMMON_UP()
        {

        }
        private void OnCOMMON_DOWN()
        {

        }
        private void OnCOMMON_LEFT()
        {

        }
        private void OnCOMMON_RIGHT()
        {

        }
        private void OnCOMMON_RESET()
        {

        }
        private void OnCOMMON_ALTER()
        {

        }
        private void OnCOMMON_DEL()
        {

        }
        private void OnCOMMON_CAN()
        {

        }
        private void OnCOMMON_INSERT()
        {

        }
        private void OnCOMMON_INPUT()
        {

        }

        #endregion

        #region 字母按键
        public ICommand Alphabet_O_Command { get; set; }
        public ICommand Alphabet_N_Command { get; set; }
        public ICommand Alphabet_G_Command { get; set; }
        public ICommand Alphabet_P_Command { get; set; }
        public ICommand Alphabet_X_Command { get; set; }
        public ICommand Alphabet_Y_Command { get; set; }
        public ICommand Alphabet_Z_Command { get; set; }
        public ICommand Alphabet_Q_Command { get; set; }
        public ICommand Alphabet_I_Command { get; set; }
        public ICommand Alphabet_J_Command { get; set; }
        public ICommand Alphabet_K_Command { get; set; }
        public ICommand Alphabet_R_Command { get; set; }
        public ICommand Alphabet_M_Command { get; set; }
        public ICommand Alphabet_S_Command { get; set; }
        public ICommand Alphabet_T_Command { get; set; }
        public ICommand Alphabet_L_Command { get; set; }
        public ICommand Alphabet_F_Command { get; set; }
        public ICommand Alphabet_D_Command { get; set; }
        public ICommand Alphabet_H_Command { get; set; }
        public ICommand Alphabet_B_Command { get; set; }

        private void InitialAlphabet()
        {
            Alphabet_O_Command = new RelayCommand(OnAlphabet_O);
            Alphabet_N_Command = new RelayCommand(OnAlphabet_N);
            Alphabet_G_Command = new RelayCommand(OnAlphabet_G);
            Alphabet_P_Command = new RelayCommand(OnAlphabet_P);
            Alphabet_X_Command = new RelayCommand(OnAlphabet_X);
            Alphabet_Y_Command = new RelayCommand(OnAlphabet_Y);
            Alphabet_Z_Command = new RelayCommand(OnAlphabet_Z);
            Alphabet_Q_Command = new RelayCommand(OnAlphabet_Q);
            Alphabet_I_Command = new RelayCommand(OnAlphabet_I);
            Alphabet_J_Command = new RelayCommand(OnAlphabet_J);
            Alphabet_K_Command = new RelayCommand(OnAlphabet_K);
            Alphabet_R_Command = new RelayCommand(OnAlphabet_R);
            Alphabet_M_Command = new RelayCommand(OnAlphabet_M);
            Alphabet_S_Command = new RelayCommand(OnAlphabet_S);
            Alphabet_T_Command = new RelayCommand(OnAlphabet_T);
            Alphabet_L_Command = new RelayCommand(OnAlphabet_L);
            Alphabet_F_Command = new RelayCommand(OnAlphabet_F);
            Alphabet_D_Command = new RelayCommand(OnAlphabet_D);
            Alphabet_H_Command = new RelayCommand(OnAlphabet_H);
            Alphabet_B_Command = new RelayCommand(OnAlphabet_B);
        }

        private void OnAlphabet_O()
        {

        }
        private void OnAlphabet_N()
        {

        }
        private void OnAlphabet_G()
        {

        }
        private void OnAlphabet_P()
        {

        }

        private void OnAlphabet_X()
        {

        }
        private void OnAlphabet_Y()
        {

        }
        private void OnAlphabet_Z()
        {

        }
        private void OnAlphabet_Q()
        {

        }

        private void OnAlphabet_I()
        {

        }
        private void OnAlphabet_J()
        {

        }
        private void OnAlphabet_K()
        {

        }
        private void OnAlphabet_R()
        {

        }

        private void OnAlphabet_M()
        {

        }
        private void OnAlphabet_S()
        {

        }
        private void OnAlphabet_T()
        {

        }
        private void OnAlphabet_L()
        {

        }

        private void OnAlphabet_F()
        {

        }
        private void OnAlphabet_D()
        {

        }
        private void OnAlphabet_H()
        {

        }
        private void OnAlphabet_B()
        {

        }

        #endregion

        public MaintainSubCsdPageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            CncMenuCommand = new RelayCommand(OnCncMenu);
            NumericAlphabetCommand = new RelayCommand(OnNumericAlphabet);

            InitialAlphabet();
            InitialCommon();
            InitialNumberic();


            ChangeNumberAlphabet(NumericAlphabetChecked);
        }

        private void OnCncMenu()
        {

        }

        private void OnNumericAlphabet()
        {
            ChangeNumberAlphabet(NumericAlphabetChecked);
        }

    }
}
