using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using MauiAPIWeather.Models;
using MauiAPIWeather.Models.ApiModels;
using MauiAPIWeather.ViewModels;

namespace MauiAPIWeather.Services
{
    internal class WeatherApiService
    {
        private readonly HttpClient _httpClient;
        public WeatherApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Constants.API_BASE_URL);
        }

        //declare Task<WeatherApiResponse?> as nullable
        public async Task<WeatherApiResponse?> GetWeatherInformation(string latitude, string longitude)
        {
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
                return null;

            //https://api.weatherbit.io/v2.0/current?lat=39.58&lon=-104.87&key=XXXXXXXXX
            return await _httpClient.GetFromJsonAsync<WeatherApiResponse>($"current?lat={latitude}&lon={longitude}&key={Constants.API_KEY}");
        }
    }
}
