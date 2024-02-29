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

namespace M015;

public partial class MainWindow : Window
{
	public ExitCommand Exit { get; set; } = new();

	public CheckBoxCommand Check { get; set; } = new();

	public CustomCommand Custom { get; set; }

	public MainWindow()
	{
		Custom = new CustomCommand(ProgrammBeenden, KannBeenden); //Referenzen auf Methoden

		InitializeComponent();
		//Custom = new CustomCommand(o => Environment.Exit(0), o => true); //Selbiges wie eine Zeile darüber, aber anonym
	}

	private void Button_Click(object sender, RoutedEventArgs e) { }

	//Hier werden jetzt die Methoden abgelegt, die an das Command angehängt werden
	public void ProgrammBeenden(object o)
	{
		Environment.Exit(0);
	}

	public bool KannBeenden(object o)
	{
		return true;
	}
}