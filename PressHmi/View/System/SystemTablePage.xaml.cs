using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// SystemTablePage.xaml 的交互逻辑
    /// </summary>
    public partial class SystemTablePage : Page
    {
        public SystemTablePage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<SystemTableViewModel>();
        }
    }
}
