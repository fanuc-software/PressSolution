using System;
using System.Windows.Data;
using System.Globalization;

namespace PressHmi.View.Converters
{
    [ValueConversion(typeof(int), typeof(string))]
    public class MainStatusEmgColorConverter : IValueConverter
    {
        public object Convert(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            int temp = (int)value;

            byte bd = (byte)(0x01 << 2);
            var bit = (temp & bd) > 0;

            if (bit == true) return "Red";
            else return "Gray";
        }
        //反转换方法，将字符串转换为日期类型
        public object ConvertBack(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
