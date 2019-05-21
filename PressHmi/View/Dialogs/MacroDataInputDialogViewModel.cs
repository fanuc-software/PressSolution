using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Serialization;
using System.Windows.Input;
using System.IO;
using System.ComponentModel;
using System.Configuration;
using System.Text.RegularExpressions;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using FanucCnc.Model;
using FanucCnc;
using System.Windows;
using System;

namespace PressHmi.View
{
    public class MacroDataInputDialogViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private MacroBomItem _macro;
        private LimitBomItem _limit;

        private string m_InputData;
        public string InputData
        {
            get { return m_InputData; }
            set
            {
                if (m_InputData != value)
                {
                    m_InputData = value;
                    RaisePropertyChanged(() => InputData);
                }
            }
        }

        private string m_DataInputMessage;
        public string DataInputMessage
        {
            get { return m_DataInputMessage; }
            set
            {
                if (m_DataInputMessage != value)
                {
                    m_DataInputMessage = value;
                    RaisePropertyChanged(() => DataInputMessage);
                }
            }
        }
        public Visibility Display { get; set; } = Visibility.Visible;
        private string m_DataInputTitle;
        public string DataInputTitle
        {
            get { return m_DataInputTitle; }
            set
            {
                if (m_DataInputTitle != value)
                {
                    m_DataInputTitle = value;
                    RaisePropertyChanged(() => DataInputTitle);
                }
            }
        }

        private string m_DataLimitUp;
        public string DataLimitUp
        {
            get { return m_DataLimitUp; }
            set
            {
                if (m_DataLimitUp != value)
                {
                    m_DataLimitUp = value;
                    RaisePropertyChanged(() => DataLimitUp);
                }
            }
        }

        private string m_DataLimitDown;
        public string DataLimitDown
        {
            get { return m_DataLimitDown; }
            set
            {
                if (m_DataLimitDown != value)
                {
                    m_DataLimitDown = value;
                    RaisePropertyChanged(() => DataLimitDown);
                }
            }
        }

        public ICommand _OkCmd { get; set; }

        public ICommand _CancelCmd { get; set; }

        public event Action<string> SaveActionEvent;

        public MacroDataInputDialogViewModel(Fanuc fanuc, MacroBomItem macro, LimitBomItem limit, string title)
        {
            _fanuc = fanuc;
            _macro = macro;
            _limit = limit;
            DataInputTitle = title;


            if (limit.LimitUp.HasValue == true) DataLimitUp = limit.LimitUp.Value.ToString();
            if (limit.LimitDown.HasValue == true) DataLimitDown = limit.LimitDown.ToString();

            _OkCmd = new RelayCommand(OnOkCmd);
            _CancelCmd = new RelayCommand(OnCancelCmd);

        }

        public MacroDataInputDialogViewModel(Fanuc fanuc, string value, string title)
        {
            _fanuc = fanuc;
            DataInputTitle = title;
            InputData = value;
            Display = Visibility.Hidden;
            _OkCmd = new RelayCommand(() => SaveActionEvent?.Invoke(InputData));
            _CancelCmd = new RelayCommand(OnCancelCmd);

        }
        public virtual void OnOkCmd()
        {
            var ret = _fanuc.SetMacro(_macro, _limit, InputData);

            if (ret != null) DataInputMessage = ret;
            else
            {
                Messenger.Default.Send<bool>(true, "MacroDataInputDialogQuitMsg");
            }
        }

        public virtual void OnCancelCmd()
        {
            Messenger.Default.Send<bool>(false, "MacroDataInputDialogQuitMsg");
        }
        private static bool IsNumeric(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*[.]?\d*$");
        }
        private static bool IsInt(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*$");
        }

    }
}
