using FanucCnc.Enum;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
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

namespace PressHmi.View.Dialogs
{
    /// <summary>
    /// OperatorAuthDialog.xaml 的交互逻辑
    /// </summary>
    public partial class OperatorAuthDialog : Window
    {
        public OperatorAuthDialog()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<OperatorAuthDialogViewModel>();


            Messenger.Default.Register<OperatorAuthTypeEnum>(this, "OperatorAuthMsg", msg =>
            {
                this.Close();
            });
        }
    }
}
