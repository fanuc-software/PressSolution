using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// ParaSubPressureMaintPage.xaml 的交互逻辑
    /// </summary>
    public partial class ParaSubPressureMaintPage : Page
    {
        public ParaSubPressureMaintPage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<ParaSubPressureMaintPageViewModel>();
        }
    }
}
