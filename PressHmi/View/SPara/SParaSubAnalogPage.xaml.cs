using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;


namespace PressHmi.View
{
    /// <summary>
    /// SParaSubAnalogPage.xaml 的交互逻辑
    /// </summary>
    public partial class SParaSubAnalogPage : Page
    {
        public SParaSubAnalogPage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<SParaSubAnalogPageViewModel>();
        }
    }
}
