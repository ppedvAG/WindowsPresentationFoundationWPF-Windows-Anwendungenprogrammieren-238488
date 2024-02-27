using System.Collections.ObjectModel;
using System.Windows;

namespace M005;

public partial class MainWindow : Window
{
	public Person p { get; set; } = new Person() { Vorname = "Max", Nachname = "Mustermann", Alter = 33 };

	public BindableProperty<int> x { get; set; } = new();

	/// <summary>
	/// ObservableCollection: List, die INotifyPropertyChanged für uns Implementiert, und bei Listenänderungen (Add, Remove, ...) aufruft
	/// </summary>
	public ObservableCollection<int> Zahlen { get; set; } = new();

	public MainWindow()
	{
		InitializeComponent();
		//this.DataContext = this; //Hier kann das Fenster als DataContext sich selbst empfangen
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		//Das neue Alter wird in der GUI nicht angezeigt -> Benachrichtigung fehlt
		//Um Benachrichtigungen zu ermöglichen benötigen wir das INotifyPropertyChanged Interface
		
		//Interface auf Person: Reagiert auf Änderungen innerhalb der Person
		//Interface auf MainWindow: Reagiert auf Zuweisungen auf die p Variable selbst, aber nicht auf Änderungen innerhalb von p
		p.Alter++;

		x.Value = Random.Shared.Next();

		Zahlen.Add(Random.Shared.Next());
	}
}