using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// SParaSubPressurePage.xaml 的交互逻辑
    /// </summary>
    public partial class SParaSubMachinePage : Page
    {
        public SParaSubMachinePage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<SParaSubMachinePageViewModel>();
        }
    }
}
