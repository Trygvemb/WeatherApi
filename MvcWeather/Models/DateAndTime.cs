using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MvcWeather.Models
{
    public class DateAndTime
    {
         [JsonProperty("dt")]
        public int dt;

        public DayOfWeek Date => DateTime.UnixEpoch.AddSeconds(dt).DayOfWeek;
        public string Time => DateTime.UnixEpoch.AddSeconds(dt).ToShortTimeString();
    }
}