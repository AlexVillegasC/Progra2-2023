using Lab.Models.Grupo0;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Application.Services;

namespace Grupo0.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherSummaryController : Controller
    {
        private readonly WeatherSummaryService _weatherSummaryService;

        public WeatherSummaryController(WeatherSummaryService weatherSummaryService) 
        {
            _weatherSummaryService = weatherSummaryService;
        }

        [HttpGet(Name = "GetWeatherSummary")]
        public Task<WeatherSummary> Get()
        {
            return _weatherSummaryService.GetMySummary();
        }
    }
}
