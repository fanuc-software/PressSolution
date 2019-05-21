using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// ParaSubProcManagementPage.xaml 的交互逻辑
    /// </summary>
    public partial class ParaSubProcManagementPage : Page
    {
        public ParaSubProcManagementPage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<ParaSubProcManagementPageViewModel>();
        }
    }
}
