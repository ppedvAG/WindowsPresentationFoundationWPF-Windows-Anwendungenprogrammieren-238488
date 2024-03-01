using M014.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace M014;

public partial class MainWindow : Window
{
	private NorthwindContext db;

	public BindableProperty<List<Type>> TableNames { get; set; } = new();

	public BindableProperty<IListSource> CurrentTable { get; set; } = new();

	public MainWindow()
	{
		InitializeComponent();
		db = new NorthwindContext();

		TableNames.Value = db
			.GetType()
			.GetProperties()
			.Where(e => e.PropertyType.IsGenericType)
			.Select(e => e.PropertyType.GetGenericArguments()[0])
			.ToList();
	}

	private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		ComboBox self = sender as ComboBox;
		//CurrentTable.Value = db.GetType().GetProperties().First(e => e.Name == self.SelectedItem.ToString()).GetValue(db) as IListSource;

		db.Find((Type) self.SelectedItem);
	}
}