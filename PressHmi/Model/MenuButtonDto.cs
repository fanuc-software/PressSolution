using GalaSoft.MvvmLight;
using System.Windows.Input;

namespace PressHmi.Model
{
    public class MenuButtonDto : ViewModelBase
    {
        private string m_Image;
        public string Image
        {
            get { return m_Image; }
            set
            {
                if (m_Image != value)
                {
                    m_Image = value;
                    RaisePropertyChanged(() => Image);
                }
            }
        }

        private string m_Text;
        public string Text
        {
            get { return m_Text; }
            set
            {
                if (m_Text != value)
                {
                    m_Text = value;
                    RaisePropertyChanged(() => Text);
                }
            }
        }

        private string m_Text2;
        public string Text2
        {
            get { return m_Text2; }
            set
            {
                if (m_Text2 != value)
                {
                    m_Text2 = value;
                    RaisePropertyChanged(() => Text2);
                }
            }
        }

        private string m_Visibility;
        public string Visibility
        {
            get { return m_Visibility; }
            set
            {
                if (m_Visibility != value)
                {
                    m_Visibility = value;
                    RaisePropertyChanged(() => Visibility);
                }
            }
        }

        private ICommand m_Cmd;
        public ICommand Cmd
        {
            get { return m_Cmd; }
            set
            {
                if (m_Cmd != value)
                {
                    m_Cmd = value;
                    RaisePropertyChanged(() => Cmd);
                }
            }
        }

    }
}
