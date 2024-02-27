using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace M006.Converter;

public class DoubleToMarginTopConverter : IValueConverter
{
	/// <summary>
	/// Source -> Target
	/// value: Wert, der vom Slider an den Button gesendet wird
	/// Rückgabewert: Der Wert, der auf der anderen Seite ankommen soll
	/// </summary>
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return new Thickness(0, (double) value, 0, 0); //Dieser Wert wird von dem Binding auf dem Button empfangen
	}

	//Ziel -> Quelle, kann hier leer bleiben
	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return null;
	}
}