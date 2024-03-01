using System.Windows.Input;

namespace M018.Utility;

/// <summary>
/// Normalerweise würde für jedes Command eine eigene Klasse benötigt werden
/// CustomCommand speichert einfach einen Methodenzeiger für Execute und CanExecute und ruft diese einfach auf
/// </summary>
public class CustomCommand : ICommand
{
    //Action: Methodenzeiger der void zurückgibt
    //Func: Methodenzeiger der einen beliebigen Rückgabewert zurückgibt, das letzte Generic bestimmt den Rückgabetypen
    //Beide Delegates können bis zu 16 Parameter empfangen

    //In diesen beiden Variablen wird die Logik hinter den Methoden gespeichert
    private Action<object> execute;

    private Func<object, bool> canExecute;

    public CustomCommand(Action<object> execute, Func<object, bool> canExecute)
    {
        //Action<object> -> void Funktion(object o) { ... }
        //Func<object, bool> -> bool Funktion(object o) { ... }
        this.execute = execute;
        this.canExecute = canExecute;
    }

    public bool CanExecute(object? parameter) => canExecute(parameter);

    public void Execute(object? parameter) => execute(parameter);

    public event EventHandler? CanExecuteChanged;
}