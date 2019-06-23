using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PressHmi.View
{
    /// <summary>
    /// SystemPmcPage.xaml 的交互逻辑
    /// </summary>
    public partial class SystemPmcPage : Page
    {
        SystemPmcItemViewModel systemPmc;
        string currentPropName = "";
        public SystemPmcPage()
        {
            InitializeComponent();
            var viewModel = SimpleIoc.Default.GetInstance<SystemPmcViewModel>();
            viewModel.OpenDialogWindowEvent += ViewModel_OpenDialogWindowEvent;
            this.Unloaded += (s, e) => viewModel.OpenDialogWindowEvent -= ViewModel_OpenDialogWindowEvent;
            this.DataContext = viewModel;

        }

        private void ViewModel_OpenDialogWindowEvent(SystemPmcItemViewModel arg1, string arg2, string arg3)
        {
            systemPmc = arg1;
            currentPropName = arg2;
            var dlg = new MacroDataInputDialog(FanucCnc.Fanuc.CreateInstance(), arg3, arg1.Title);
            dlg.SaveInputEvent += Dlg_SaveInputEvent;
            dlg.ShowDialog();
        }

        private void Dlg_SaveInputEvent(string obj)
        {
            var type = systemPmc.GetType();
            var prop = type.GetProperty(currentPropName);
            prop.SetValue(systemPmc, Convert.ChangeType(obj, prop.PropertyType));
        }
    }
}
