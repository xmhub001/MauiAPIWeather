namespace MauiAPIWeather.Pages;

public partial class WeatherInfoPage : ContentPage
{
	public WeatherInfoPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		System.Diagnostics.Debug.Print("clicked");
    }
}