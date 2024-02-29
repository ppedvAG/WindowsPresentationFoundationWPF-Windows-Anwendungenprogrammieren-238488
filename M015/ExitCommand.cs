using System.Windows.Input;

namespace M015;

public class ExitCommand : ICommand
{
	public bool CanExecute(object? parameter) => true;

	public void Execute(object? parameter) => Environment.Exit(0);

	public event EventHandler? CanExecuteChanged;
}