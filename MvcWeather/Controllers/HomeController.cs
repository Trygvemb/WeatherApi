using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using MvcWeather.Models;


namespace MvcWeather.Controllers;

public class HomeController : Controller
{
    private static HttpClient _httpClient;

    public HomeController()
    {
        _httpClient = new HttpClient();
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public async Task<string> GetStringAsync(string city)
    {
        string apiKey = "653912153a71c74890bef39355554678";

        var URl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";

        var response = await _httpClient.GetAsync(URl);

        return await response.Content.ReadAsStringAsync();
    }

    [Route("Home/WeatherForecast")]
    public async Task<IActionResult> WeatherForecast([FromQuery]string city)
    {
        if (string.IsNullOrEmpty(city))
        {
            return View();
        }

        string apiKey = "653912153a71c74890bef39355554678";
        string units = "metric";

        var URl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units={units}";

        var response = await _httpClient.GetAsync(URl);
        var responseContent = await response.Content.ReadAsStringAsync();

        WeatherViewModel? weatherForecast =
                JsonSerializer.Deserialize<WeatherViewModel>(responseContent);

        return View(weatherForecast);
    }


}
