using M018.Utility;

namespace M018.ViewModel;

public class MainWindowVM : ViewModelBase
{
	public string RootPath { get; } = "Test";

	public CustomCommand HelpCommand { get; set; }

    public MainWindowVM()
    {
		HelpCommand = new CustomCommand(p => WindowHelper.OpenHelpPage(p.ToString()), p => true);
    }
}