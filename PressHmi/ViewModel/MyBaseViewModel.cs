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
using PressHmi.Roles;
using FanucCnc.Enum;

namespace PressHmi.ViewModel
{
    public class MyBaseViewModel : ViewModelBase
    {
        private bool m_OperatorRole;
        public bool _OperatorRole
        {
            get { return m_OperatorRole; }
            set
            {
                if (m_OperatorRole != value)
                {
                    m_OperatorRole = value;
                    RaisePropertyChanged(() => _OperatorRole);
                }
            }
        }

        private bool m_ManagerRole;
        public bool _ManagerRole
        {
            get { return m_ManagerRole; }
            set
            {
                if (m_ManagerRole != value)
                {
                    m_ManagerRole = value;
                    RaisePropertyChanged(() => _ManagerRole);
                }
            }
        }

        private bool m_MtbRole;
        public bool _MtbRole
        {
            get { return m_MtbRole; }
            set
            {
                if (m_MtbRole != value)
                {
                    m_MtbRole = value;
                    RaisePropertyChanged(() => _MtbRole);
                }
            }
        }

        private bool m_BfmRole;
        public bool _BfmRole
        {
            get { return m_BfmRole; }
            set
            {
                if (m_BfmRole != value)
                {
                    m_BfmRole = value;
                    RaisePropertyChanged(() => _BfmRole);
                }
            }
        }

        public void SetAuth(OperatorAuthTypeEnum auth )
        {
            switch(auth)
            {
                case OperatorAuthTypeEnum.OPERATOR:
                    _OperatorRole = true;
                    _ManagerRole = false;
                    _MtbRole = false;
                    _BfmRole = false;
                    break;
                case OperatorAuthTypeEnum.MANAGER:
                    _OperatorRole = true;
                    _ManagerRole = true;
                    _MtbRole = false;
                    _BfmRole = false;
                    break;
                case OperatorAuthTypeEnum.MTB:
                    _OperatorRole = true;
                    _ManagerRole = true;
                    _MtbRole = true;
                    _BfmRole = false;
                    break;
                case OperatorAuthTypeEnum.BFM:
                    _OperatorRole = true;
                    _ManagerRole = true;
                    _MtbRole = true;
                    _BfmRole = true;
                    break;
                default:
                    _OperatorRole = true;
                    _ManagerRole = false;
                    _MtbRole = false;
                    _BfmRole = false;
                    break;
            }
        }

        public MyBaseViewModel()
        {
            SetAuth(OperatorAuthTypeEnum.OPERATOR);

            Messenger.Default.Register<OperatorAuthTypeEnum>(this, "OperatorAuthMsg", msg =>
            {
                SetAuth(msg);
            });
        }
    }
}
