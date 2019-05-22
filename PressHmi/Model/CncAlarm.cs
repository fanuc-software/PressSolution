using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class CncAlarm : ViewModelBase
    {
        private short _type;
        public short Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;

                    RaisePropertyChanged(() => Type);
                }
            }
        }
        


        private int _alm_No;
        public int Alm_No
        {
            get { return _alm_No; }
            set
            {
                if (_alm_No != value)
                {
                    _alm_No = value;
                    RaisePropertyChanged(() => Alm_No);
                }
            }
        }

        private short _axis;
        public short Axis
        {
            get { return _axis; }
            set
            {
                if (_axis != value)
                {
                    _axis = value;
                    RaisePropertyChanged(() => Axis);
                }
            }
        }

        private string _alm_Msg;
        public string Alm_Msg
        {
            get { return _alm_Msg; }
            set
            {
                if (_alm_Msg != value)
                {
                    _alm_Msg = value;
                    RaisePropertyChanged(() => Alm_Msg);
                }
            }
        }


    }
}
