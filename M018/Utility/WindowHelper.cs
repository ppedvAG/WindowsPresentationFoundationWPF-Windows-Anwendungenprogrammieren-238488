using M018.View;
using M018.ViewModel;

namespace M018.Utility;

public static class WindowHelper
{
	public static void OpenHelpPage(string x)
	{
		HelpPage hp = new();
		HelpPageVM viewModel = hp.DataContext as HelpPageVM;
		viewModel.HelpID = x;
		hp.Show();
	}
}