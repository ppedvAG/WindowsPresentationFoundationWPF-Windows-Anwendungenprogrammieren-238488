using System.Windows.Markup;

namespace M001;

public class GenericExtension : MarkupExtension
{
	private object[] values;

	public Type OriginalType { get; set; }

	public Type WrapperType { get; set; }

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		return values ??= OriginalType.GetType()
			.GetProperties()
			.Select(e => Activator.CreateInstance(WrapperType, e))
			.ToArray();
	}
}