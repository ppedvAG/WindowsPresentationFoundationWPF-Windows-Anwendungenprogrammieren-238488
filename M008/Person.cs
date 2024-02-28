using System.ComponentModel;
using System.Windows.Media;

namespace M008;

public class Person : INotifyPropertyChanged
{
	public string FirstName { get; set; }

	public string LastName { get; set; }

	public string Email { get; set; }

	private Color _lieblingsfarbe;

	public Color Lieblingsfarbe
	{
		get => _lieblingsfarbe;
		set
		{
			_lieblingsfarbe = value;
			Notify(nameof(Lieblingsfarbe));
		}
	}

	public event PropertyChangedEventHandler? PropertyChanged;

	public void Notify(string prop) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
}