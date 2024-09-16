using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
//using EventKit;
using MauiAPIWeather.Services;

namespace MauiAPIWeather.ViewModels
{
    public partial class WeatherInfoPageViewModel : ObservableObject
    {
        private readonly WeatherApiService _weatherApiService;

        public WeatherInfoPageViewModel()
        {
            _weatherApiService = new WeatherApiService();
            /*Latitude = "39.58";
            Longitude = "-104.87";
            _ = FetchWeatherInformation();*/
        }

        [ObservableProperty]
        private string latitude; //lat
        [ObservableProperty]
        private string longitude; //lon
        [ObservableProperty]
        private string weatherIcon; //weather; icon
        [ObservableProperty]
        private string temperature; //temp
        [ObservableProperty]
        private string weatherDescription; //weather; description
        [ObservableProperty]
        private string location; //city_name
        [ObservableProperty]
        private string humidity; //dewpt
        [ObservableProperty]
        private string cloudCoverLevel; //clouds
        [ObservableProperty]
        private string isDay; //date_time

        [RelayCommand]
        public async Task ExternalFetchWeatherInformation()
        {
            // Latitude and Longitude is from WeatherInfoPageViewModel
            var weatherApiResponse = await _weatherApiService.GetWeatherInformation(Latitude, Longitude);
            if (weatherApiResponse != null)
            {
                WeatherIcon = weatherApiResponse.WeatherApiResponseWeather.Icon;
                Temperature = $"weatherApiResponse.WeatherApiResponseDatum.Temp.ToString()°C";
                Location = weatherApiResponse.WeatherApiResponseDatum.City_name;
                WeatherDescription = weatherApiResponse.WeatherApiResponseWeather.Description;
                Humidity = weatherApiResponse.WeatherApiResponseDatum.Dewpt.ToString();
                CloudCoverLevel = $"weatherApiResponse.WeatherApiResponseDatum.Clouds.ToString()%";
                IsDay = weatherApiResponse.WeatherApiResponseDatum.Datetime.ToString();
            }
        }
    }

}
