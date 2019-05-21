using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// SParaSubEncodePage.xaml 的交互逻辑
    /// </summary>
    public partial class SParaSubEncodePage : Page
    {
        public SParaSubEncodePage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<SParaSubEncodePageViewModel>();
        }
    }
}
