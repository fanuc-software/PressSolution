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
using System.Windows.Shapes;
using GalaSoft.MvvmLight.Messaging;
using PressHmi.View.Controls;
using FanucCnc;
using FanucCnc.Model;

namespace PressHmi.View
{
    /// <summary>
    /// AutoAirSourceArrInputDialog.xaml 的交互逻辑
    /// </summary>
    public partial class AutoAirSourceArrInputDialog : Window
    {
        public AutoAirSourceArrInputDialog(Fanuc fanuc, PmcBomItem pmc, string title)
        {
            InitializeComponent();
            this.DataContext = new AutoAirSourceArrInputDialogViewModel(fanuc, pmc, title);

            Messenger.Default.Register<bool>(this, "AutoAirSourceArrInputDialogQuitMsg", msg =>
            {
                this.Close();
            });
        }
    }
}
