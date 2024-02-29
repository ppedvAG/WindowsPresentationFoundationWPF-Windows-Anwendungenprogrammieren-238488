using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M011;

//Wenn zwischen den XML Tags ein Wert steht, wird dieser in das angegebene Property geschrieben
[ContentProperty(nameof(PickedColor))]
public partial class ColorPicker : UserControl
{
	public ColorPicker() => InitializeComponent();

	//propdp + Tab
	public Color PickedColor
	{
		get => (Color) GetValue(PickedColorProperty); //Ermöglicht, Beschreiben und Auslesen von DPs
		set
		{
			//SliderAValue = value.A;
			//SliderRValue = value.R;
			//SliderGValue = value.G;
			//SliderBValue = value.B;
			SetValue(PickedColorProperty, value); //Get-/SetValue sind globale Methoden, die von DependencyObject vererbt werden auf alle Komponenten in WPF
		}
	}

	/// <summary>
	/// Hier wird dieses Property auf dem globalen DP-Manager registriert
	/// </summary>
	public static readonly DependencyProperty PickedColorProperty =
		DependencyProperty.Register
		(
			nameof(PickedColor), //Der Name des Properties
			typeof(Color), //Der Typ des Properties
			typeof(ColorPicker), //Der Typ des Parents des Properties
								 //Einstellungen zu dem DP vornehmen mithilfe von new PropertyMetadata(...)
			new FrameworkPropertyMetadata(Color.FromArgb(255, 0, 0, 0)) //Der Standardwert
			//Weitere Einstellungen: Code, der vor oder nach dem setzen des DP passieren soll
		);



	public int SliderRValue
	{
		get => (int) GetValue(SliderRValueProperty);
		set => SetValue(SliderRValueProperty, value);
	}

	public static readonly DependencyProperty SliderRValueProperty =
		DependencyProperty.Register(nameof(SliderRValue), typeof(int), typeof(ColorPicker), new PropertyMetadata(0));


	public int SliderGValue
	{
		get => (int) GetValue(SliderGValueProperty);
		set => SetValue(SliderGValueProperty, value);
	}

	public static readonly DependencyProperty SliderGValueProperty =
		DependencyProperty.Register(nameof(SliderGValue), typeof(int), typeof(ColorPicker), new PropertyMetadata(0));


	public int SliderBValue
	{
		get => (int) GetValue(SliderBValueProperty);
		set => SetValue(SliderBValueProperty, value);
	}

	public static readonly DependencyProperty SliderBValueProperty =
		DependencyProperty.Register(nameof(SliderBValue), typeof(int), typeof(ColorPicker), new PropertyMetadata(0));


	public int SliderAValue
	{
		get => (int) GetValue(SliderAValueProperty);
		set => SetValue(SliderAValueProperty, value);
	}

	public static readonly DependencyProperty SliderAValueProperty =
		DependencyProperty.Register(nameof(SliderAValue), typeof(int), typeof(ColorPicker), new PropertyMetadata(255));

	private void ColorSlider_PickedColorChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		TB.Text = "Value: " + e.NewValue;
	}
}