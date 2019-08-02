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
    public class DoubleDataInputDialogViewModel : ViewModelBase
    {
        public ICommand _OkCmd { get; set; }
        public ICommand _CancelCmd { get; set; }

        private double m_InputData;
        public double InputData
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

        private InputDialogData Data;

        public DoubleDataInputDialogViewModel(ref InputDialogData data)
        {
            Data = data;

            _OkCmd = new RelayCommand(OnOkCmd);
            _CancelCmd = new RelayCommand(OnCancelCmd);

        }

        private void OnOkCmd()
        {
            Data.DoubleData = InputData;

            Messenger.Default.Send<bool>(true, "DoubleDataInputDialogQuitMsg");
        }

        private void OnCancelCmd()
        {
            Messenger.Default.Send<bool>(false, "DoubleDataInputDialogQuitMsg");
        }

    }
}
