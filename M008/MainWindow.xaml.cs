using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace M008;

public partial class MainWindow : Window
{
	public Person p { get; set; } = new() { Lieblingsfarbe = Colors.Pink };

	public ObservableCollection<Person> Personen { get; } = new();

	public MainWindow()
	{
		InitializeComponent();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		Personen.Add(new Person() { FirstName = Random.Shared.Next().ToString(), LastName = Random.Shared.Next().ToString(), Email = Random.Shared.Next().ToString() });
	}
}