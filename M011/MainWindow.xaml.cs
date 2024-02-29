using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M011;

public partial class MainWindow : Window
{
	public Person p { get; set; } = new() { Lieblingsfarbe = Color.FromArgb(12, 23, 34, 45) };

	public MainWindow() => InitializeComponent();

	#region EventRouting
	//KeyDown ist ein Bubbling Event (von innen nach außen)
	private void Window_KeyDown(object sender, KeyEventArgs e) => Title += "W";

	private void StackPanel_KeyDown(object sender, KeyEventArgs e) => Title += "S";

	private void Button_KeyDown(object sender, KeyEventArgs e) => Title += "B";


	//Click ist ein Bubbling Event (von innen nach außen)
	private void Window_Click(object sender, RoutedEventArgs e) => Title += "W";

	private void StackPanel_Click(object sender, RoutedEventArgs e) => Title += "S";

	//MessageBox.Show(p.Lieblingsfarbe.ToString());
	private void Button_Click(object sender, RoutedEventArgs e) => Title += "B";

	//MouseDown ist ein Bubbling Event (von innen nach außen)
	private void Window_MouseDown(object sender, MouseButtonEventArgs e) => Title += "W";

	private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e) => Title += "S";

	private void Button_MouseDown(object sender, MouseButtonEventArgs e) => Title += "B";
	#endregion
}