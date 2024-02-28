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

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		MessageBox.Show(p.Lieblingsfarbe.ToString());
	}
}