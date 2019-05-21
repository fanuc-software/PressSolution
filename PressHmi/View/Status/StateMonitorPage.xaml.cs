using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.ComponentModel;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Messaging;
using Abt.Controls.SciChart.Model.DataSeries;
using FanucCnc.Model;

namespace PressHmi.View
{
    /// <summary>
    /// StateMonitorPage.xaml 的交互逻辑
    /// </summary>
    public partial class StateMonitorPage : Page
    {
        public StateMonitorPage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<StateMonitorPageViewModel>();
        }
        
        
    }
}
