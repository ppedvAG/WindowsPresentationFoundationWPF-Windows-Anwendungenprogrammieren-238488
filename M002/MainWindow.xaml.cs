using System.Net;
using System.Windows;
using System.Windows.Controls;

namespace M002;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();
		CB.ItemsSource = Enum.GetValues<HttpStatusCode>();
		LB.ItemsSource = Enum.GetValues<HttpStatusCode>();

		//IEnumerable
		//Anleitung zum Erstellen der Liste
		Enumerable.Range(0, 100); //0-99
		Enumerable.Range(0, 1_000_000_000); //Nur eine Anleitung (1ms)
		//Enumerable.Range(0, 1_000_000_000).ToList(); //ToList() erzeugt tatsächlich/iteriert die Collection
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{

	}

	private void CheckBox_Checked(object sender, RoutedEventArgs e)
	{

	}

	private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
	{

	}

	private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		TB.Text = (sender as Slider).Value.ToString();
	}

	private void MenuItem_Click(object sender, RoutedEventArgs e)
	{

	}
}