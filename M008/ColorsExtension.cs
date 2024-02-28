using System.Windows.Markup;
using System.Windows.Media;

namespace M008;

public class ColorsExtension : MarkupExtension
{
	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		//Colors hat nur Properties: Klasse voller Properties -> Colors[]/List<Color>

		//PropertyInfo[] colorProperties = typeof(Colors).GetProperties();
		//List<Color> colors = [];

		//foreach (PropertyInfo property in colorProperties)
		//{
		//	colors.Add((Color) property.GetValue(null));
		//}

		//return colors;

		return typeof(Colors).GetProperties()
			.Select(e => new NamedColor(e.Name, (Color) e.GetValue(null)))
			.ToList();
	}
}

/*
<ObjectDataProvider x:Key="Odp_Colors" MethodName="GetType" ObjectType="{x:Type sys:Type}">
	<ObjectDataProvider.MethodParameters>
		<sys:String>
			System.Windows.Media.Colors, PresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
		</sys:String>
	</ObjectDataProvider.MethodParameters>
</ObjectDataProvider>

<ObjectDataProvider x:Key="Odp_ColorsProperties" MethodName="GetProperties"	ObjectInstance="{StaticResource Odp_Colors}"/>
*/