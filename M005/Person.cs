using System.ComponentModel;

namespace M005;

public class Person : INotifyPropertyChanged
{
	//Jedes Property in der Klasse muss jetzt ein Full Property (private Feld + public Property)
	//In dem Property muss jetzt Notify verwendet werden
	private string vorname;

	public string Vorname
	{
		get => vorname;
		set
		{
			vorname	= value;
			Notify(nameof(Vorname));
		}
	}

	private string nachname;

	public string Nachname
	{
		get => nachname;
		set
		{
			nachname = value;
			Notify(nameof(Nachname));
		}
	}

	private int alter;

	public int Alter
	{
		get => alter;
		set
		{
			alter = value;
			Notify(nameof(Alter));
		}
	}

	/// <summary>
	/// Wird automatisch von der GUI angehängt
	/// Kann aufgerufen werden, um eine Benachrichtigung zu verursachen
	/// </summary>
	public event PropertyChangedEventHandler? PropertyChanged;

	public void Notify(string prop) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
}