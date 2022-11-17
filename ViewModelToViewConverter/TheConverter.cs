using System.Globalization;

namespace ViewModelToViewConverter;

public class TheConverter : IValueConverter
{
    public static TheConverter Instance { get; } = new();

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        string title = (string)value;

        if (title == "View1")
            return new TheView();
        else
            return new View2();
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
