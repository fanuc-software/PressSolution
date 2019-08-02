using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace PressHmi.Model
{
    public class MaintainSubLimitDto : ViewModelBase
    {
        public string PropertyName { get; set; }
        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    RaisePropertyChanged(() => Title);

                }
            }
        }

        private double limitUp;

        public double LimitUp
        {
            get { return limitUp; }
            set
            {
                if (limitUp != value)
                {
                    limitUp = value;
                    RaisePropertyChanged(() => LimitUp);
                }

            }
        }



        private double limitDown;

        public double LimitDown
        {
            get { return limitDown; }
            set
            {
                if (limitDown != value)
                {
                    limitDown = value;
                    RaisePropertyChanged(() => LimitDown);
                }
            }
        }

        public string Type { get; set; }
        public MaintainSubLimitDto CurrentLimit
        {
            get
            {

                return this;
            }
        }
      
        public ICommand ShowInputWindowCommand
        {
            get
            {
                return new RelayCommand<MaintainSubLimitDto>(d =>
                {
                    d.Type = "Up";
                    ShowLimitWindowEvent?.Invoke(d);
                });
            }
        }
        public ICommand ShowInputDownWindowCommand
        {
            get
            {
                return new RelayCommand<MaintainSubLimitDto>(d =>
                {
                    d.Type = "Down";
                    ShowLimitWindowEvent?.Invoke(d);
                });
            }
        }
        public event Action<MaintainSubLimitDto> ShowLimitWindowEvent;





    }
}
