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



        public MaintainSubCsdPageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            CncMenuCommand = new RelayCommand(OnCncMenu);
            NumericAlphabetCommand = new RelayCommand(OnNumericAlphabet);
            
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
