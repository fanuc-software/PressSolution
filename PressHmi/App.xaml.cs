using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using GalaSoft.MvvmLight.Threading;
using PressHmi.App_Start;

namespace PressHmi
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            DispatcherHelper.Initialize();
            IocConfig.Register();

            //加载语言
            List<ResourceDictionary> dictionaryList = new List<ResourceDictionary>();
            foreach (ResourceDictionary dictionary in Application.Current.Resources.MergedDictionaries)
            {
                dictionaryList.Add(dictionary);
            }
            //string requestedCulture = @"pack://application:,,,/PressHmi;component/View/Resources/zh-cn.xaml";
            //ResourceDictionary resourceDictionary = dictionaryList.FirstOrDefault(d => d.Source.OriginalString.Equals(requestedCulture));
            //Application.Current.Resources.MergedDictionaries.Remove(resourceDictionary);
            //Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);

            //加载色彩
            string requestedColorCulture = @"pack://application:,,,/PressHmi;component/View/Color/dark.xaml";
            ResourceDictionary resourceColorDictionary = dictionaryList.FirstOrDefault(d => d.Source.OriginalString.Equals(requestedColorCulture));
            Application.Current.Resources.MergedDictionaries.Remove(resourceColorDictionary);
            Application.Current.Resources.MergedDictionaries.Add(resourceColorDictionary);

            //加载字体
            string requestedFontCulture = @"pack://application:,,,/PressHmi;component/View/Size/normal.xaml";
            ResourceDictionary resourceFontDictionary = dictionaryList.FirstOrDefault(d => d.Source.OriginalString.Equals(requestedFontCulture));
            Application.Current.Resources.MergedDictionaries.Remove(resourceFontDictionary);
            Application.Current.Resources.MergedDictionaries.Add(resourceFontDictionary);

            Application.Current.StartupUri = new Uri("View/MainWindow.xaml", UriKind.Relative);

        }
    }
}
