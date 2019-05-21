using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// ParaSubWorkCountPage.xaml 的交互逻辑
    /// </summary>
    public partial class ParaSubWorkCountPage : Page
    {
        public ParaSubWorkCountPage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<ParaSubWorkCountPageViewModel>();
        }
    }
}
