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
    /// SystemMacroPage.xaml 的交互逻辑
    /// </summary>
    public partial class SystemMacroPage : Page
    {
        SystemMacroItemViewModel systemMacro;
        public SystemMacroPage()
        {
            InitializeComponent();
            var viewModel = SimpleIoc.Default.GetInstance<SystemMacroViewModel>();
            viewModel.ShowDialogWindowEvent += ViewModel_ShowDialogWindowEvent;
            this.Unloaded += (s, e) => viewModel.ShowDialogWindowEvent -= ViewModel_ShowDialogWindowEvent;
            this.DataContext = viewModel;

        }

        private void ViewModel_ShowDialogWindowEvent(SystemMacroItemViewModel systemMacro)
        {
            this.systemMacro = systemMacro;
            var dlg = new MacroDataInputDialog(FanucCnc.Fanuc.CreateInstance(), systemMacro.Address + "", systemMacro.Title);
            dlg.SaveInputEvent += Dlg_SaveInputEvent;
            dlg.ShowDialog();
        }

        private void Dlg_SaveInputEvent(string obj)
        {
            int result = 0;
            if (Int32.TryParse(obj, out result))
            {
                this.systemMacro.Address = (short)result;

            }

        }

    }
}
