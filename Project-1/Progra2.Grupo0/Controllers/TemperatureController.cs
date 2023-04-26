using Infrastructure.Shared.Files;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Progra2.Grupo0.Models;

namespace Progra2.Grupo0.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemperatureController : ControllerBase
    {
        private readonly IFileRepository _FileRepository;

        public TemperatureController(IFileRepository fileRepository)
        {
            _FileRepository = fileRepository;            
        }

        [HttpGet(Name = "GetTemperatureWeatherCondition")]
        public async Task<IEnumerable<Temperature>> Get()
        {
            var json = await _FileRepository.ReadJsonFileAsync<Temperature>("../../DB/grupo0-temperature.json");
            return JsonConvert.DeserializeObject<List<Temperature>>(json);
        }
    }
}