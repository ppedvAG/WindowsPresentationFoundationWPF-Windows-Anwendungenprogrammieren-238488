using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;

namespace M009.Validation;

public class ValidationRuleBindingExtension : MarkupExtension
{
	private Binding b;

	/// <summary>
	/// Hier muss das Binding, zu dem gebunden werden soll, mitgegeben werden
	/// </summary>
    public ValidationRuleBindingExtension(Binding b, ValidationRuleCollection rules)
    {
		foreach (ValidationRule rule in rules)
		{
			b.ValidationRules.Add(rule);
		}

		this.b = b;
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
	{
		//Hier wird das Binding ausgeführt
		//UI -> Binding -> Backend
		//         ↑
		//   MarkupExtension

		//Wenn wir nicht ProvideValue machen würden, würde im Backend ein Objekt vom Typ Binding ankommen
		//Hier wird der Wert hinter dem Binding entnommen
		return b.ProvideValue(serviceProvider);
	}
}

public class ValidationRuleCollection : Collection<ValidationRule> { }