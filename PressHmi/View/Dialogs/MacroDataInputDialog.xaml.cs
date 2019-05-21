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
    /// DataInputDialog.xaml 的交互逻辑
    /// </summary>
    public partial class MacroDataInputDialog : Window
    {
        public static RoutedUICommand _Cmd1 = new RoutedUICommand();
        public static RoutedUICommand _Cmd2 = new RoutedUICommand();
        public static RoutedUICommand _Cmd3 = new RoutedUICommand();
        public static RoutedUICommand _Cmd4 = new RoutedUICommand();
        public static RoutedUICommand _Cmd5 = new RoutedUICommand();
        public static RoutedUICommand _Cmd6 = new RoutedUICommand();
        public static RoutedUICommand _Cmd7 = new RoutedUICommand();
        public static RoutedUICommand _Cmd8 = new RoutedUICommand();
        public static RoutedUICommand _Cmd9 = new RoutedUICommand();
        public static RoutedUICommand _Cmd0 = new RoutedUICommand();
        public static RoutedUICommand _CmdShortLine = new RoutedUICommand();
        public static RoutedUICommand _CmdPoint = new RoutedUICommand();
        public static RoutedUICommand _CmdBackSpace = new RoutedUICommand();

        public event Action<string> SaveInputEvent;
        public MacroDataInputDialog(Fanuc fanuc, MacroBomItem macro, LimitBomItem limit, string title)
        {
            InitializeComponent();
            inputdata.Focus();
            this.DataContext = new MacroDataInputDialogViewModel(fanuc, macro, limit, title);

            CommandBinding Cb0 = new CommandBinding(_Cmd0, RunCommand_0);
            CommandBinding Cb1 = new CommandBinding(_Cmd1, RunCommand_1);
            CommandBinding Cb2 = new CommandBinding(_Cmd2, RunCommand_2);
            CommandBinding Cb3 = new CommandBinding(_Cmd3, RunCommand_3);
            CommandBinding Cb4 = new CommandBinding(_Cmd4, RunCommand_4);
            CommandBinding Cb5 = new CommandBinding(_Cmd5, RunCommand_5);
            CommandBinding Cb6 = new CommandBinding(_Cmd6, RunCommand_6);
            CommandBinding Cb7 = new CommandBinding(_Cmd7, RunCommand_7);
            CommandBinding Cb8 = new CommandBinding(_Cmd8, RunCommand_8);
            CommandBinding Cb9 = new CommandBinding(_Cmd9, RunCommand_9);
            CommandBinding CbShortLine = new CommandBinding(_CmdShortLine, RunCommand_ShortLine);
            CommandBinding CbPoint = new CommandBinding(_CmdPoint, RunCommand_Point);
            CommandBinding CbBackSpace = new CommandBinding(_CmdBackSpace, RunCommand_BackSpace);

            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb0);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb1);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb2);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb3);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb4);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb5);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb6);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb7);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb8);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb9);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), CbShortLine);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), CbPoint);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), CbBackSpace);

            Messenger.Default.Register<bool>(this, "MacroDataInputDialogQuitMsg", msg =>
            {
                this.Close();
            });

        }

        public MacroDataInputDialog(Fanuc fanu, string value, string title)
        {
            InitializeComponent();
            inputdata.Focus();

            var model = new MacroDataInputDialogViewModel(fanu, value, title);
            model.SaveActionEvent += Model_SaveActionEvent;
            this.DataContext = model;
            CommandBinding Cb0 = new CommandBinding(_Cmd0, RunCommand_0);
            CommandBinding Cb1 = new CommandBinding(_Cmd1, RunCommand_1);
            CommandBinding Cb2 = new CommandBinding(_Cmd2, RunCommand_2);
            CommandBinding Cb3 = new CommandBinding(_Cmd3, RunCommand_3);
            CommandBinding Cb4 = new CommandBinding(_Cmd4, RunCommand_4);
            CommandBinding Cb5 = new CommandBinding(_Cmd5, RunCommand_5);
            CommandBinding Cb6 = new CommandBinding(_Cmd6, RunCommand_6);
            CommandBinding Cb7 = new CommandBinding(_Cmd7, RunCommand_7);
            CommandBinding Cb8 = new CommandBinding(_Cmd8, RunCommand_8);
            CommandBinding Cb9 = new CommandBinding(_Cmd9, RunCommand_9);
            CommandBinding CbShortLine = new CommandBinding(_CmdShortLine, RunCommand_ShortLine);
            CommandBinding CbPoint = new CommandBinding(_CmdPoint, RunCommand_Point);
            CommandBinding CbBackSpace = new CommandBinding(_CmdBackSpace, RunCommand_BackSpace);

            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb0);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb1);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb2);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb3);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb4);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb5);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb6);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb7);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb8);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), Cb9);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), CbShortLine);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), CbPoint);
            CommandManager.RegisterClassCommandBinding(typeof(MacroDataInputDialog), CbBackSpace);

            Messenger.Default.Register<bool>(this, "MacroDataInputDialogQuitMsg", msg =>
            {
                this.Close();
            });

        }

        private void Model_SaveActionEvent(string obj)
        {
            SaveInputEvent?.Invoke(obj);
            this.Close();
        }
        #region 0~9
        void RunCommand_0(object sender, ExecutedRoutedEventArgs e)
        {
            //if (_CurrentControl == null) return;
            this.inputdata.Focus();
            PressHmi.View.Controls.Keyboard.Type(Key.D0);
            //_CurrentControl.Focus();
        }

        void RunCommand_1(object sender, ExecutedRoutedEventArgs e)
        {
            //if (_CurrentControl == null) return;
            this.inputdata.Focus();
            PressHmi.View.Controls.Keyboard.Type(Key.D1);
            //_CurrentControl.Focus();
        }

        void RunCommand_2(object sender, ExecutedRoutedEventArgs e)
        {
            //if (_CurrentControl == null) return;
            this.inputdata.Focus();
            PressHmi.View.Controls.Keyboard.Type(Key.D2);
            //_CurrentControl.Focus();
        }

        void RunCommand_3(object sender, ExecutedRoutedEventArgs e)
        {
            //if (_CurrentControl == null) return;
            this.inputdata.Focus();
            PressHmi.View.Controls.Keyboard.Type(Key.D3);
            //_CurrentControl.Focus();
        }

        void RunCommand_4(object sender, ExecutedRoutedEventArgs e)
        {
            //if (_CurrentControl == null) return;
            this.inputdata.Focus();
            PressHmi.View.Controls.Keyboard.Type(Key.D4);
            //_CurrentControl.Focus();
        }

        void RunCommand_5(object sender, ExecutedRoutedEventArgs e)
        {
            //if (_CurrentControl == null) return;
            this.inputdata.Focus();
            PressHmi.View.Controls.Keyboard.Type(Key.D5);
            //_CurrentControl.Focus();
        }

        void RunCommand_6(object sender, ExecutedRoutedEventArgs e)
        {
            //if (_CurrentControl == null) return;
            this.inputdata.Focus();
            PressHmi.View.Controls.Keyboard.Type(Key.D6);
            //_CurrentControl.Focus();
        }

        void RunCommand_7(object sender, ExecutedRoutedEventArgs e)
        {
            //if (_CurrentControl == null) return;
            this.inputdata.Focus();
            PressHmi.View.Controls.Keyboard.Type(Key.D7);
            //_CurrentControl.Focus();
        }

        void RunCommand_8(object sender, ExecutedRoutedEventArgs e)
        {
            //if (_CurrentControl == null) return;
            this.inputdata.Focus();
            PressHmi.View.Controls.Keyboard.Type(Key.D8);
            //_CurrentControl.Focus();
        }

        void RunCommand_9(object sender, ExecutedRoutedEventArgs e)
        {
            //if (_CurrentControl == null) return;
            this.inputdata.Focus();
            PressHmi.View.Controls.Keyboard.Type(Key.D9);
            //_CurrentControl.Focus();
        }

        void RunCommand_ShortLine(object sender, ExecutedRoutedEventArgs e)
        {
            //if (_CurrentControl == null) return;
            this.inputdata.Focus();
            PressHmi.View.Controls.Keyboard.Type(Key.Subtract);
            //_CurrentControl.Focus();
        }

        void RunCommand_Point(object sender, ExecutedRoutedEventArgs e)
        {
            //if (_CurrentControl == null) return;
            this.inputdata.Focus();
            PressHmi.View.Controls.Keyboard.Type(Key.Decimal);
            //_CurrentControl.Focus();
        }

        void RunCommand_BackSpace(object sender, ExecutedRoutedEventArgs e)
        {
            this.inputdata.Focus();
            PressHmi.View.Controls.Keyboard.Type(Key.Back);
        }
        #endregion
    }
}
