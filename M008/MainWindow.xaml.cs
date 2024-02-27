using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M008;

public partial class MainWindow : Window
{
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