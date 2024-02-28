using System.ComponentModel;
using System.Windows.Media;

namespace M011;

public class Person : INotifyPropertyChanged, IDataErrorInfo
{
	private string firstName;

	public string FirstName
	{
		get => firstName;
		set
		{
			firstName = value;
			Notify(nameof(FirstName));
		}
	}

	public string LastName { get; set; }

	private string email = "";

	public string Email
	{
		get => email;
		set
		{
			if (!value.Contains('@'))
			{
				throw new Exception("Email Adresse muss ein @-Zeichen enthalten!");
			}
			email = value;
		}
	}

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

	/// <summary>
	/// Kann ignoriert werden
	/// </summary>
	public string Error => throw new NotImplementedException();

	/// <summary>
	/// Indexer: Mit einem Indexer kann ein Objekt mit [] angegriffen werden
	/// z.B. List, Dictionary, Array haben alle einen Indexer
	/// </summary>
	public string this[string propertyName]
	{
		get
		{
			//Fehlermeldungen werden hier über return zurückgegeben
			//return null: Keine Fehler
			switch (propertyName)
			{
				case nameof(FirstName):
					if (!FirstName.All(char.IsLetter))
						return "Jedes Zeichen muss ein Buchstabe sein!";
					if (FirstName.Length < 3 || FirstName.Length > 15)
						return "Vorname muss zwischen 3 und 15 Zeichen haben!";
					return null;

				case nameof(Email):
					if (!Email.Contains('@'))
						return "Email muss ein @ enthalten!";
					return null;
			}
			return null;
		}
	}

	public event PropertyChangedEventHandler? PropertyChanged;

	public void Notify(string prop) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
}