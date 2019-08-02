using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// ParaSubDieHydrPage.xaml 的交互逻辑
    /// </summary>
    public partial class ParaSubDieHydrPage : Page
    {
        public ParaSubDieHydrPage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<ParaSubDieHydrPageViewModel>();
        }
    }
}
