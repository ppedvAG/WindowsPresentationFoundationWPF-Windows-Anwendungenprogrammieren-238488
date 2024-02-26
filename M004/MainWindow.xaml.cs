using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace M004;

public partial class MainWindow : Window
{
	//Normales C# Property
	public int Alter { get; set; }

	//C# Property + DependencyProperty darunter
	public int Zaehler
	{
		get { return (int) GetValue(ZaehlerProperty); }
		set { SetValue(ZaehlerProperty, value); }
	}

	// Using a DependencyProperty as the backing store for Zaehler.  This enables animation, styling, binding, etc...
	public static readonly DependencyProperty ZaehlerProperty =
		DependencyProperty.Register("Zaehler", typeof(int), typeof(MainWindow), new PropertyMetadata(0));



	public MainWindow()
	{
		InitializeComponent();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		BindingExpression ex = Eingabe.GetBindingExpression(TextBox.TextProperty);
		ex.UpdateTarget();
	}
}