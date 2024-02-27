using System.Windows;
using System.Windows.Data;

namespace M007;

public partial class MainWindow : Window
{
	public DayOfWeek[] Wochentage { get; } = Enum.GetValues<DayOfWeek>();

	public MainWindow()
	{
		InitializeComponent();
		CB.ItemsSource = Enum.GetValues<DayOfWeek>(); //Nicht MVVM konform
	}
}