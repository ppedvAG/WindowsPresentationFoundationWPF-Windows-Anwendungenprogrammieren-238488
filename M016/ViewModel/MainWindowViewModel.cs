using M016.Model;
using M016.Utility;
using System.Collections.ObjectModel;

namespace M016.ViewModel;

/// <summary>
/// MVVM
/// Trennung von Model-View und ViewModel
/// Model: Datenklassen (ohne Logik)
/// View: GUI (XAML)
/// ViewModel: Logik zwischen View und Model
/// 
/// Für jede GUI wird hier ein ViewModel angelegt und dieses wird per DataContext in der View eingebunden
/// </summary>
public class MainWindowViewModel : ViewModelBase
{
	private NorthwindContext db;

	public ObservableCollection<Customer> Daten { get; set; } = new();

	public CustomCommand CustomerLaden { get; set; }

	public MainWindowViewModel()
	{
		db = new();

		CustomerLaden = new CustomCommand(DatenLaden, o => true);
	}

	public void DatenLaden(object o)
	{
		foreach (Customer c in db.Customers)
			Daten.Add(c);
	}
}