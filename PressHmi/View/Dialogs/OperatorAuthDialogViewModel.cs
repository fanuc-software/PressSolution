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
using FanucCnc.Enum;
using DataCenter.Services;
using PressHmi.Roles;
using GalaSoft.MvvmLight.Threading;

namespace PressHmi.View.Dialogs
{
    public class OperatorAuthDialogViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private Role _role;

        private System.Timers.Timer timerN = new System.Timers.Timer();

        private OperatorAuthTypeEnum m_OperatorRole;
        public OperatorAuthTypeEnum OperatorRole
        {
            get { return m_OperatorRole; }
            set
            {
                if (m_OperatorRole != value)
                {
                    m_OperatorRole = value;
                    RaisePropertyChanged(() => OperatorRole);
                }
            }
        }

        private string m_LoginPwd;
        public string LoginPwd
        {
            get { return m_LoginPwd; }
            set
            {
                if (m_LoginPwd != value)
                {
                    m_LoginPwd = value;
                    RaisePropertyChanged(() => LoginPwd);
                }
            }
        }

        private string m_LoginMessage;
        public string LoginMessage
        {
            get { return m_LoginMessage; }
            set
            {
                if (m_LoginMessage != value)
                {

                    timerN.Stop();
                    m_LoginMessage = value;
                    timerN.Start();

                    RaisePropertyChanged(() => LoginMessage);
                }
            }
        }


        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }

        public ICommand LoginCommand { get; set; }

        public OperatorAuthDialogViewModel(Fanuc fanuc, Role role)
        {
            _fanuc = fanuc;
            _role = role;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);
            LoginCommand = new RelayCommand(OnLoginCommand);

            timerN.Interval = System.Convert.ToDouble(2000);
            timerN.Elapsed += new System.Timers.ElapsedEventHandler(RefreshOperateNotice);
            timerN.Enabled = true;
            timerN.AutoReset = false;

        }

        private void OnLoaded()
        {
            LoginPwd = "";
        }

        private void RefreshOperateNotice(object sender, System.Timers.ElapsedEventArgs e)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                LoginMessage = "";
            });


        }

        private void OnUnloaded()
        {

        }

        private void OnLoginCommand()
        {
            var ret =  _role.SetOperatorRole(OperatorRole, LoginPwd);
            if(ret==false)
            {
                LoginMessage = "登录失败，密码错误";
            }

        }
    }
}
