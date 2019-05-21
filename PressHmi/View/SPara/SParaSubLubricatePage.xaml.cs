using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// SParaSubLubricatePage.xaml 的交互逻辑
    /// </summary>
    public partial class SParaSubLubricatePage : Page
    {
        public SParaSubLubricatePage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<SParaSubLubricatePageViewModel>();
        }
    }
}
