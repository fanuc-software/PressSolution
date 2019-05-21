using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// ParaSubDiePartingPage.xaml 的交互逻辑
    /// </summary>
    public partial class ParaSubDiePartingPage : Page
    {
        public ParaSubDiePartingPage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<ParaSubDiePartingPageViewModel>();
        }
    }
}
