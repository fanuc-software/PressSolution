using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// ParaSubAutoAirSourcePage.xaml 的交互逻辑
    /// </summary>
    public partial class ParaSubAutoAirSourcePage : Page
    {
        public ParaSubAutoAirSourcePage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<ParaSubAutoAirSourcePageViewModel>();
        }
    }
}
