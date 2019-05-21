using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// SParaMainPage.xaml 的交互逻辑
    /// </summary>
    public partial class SParaMainPage : Page
    {
        public SParaMainPage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<SParaMainPageViewModel>();
        }
    }
}
