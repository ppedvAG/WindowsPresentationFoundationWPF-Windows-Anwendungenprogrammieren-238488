using System.Globalization;
using System.IO;
using System.Windows.Data;

namespace M018;

public class PathExpander : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null)
			return Array.Empty<object>();

		string pfad = (string) value;
		return parameter != null ? Directory.GetFiles(pfad) : (object) Directory.GetDirectories(pfad);
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => null;
}