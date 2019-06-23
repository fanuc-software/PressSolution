using FanucCnc;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.Model;
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
    /// MaintainSubLimitPage.xaml 的交互逻辑
    /// </summary>
    public partial class MaintainSubLimitPage : Page
    {
        MaintainSubLimitDto maintainSubLimitDto;
        public MaintainSubLimitPage()
        {
            InitializeComponent();
            var viewModel = SimpleIoc.Default.GetInstance<MaintainSubLimitPageViewModel>();
            viewModel.ShowLimitWindowEvent += ViewModel_ShowLimitWindowEvent;
            this.Unloaded += (s, e) => viewModel.ShowLimitWindowEvent -= ViewModel_ShowLimitWindowEvent;
            this.DataContext = viewModel;

        }

        private void ViewModel_ShowLimitWindowEvent(Fanuc fanuc, MaintainSubLimitDto obj)
        {
            maintainSubLimitDto = obj;
            var dlg = new MacroDataInputDialog(fanuc,
                (obj.Type == "Up" ? obj.LimitUp : obj.LimitDown) + "", $"输入{obj.Title}");
            dlg.SaveInputEvent += Dlg_SaveInputEvent;
            dlg.ShowDialog();

        }

        private void Dlg_SaveInputEvent(string obj)
        {
            if (maintainSubLimitDto.Type == "Up")
            {
                maintainSubLimitDto.LimitUp = Convert.ToDouble(obj);
            }
            else if (maintainSubLimitDto.Type == "Down")
            {
                maintainSubLimitDto.LimitDown = Convert.ToDouble(obj);
            }
        }
    }
}
