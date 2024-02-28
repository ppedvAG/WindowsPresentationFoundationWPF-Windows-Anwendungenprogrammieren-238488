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

namespace M009;

public partial class MainWindow : Window
{
	public Person p { get; set; } = new() { FirstName = "123", LastName = "" };

	public MainWindow()
	{
		InitializeComponent();
	}
}