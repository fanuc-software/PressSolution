using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;
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
    public class SystemTableViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand DataSearchCmd { get; set; }
        public ICommand SlidingPosCmd { get; set; }

        private double m_SlidingBlockPos;
        public double SlidingBlockPos
        {
            get { return m_SlidingBlockPos; }
            set
            {
                if (m_SlidingBlockPos != value)
                {
                    m_SlidingBlockPos = value;
                    RaisePropertyChanged(() => SlidingBlockPos);
                }
            }
        }

        private double m_ScrewPos;
        public double ScrewPos
        {
            get { return m_ScrewPos; }
            set
            {
                if (m_ScrewPos != value)
                {
                    m_ScrewPos = value;
                    RaisePropertyChanged(() => ScrewPos);
                }
            }
        }

        public SystemTableViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            DataSearchCmd = new RelayCommand(OnDataSearchCmd);
            SlidingPosCmd = new RelayCommand(OnSlidingPosCmd);

        }

        private void OnDataSearchCmd()
        {
            double sliding = Math.Round(SlidingBlockPos, 2);


            double screw = 0;
            var ret = _fanuc.SearchScrewData(sliding, ref screw);

            ScrewPos = screw;
        }

        private void OnSlidingPosCmd()
        {
            var data = new InputDialogData();
            var dlg = new DoubleDataInputDialog(ref data);
            dlg.ShowDialog();

            SlidingBlockPos = data.DoubleData;
        }
    }
}
