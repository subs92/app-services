using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Web.Models;

namespace MyCompany.Web.Controllers;

public class HomeController : Controller
{
    private readonly WeatherService _weatherService;

    public HomeController(WeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _weatherService.GetWeatherAsync();
        ViewBag.ApiData = data;
        return View();
    }
}
