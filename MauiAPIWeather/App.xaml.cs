using MauiAPIWeather.Pages;

namespace MauiAPIWeather
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new WeatherInfoPage();
        }
    }
}
