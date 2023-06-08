using Lab.Models.Grupo0;
using Microsoft.AspNetCore.Mvc;
using Proyecto.ApplicationLayer.Services;

namespace WebApplication1Ignore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherSummaryController : Controller
    {

        private readonly WeatherSummaryService _weatherService;

        public WeatherSummaryController(WeatherSummaryService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public Task<WeatherSummary> Get()
        {
            return _weatherService.GetMySummaryAsync();
        }
    }
}
