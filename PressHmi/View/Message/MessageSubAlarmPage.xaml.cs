using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// MaintainSubAlarmPage.xaml 的交互逻辑
    /// </summary>
    public partial class MessageSubAlarmPage : Page
    {
        public MessageSubAlarmPage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<MessageSubAlarmPageViewModel>();
        }
    }
}
