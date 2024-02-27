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

namespace M006;

public partial class MainWindow : Window
{
	public static double Test { get; set; } = 100.0;

	public MainWindow()
	{
		InitializeComponent();
		Wochentage.ItemsSource = Enum.GetValues<DayOfWeek>();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		Resources["FontSize"] = 60.0;
	}
}