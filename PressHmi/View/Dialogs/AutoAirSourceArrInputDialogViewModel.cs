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
    public class AutoAirSourceArrInputDialogViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private PmcBomItem _pmc;

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

        public ICommand UpCmd { get; set; }

        public ICommand DownCmd { get; set; }

        private bool m_UpChecked;
        public bool UpChecked
        {
            get { return m_UpChecked; }
            set
            {
                if (m_UpChecked != value)
                {
                    m_UpChecked = value;
                    RaisePropertyChanged(() => UpChecked);
                }
            }
        }

        private bool m_DownChecked;
        public bool DownChecked
        {
            get { return m_DownChecked; }
            set
            {
                if (m_DownChecked != value)
                {
                    m_DownChecked = value;
                    RaisePropertyChanged(() => DownChecked);
                }
            }
        }

        public ICommand _OkCmd { get; set; }

        public ICommand _CancelCmd { get; set; }

        public AutoAirSourceArrInputDialogViewModel(Fanuc fanuc, PmcBomItem pmc, string title)
        {
            _fanuc = fanuc;
            _pmc = pmc;
            DataInputTitle = title;

            _OkCmd = new RelayCommand(OnOkCmd);
            _CancelCmd = new RelayCommand(OnCancelCmd);
            UpCmd = new RelayCommand(OnUpCmd);
            DownCmd = new RelayCommand(OnDownCmd);


            bool temp = false;
            var ret = _fanuc.GetPmc(pmc, ref temp);
            if (ret != null)
            {
                DataInputMessage = ret;
                ChangeArrEvent(up: true);
            }
            else
            {
                if(temp==false) ChangeArrEvent(up: true);
                else ChangeArrEvent(down: true);
            }

        }

        private void ChangeArrEvent(bool up = false, bool down = false)
        {
            UpChecked = up;
            DownChecked = down;

        }


        private void  OnUpCmd()
        {
            ChangeArrEvent(up: true);
        }

        private void OnDownCmd()
        {
            ChangeArrEvent(down: true);
        }

        private void OnOkCmd()
        {
            string ret = null;
            if (UpChecked == true) ret = _fanuc.SetPmc(_pmc, null, false.ToString());
            if(DownChecked==true) ret = _fanuc.SetPmc(_pmc, null, true.ToString());

            if (ret != null) DataInputMessage = ret;
            else
            {
                Messenger.Default.Send<bool>(true, "AutoAirSourceArrInputDialogQuitMsg");
            }
        }

        private void OnCancelCmd()
        {
            Messenger.Default.Send<bool>(false, "AutoAirSourceArrInputDialogQuitMsg");
        }
    }
}
