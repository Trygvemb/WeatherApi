using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeather.Models
{
    public class Forecast
    {
        public DateAndTime dt { get; set; }
        public Main main { get; set; }
        public List<Weather> weathers { get; set; }
    }
}