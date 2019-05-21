using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// ParaSubDieChangePage.xaml 的交互逻辑
    /// </summary>
    public partial class ParaSubDieChangePage : Page
    {
        public ParaSubDieChangePage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<ParaSubDieChangePageViewModel>();
        }
    }
}
