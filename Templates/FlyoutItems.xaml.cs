namespace ProjetDevTest.Templates;

public partial class FlyoutItems : ContentView
{
	public FlyoutItems()
	{
		InitializeComponent();
	}

	public static readonly BindableProperty IconProperty = 
		BindableProperty.Create(nameof(Icon), typeof(string), typeof(FlyoutItems));

    public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(nameof(Title), typeof(string), typeof(FlyoutItems));

	public string Icon
	{
		get => (string)GetValue(IconProperty);
		set => SetValue(IconProperty, value);
	}

	public string Title
	{
		get => (string)GetValue(TitleProperty);
		set => SetValue(TitleProperty, value);
	}
}