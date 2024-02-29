using System.Windows.Controls;
using System.Windows.Input;

namespace M015;

public class CheckBoxCommand : ICommand
{
	public bool CanExecute(object? parameter)
	{
		if (parameter is CheckBox cb)
			return cb.IsChecked.Value;
		return false;
	}

	public void Execute(object? parameter)
	{
		
	}

	public event EventHandler? CanExecuteChanged;
}