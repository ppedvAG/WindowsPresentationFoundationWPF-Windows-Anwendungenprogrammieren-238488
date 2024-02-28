using System.Reflection;
using System.Windows.Media;

namespace M008;

public class NamedColor
{
	public string Name { get; set; }

	public Color Color { get; set; }

	public SolidColorBrush ColorBrush => new SolidColorBrush(Color);
	
	public NamedColor(string name, Color color)
	{
		Name = name;
		Color = color;
	}

	public NamedColor(PropertyInfo info)
	{
		Name = info.Name;
		Color = (Color) info.GetValue(null);
	}
}