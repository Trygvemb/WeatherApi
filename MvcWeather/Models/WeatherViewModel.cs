using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MvcWeather.Models
{
    public class WeatherViewModel
    {
        [JsonProperty("dt")]
        [JsonPropertyName("dt")]
        public int Dt { get; set; }

        [JsonProperty("main")]
        [JsonPropertyName("main")]
        public Main Main { get; set; }

        [JsonProperty("weather")]
        [JsonPropertyName("weather")]
        public List<Weather> Weather { get; set; }

        [JsonProperty("clouds")]
        [JsonPropertyName("clouds")]
        public Clouds Clouds { get; set; }

        [JsonProperty("wind")]
        [JsonPropertyName("wind")]
        public Wind Wind { get; set; }

        [JsonProperty("visibility")]
        [JsonPropertyName("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("pop")]
        [JsonPropertyName("pop")]
        public double Pop { get; set; }

        [JsonProperty("rain")]
        [JsonPropertyName("rain")]
        public Rain Rain { get; set; }

        [JsonProperty("sys")]
        [JsonPropertyName("sys")]
        public Sys Sys { get; set; }

        [JsonProperty("dt_txt")]
        [JsonPropertyName("dt_txt")]
        public string DtTxt { get; set; }
    }

    public class Clouds
    {
        [JsonProperty("all")]
        [JsonPropertyName("all")]
        public int All { get; set; }
    }

    public class Main
    {
        [JsonProperty("temp")]
        [JsonPropertyName("temp")]
        public double Temp { get; set; }

        [JsonProperty("feels_like")]
        [JsonPropertyName("feels_like")]
        public double FeelsLike { get; set; }

        [JsonProperty("temp_min")]
        [JsonPropertyName("temp_min")]
        public double TempMin { get; set; }

        [JsonProperty("temp_max")]
        [JsonPropertyName("temp_max")]
        public double TempMax { get; set; }

        [JsonProperty("pressure")]
        [JsonPropertyName("pressure")]
        public int Pressure { get; set; }

        [JsonProperty("sea_level")]
        [JsonPropertyName("sea_level")]
        public int SeaLevel { get; set; }

        [JsonProperty("grnd_level")]
        [JsonPropertyName("grnd_level")]
        public int GrndLevel { get; set; }

        [JsonProperty("humidity")]
        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("temp_kf")]
        [JsonPropertyName("temp_kf")]
        public double TempKf { get; set; }
    }

    public class Rain
    {
        [JsonProperty("3h")]
        [JsonPropertyName("3h")]
        public double _3h { get; set; }
    }

    public class Root
    {
        [JsonProperty("list")]
        [JsonPropertyName("list")]
        public List<WeatherViewModel> List { get; set; }
    }

    public class Sys
    {
        [JsonProperty("pod")]
        [JsonPropertyName("pod")]
        public string Pod { get; set; }
    }

    public class Weather
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("main")]
        [JsonPropertyName("main")]
        public string Main { get; set; }

        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }

    public class Wind
    {
        [JsonProperty("speed")]
        [JsonPropertyName("speed")]
        public double Speed { get; set; }

        [JsonProperty("deg")]
        [JsonPropertyName("deg")]
        public int Deg { get; set; }

        [JsonProperty("gust")]
        [JsonPropertyName("gust")]
        public double Gust { get; set; }
    }


}
