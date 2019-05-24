using AutoMapper;
using FanucCnc.Model;
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
    /// SystemInfoPage.xaml 的交互逻辑
    /// </summary>
    public partial class SystemInfoPage : Page
    {
        SysetmInfoViewModel sysetmInfoViewModel;
        string propName;
        public SystemInfoPage()
        {
            InitializeComponent();
            this.Loaded += SystemInfoPage_Loaded;


        }

        private void SystemInfoPage_Loaded(object sender, RoutedEventArgs e)
        {
            var mapper = SimpleIoc.Default.GetInstance<IMapper>();
            sysetmInfoViewModel = mapper.Map<BaseInfo, SysetmInfoViewModel>(FanucCnc.Fanuc.CreateInstance().BaseInfo);
            sysetmInfoViewModel.OpenDialogWidnowEvent += SysetmInfoViewModel_OpenDialogWidnowEvent;
            this.DataContext = sysetmInfoViewModel;

        }

        private void SysetmInfoViewModel_OpenDialogWidnowEvent(string arg1, string arg2, string arg3)
        {
            propName = arg1;
            var dlg = new MacroDataInputDialog(FanucCnc.Fanuc.CreateInstance(), arg2, arg3);
            dlg.SaveInputEvent += Dlg_SaveInputEvent; 
            dlg.ShowDialog();
        }

        private void Dlg_SaveInputEvent(string obj)
        {
            var type = sysetmInfoViewModel.GetType();
            var prop = type.GetProperty(propName);
            prop.SetValue(sysetmInfoViewModel, Convert.ChangeType(obj, prop.PropertyType));
        }
    }
}
