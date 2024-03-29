﻿using System.ComponentModel;

namespace M018.Utility;

public class BindableProperty<T> : INotifyPropertyChanged
{
	private T _value;

	public T Value
	{
		get => _value;
		set
		{
			_value = value;
			Notify(nameof(Value));
		}
	}

	public event PropertyChangedEventHandler? PropertyChanged;

	public void Notify(string prop) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
}