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

namespace PressHmi.View
{
    public class DataInputDialogViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private PmcBomItem _pmc;
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

        public DataInputDialogViewModel(Fanuc fanuc, PmcBomItem pmc,  LimitBomItem limit, string title)
        {
            _fanuc = fanuc;
            _pmc = pmc;
            _limit = limit;
            DataInputTitle = title;


            if (limit != null)
            {
                if (limit.LimitUp.HasValue == true) DataLimitUp = limit.LimitUp.Value.ToString();
                if (limit.LimitDown.HasValue == true) DataLimitDown = limit.LimitDown.ToString();
            }
            
            _OkCmd = new RelayCommand(OnOkCmd);
            _CancelCmd = new RelayCommand(OnCancelCmd);
            
        }
        

        private void OnOkCmd()
        {
            var ret = _fanuc.SetPmc(_pmc, _limit, InputData);

            if (ret != null) DataInputMessage = ret;
            else
            {
                Messenger.Default.Send<bool>(true, "DataInputDialogQuitMsg");
            }
        }

        private void OnCancelCmd()
        {
            Messenger.Default.Send<bool>(false, "DataInputDialogQuitMsg");
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
