using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MauiAPIWeather.ViewModels; //is this needed?

namespace MauiAPIWeather.Models.ApiModels
{
    public class WeatherApiResponse
    {
        //WeatherApiResponseRootobject
        [JsonPropertyName("weatherApiResponseRootobject")]
        public WeatherApiResponseRootobject WeatherApiResponseRootobject { get; set; }
        //WeatherApiResponseDatum
        [JsonPropertyName("weatherApiResponseDatum")]
        public WeatherApiResponseDatum WeatherApiResponseDatum { get; set; }
        //WeatherApiResponseWeather
        [JsonPropertyName("weatherApiResponseWeather")]
        public WeatherApiResponseWeather WeatherApiResponseWeather { get; set; }
    }


    public class WeatherApiResponseRootobject
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }
        [JsonPropertyName("data")]
        public WeatherApiResponseDatum[] Data { get; set; }
    }

    public class WeatherApiResponseDatum
    {
        [JsonPropertyName("app_temp")]
        public float App_temp { get; set; }
        [JsonPropertyName("aqi")]
        public int Aqi { get; set; }
        [JsonPropertyName("city_name")]
        public string City_name { get; set; }
        [JsonPropertyName("clouds")]
        public int Clouds { get; set; }
        [JsonPropertyName("country_code")]
        public string Country_code { get; set; }
        [JsonPropertyName("datetime")]
        public string Datetime { get; set; }
        [JsonPropertyName("dewpt")]
        public float Dewpt { get; set; }
        [JsonPropertyName("dhi")]
        public int Dhi { get; set; }
        [JsonPropertyName("dni")]
        public int Dni { get; set; }
        [JsonPropertyName("elev_angle")]
        public float Elev_angle { get; set; }
        [JsonPropertyName("ghi")]
        public int Ghi { get; set; }
        [JsonPropertyName("gust")]
        public object Gust { get; set; }
        [JsonPropertyName("h_angle")]
        public int H_angle { get; set; }
        [JsonPropertyName("lat")]
        public float Lat { get; set; }
        [JsonPropertyName("lon")]
        public float Lon { get; set; }
        [JsonPropertyName("ob_time")]
        public string Ob_time { get; set; }
        [JsonPropertyName("pod")]
        public string Pod { get; set; }
        [JsonPropertyName("precip")]
        public int Precip { get; set; }
        [JsonPropertyName("pres")]
        public float Pres { get; set; }
        [JsonPropertyName("rh")]
        public int Rh { get; set; }
        [JsonPropertyName("slp")]
        public int Slp { get; set; }
        [JsonPropertyName("snow")]
        public int Snow { get; set; }
        [JsonPropertyName("solar_rad")]
        public int Solar_rad { get; set; }
        [JsonPropertyName("sources")]
        public string[] Sources { get; set; }
        [JsonPropertyName("state_code")]
        public string State_code { get; set; }
        [JsonPropertyName("station")]
        public string Station { get; set; }
        [JsonPropertyName("sunrise")]
        public string Sunrise { get; set; }
        [JsonPropertyName("sunset")]
        public string Sunset { get; set; }
        [JsonPropertyName("temp")]
        public float Temp { get; set; }
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }
        [JsonPropertyName("ts")]
        public int Ts { get; set; }
        [JsonPropertyName("uv")]
        public int Uv { get; set; }
        [JsonPropertyName("vis")]
        public int Vis { get; set; }
        [JsonPropertyName("weather")]
        public WeatherApiResponseWeather Weather { get; set; }
        [JsonPropertyName("wind_cdir")]
        public string Wind_cdir { get; set; }
        [JsonPropertyName("wind_cdir_full")]
        public string Wind_cdir_full { get; set; }
        [JsonPropertyName("wind_dir")]
        public int Wind_dir { get; set; }
        [JsonPropertyName("wind_spd")]
        public float Wind_spd { get; set; }
    }

    public class WeatherApiResponseWeather
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

}
