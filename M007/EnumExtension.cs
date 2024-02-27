using System.Windows.Markup;

namespace M007;

public class EnumExtension : MarkupExtension
{
	private Type enumType;

	public Type EnumType { get; set; }

    public EnumExtension(Type enumType)
    {
		if (!enumType.IsEnum)
			return;

		this.enumType = enumType;
    }

    public EnumExtension() { }

    /// <summary>
    /// ProvideValue: Methode, die dem unterlegenden Property (das gebundene Property) seinen Wert gibt
    /// z.B. Binding mit converter: Beim Converter wird per return der Wert zurückgegeben, welcher beim Binding in das Property gelegt werden soll
    /// -> Transporter, welcher den Wert auf die andere Seite befördert
    /// </summary>
    public override object ProvideValue(IServiceProvider serviceProvider)
	{
		//Null-Coaslescing Operator (??): Nimm die linke Seite wenn die linke Seite nicht null ist, sonst nimm die rechte Seite
		return Enum.GetValues(enumType ?? EnumType);
		//return Enum.GetValues(enumType != null ? enumType : EnumType); //Selbiges wie darüber
	}
}