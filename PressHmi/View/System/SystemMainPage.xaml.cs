using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// SystemMainPage.xaml 的交互逻辑
    /// </summary>
    public partial class SystemMainPage : Page
    {
        public SystemMainPage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<SystemMainPageViewModel>();
        }
    }
}
