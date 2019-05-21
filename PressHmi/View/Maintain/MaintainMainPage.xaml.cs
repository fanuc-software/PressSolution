using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// ParaMainPage.xaml 的交互逻辑
    /// </summary>
    public partial class MaintainMainPage : Page
    {
        public MaintainMainPage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<MaintainMainPageViewModel>();
        }
    }
}
