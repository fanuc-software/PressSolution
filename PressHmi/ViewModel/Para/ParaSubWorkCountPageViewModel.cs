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
    public class ParaSubWorkCountPageViewModel : MyBaseViewModel
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }

        private ParaWorkCountInfoDto m_ParaWorkCountInfo = new ParaWorkCountInfoDto();
        public ParaWorkCountInfoDto ParaWorkCountInfo
        {
            get { return m_ParaWorkCountInfo; }
            set
            {
                if (m_ParaWorkCountInfo != value)
                {
                    m_ParaWorkCountInfo = value;
                    RaisePropertyChanged(() => ParaWorkCountInfo);
                }
            }
        }

        public ParaSubWorkCountPageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);
            


            Messenger.Default.Register<ParaWorkCountInfo>(this, "ParaWorkCountInfoMsg", msg =>
            {
                ParaWorkCountInfo = _mapper.Map<ParaWorkCountInfo, ParaWorkCountInfoDto>(msg);
            });

        }

        private void OnLoaded()
        {
            _fanuc.ChangePageEvent(paraworkcount: true);
        }

        private void OnUnloaded()
        {

        }

    }
}
