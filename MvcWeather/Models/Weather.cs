using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MvcWeather.Models
{
    public class Weather
    {
        [JsonProperty("id")]
        public int Id;

        [JsonProperty("main")]
        public string Main;

        [JsonProperty("description")]
        public string Description;

        [JsonProperty("icon")]
        public string Icon;
    }
}