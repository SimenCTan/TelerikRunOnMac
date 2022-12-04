using System.Globalization;

namespace ViewModelToViewConverter;

public class TheConverter : IValueConverter
{
    public static TheConverter Instance { get; } = new();

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        string title = (string)value;

        if (title == "ParentView1")
        {
            return new ParentContentView(title);
        }
        else if (title == "ParentView2")
        {
            return new ParentContentView2(title);
        }
        else if (title == "View1")
            return new TheView();
        else if (title == "View2")
            return new View2();
        else 
        {
            throw new NotImplementedException();
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
