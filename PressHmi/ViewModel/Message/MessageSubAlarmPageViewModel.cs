using System;
using System.Collections.ObjectModel;
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
    public class MessageSubAlarmPageViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        private ObservableCollection<PressHmi.Model.CncAlarm> _alarmList = new ObservableCollection<PressHmi.Model.CncAlarm>();
        public ObservableCollection<PressHmi.Model.CncAlarm> _AlarmList
        {
            get { return _alarmList; }
            set
            {
                if (_alarmList != value)
                {
                    _alarmList = value;
                    RaisePropertyChanged(() => _AlarmList);
                }
            }
        }

        public MessageSubAlarmPageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            Messenger.Default.Register<CncStaticInfo>(this, "CncStaticInfoMsg", msg =>
            {
                var CncStaticInfo = _mapper.Map<CncStaticInfo, CncStaticInfoDto>(msg);

                string[] alm_type = { "SW", "PW", "IO", "PS", "OT", "OH", "SV", "SR", "MC", "SP", "DS", "IE", "BG", "SN", "", "EX", "", "", "", "PC" };
                string[] alm_axis = { "", "(X)", "(Y)", "(Z)" };

                DispatcherHelper.CheckBeginInvokeOnUI(() =>
                {
                    _AlarmList.Clear();

                    CncStaticInfo.CncAlarmList.ForEach(x => _AlarmList.Add(x));
                });
            });

        }
    }
}
