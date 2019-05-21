using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// ParaSubDieClampPage.xaml 的交互逻辑
    /// </summary>
    public partial class ParaSubDieClampPage : Page
    {
        public ParaSubDieClampPage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<ParaSubDieClampPageViewModel>();
        }
    }
}
