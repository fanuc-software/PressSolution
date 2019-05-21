using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// ParaSubDieClosingPage.xaml 的交互逻辑
    /// </summary>
    public partial class ParaSubDieClosingPage : Page
    {
        public ParaSubDieClosingPage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<ParaSubDieClosingPageViewModel>();
        }
    }
}
