using M013.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.IO;
using System.Windows;

namespace M013;

public partial class MainWindow : Window
{
	public ObservableCollection<KundenUmsatz> Daten { get; set; } = new();

	private NorthwindContext db;

	public MainWindow() => InitializeComponent();

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		//Requirements: DB Treiber für die entsprechende Datenbank
		SqlConnection conn = new SqlConnection("Data Source=WIN10-LK3;Initial Catalog=Northwind;Integrated Security=True;Encrypt=False");
		conn.Open(); //DB Verbindung öffnen

		//Command erstellen (SQL-Statement)
		SqlCommand command = conn.CreateCommand();
		command.CommandText = "SELECT * FROM Customers";

		//Command ausführen
		//Bei mehreren Datensätzen: ExecuteReader
		//Bei einzelnen Ergebnissen (z.B. COUNT(*)): ExecuteScalar, ExecuteNonQuery
		SqlDataReader reader = command.ExecuteReader();
		while (reader.Read())
		{
			//object[] values = new object[reader.VisibleFieldCount]; //Hier muss ein object[] angelegt werden, welches die Werte empfangen soll
			//reader.GetValues(values);
			//Daten.Add(new Customer(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), 
			//	reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10)));
		}
	}

	private async void Button_Click_1(object sender, RoutedEventArgs e)
	{
		//EntityFramework
		//Object Relational Mapper, welcher den SQL Teil komplett von dem C# Code trennt

		//Wir haben in unserem Code DbSets die mit Linq verarbeitet werden können
		//Diese Linq Statements werden zu SQL übersetzt und an die Datenbank geschickt
		//Die Datensätze kommen dann als C# Klassen zu uns zurück

		//Requirements:
		//Microsoft.EntityFrameworkCore
		//Microsoft.EFCore.SqlServer

		//Optional:
		//EFCore Power Tools (VS Extension)
		//Microsoft.EntityFrameworkCore.Tools
		//Microsoft.EntityFrameworkCore.Design

		//Erstellte Klassen:
		//Model Klassen -> Stellen die SQL-Tabellen als C# Objekte dar
		//Context Klasse -> Stellt den DB-Connector dar, enthält DbSets die mit Linq verarbeitet werden können
		db ??= new();
		Daten.Clear();
		//foreach (Customer c in db.Customers.Where(e => e.Country == "UK")) //SELECT * FROM Customers WHERE Country == "UK"
		//	Daten.Add(c);

		//Daten laden + ProgressBar befüllen
		//int anz = db.KundenUmsatzs.Take(50000).Count(); //SELECT TOP 50000 COUNT(*) FROM KundenUmsatz
		PB.Value = 0;
		PB.Maximum = 50000;

		//foreach (KundenUmsatz ku in db.KundenUmsatzs.Take(50000))
		//{
		//	Daten.Add(ku);
		//	PB.Value++;
		//}

		//async/await
		//Operationen die lange dauern, freezen die UI
		//-> Aller Code wird standardmäßig auf dem Main Thread ausgeführt
		//Die GUI wird auch auf dem Main Thread ausgeführt
		//Die GUI wird blockiert

		//Wenn eine Async Methode gestartet wird, wird diese Parallel gestartet
		//Mit await kann dann auch das Ergebnis dieser Aufgabe gewartet werden

		//async und await erzeugen nicht blockierende Operationen
		//Lade einen Datensatz und warte auf diesen
		//Wenn dieser DS geladen ist, füge in das DataGrid ein
		//Wiederholen
		await foreach (KundenUmsatz ku in db.KundenUmsatzs.Take(50000).AsAsyncEnumerable())
		{
			Daten.Add(ku);
			PB.Value++;
		}

		//Warte auf alle Datensätze, und verarbeite sie dann
		foreach (KundenUmsatz ku in await db.KundenUmsatzs.Take(50000).ToListAsync())
		{
			Daten.Add(ku);
			PB.Value++;
		}
	}

	public async Task<Wrapper[]> GetData()
	{
		return await Task.Run(() =>
		{
			string[] x = Directory.GetFiles("C:\\", "*", SearchOption.AllDirectories);
			Wrapper[] w = x.Select(e => new Wrapper(e)).ToArray();
			return w;
		});
	}

	private void Button_Click_2(object sender, RoutedEventArgs e)
	{
		Wrapper[] x = GetData().Result;
	}
}

public record Wrapper(string x);