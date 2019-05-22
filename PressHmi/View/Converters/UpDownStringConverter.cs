using System;
using System.Windows.Data;
using System.Globalization;

namespace PressHmi.View.Converters
{

    [ValueConversion(typeof(double?), typeof(string))]
    public class UpDownStringConverter : IValueConverter
    {
        public object Convert(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            double? temp = (double?)value;
            if (!temp.HasValue) return null;

            if (temp.Value > 0) return "&#xf062;";
            if (temp.Value < 0) return "&#xf063;";
            else return "一致";
        }
        //反转换方法，将字符串转换为日期类型
        public object ConvertBack(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
