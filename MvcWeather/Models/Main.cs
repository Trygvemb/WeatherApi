using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MvcWeather.Models
{
    public class Main
    {
        [JsonProperty("temp")]
        public double Temp;

        [JsonProperty("feels_like")]
        public double FeelsLike;

        [JsonProperty("temp_min")]
        public int TempMin;

        [JsonProperty("temp_max")]
        public double TempMax;

        [JsonProperty("pressure")]
        public int Pressure;

        [JsonProperty("humidity")]
        public int Humidity;
    }
}