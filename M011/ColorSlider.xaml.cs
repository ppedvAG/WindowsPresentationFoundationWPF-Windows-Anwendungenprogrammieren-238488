using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M011;

public partial class ColorSlider : UserControl
{
	public ColorSlider() => InitializeComponent();



	public int SliderValue
	{
		get { return (int) GetValue(SliderValueProperty); }
		set { SetValue(SliderValueProperty, value); }
	}

	public static readonly DependencyProperty SliderValueProperty =
		DependencyProperty.Register("SliderValue", typeof(int), typeof(ColorSlider), new PropertyMetadata(0));




	public string ColorText
	{
		get { return (string) GetValue(ColorTextProperty); }
		set { SetValue(ColorTextProperty, value); }
	}

	// Using a DependencyProperty as the backing store for ColorText.  This enables animation, styling, binding, etc...
	public static readonly DependencyProperty ColorTextProperty =
		DependencyProperty.Register("ColorText", typeof(string), typeof(ColorSlider), new PropertyMetadata(""));





	public Brush SliderColor
	{
		get { return (Brush) GetValue(SliderColorProperty); }
		set { SetValue(SliderColorProperty, value); }
	}

	// Using a DependencyProperty as the backing store for SliderColor.  This enables animation, styling, binding, etc...
	public static readonly DependencyProperty SliderColorProperty =
		DependencyProperty.Register("SliderColor", typeof(Brush), typeof(ColorSlider), new PropertyMetadata(new SolidColorBrush(Colors.Black)));


	//Events weitergeben, wie DP, aber mit Events
	public event RoutedPropertyChangedEventHandler<double> PickedColorChanged
	{
		add { AddHandler(PickedColorChangedEvent, value); }
		remove { RemoveHandler(PickedColorChangedEvent, value); }
	}

	public static readonly RoutedEvent PickedColorChangedEvent =
		EventManager.RegisterRoutedEvent
		(
			nameof(PickedColorChanged),
			RoutingStrategy.Direct,
			typeof(RoutedPropertyChangedEventHandler<double>),
			typeof(ColorSlider)
		);

}