using Infrastructure.Shared.Files;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Progra2.Grupo0.Models;

namespace Progra2.Grupo0.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoistureController : ControllerBase
    {
        private readonly IFileRepository _FileRepository;

        public MoistureController(IFileRepository fileRepository)
        {
            _FileRepository = fileRepository;            
        }

        [HttpGet(Name = "GetMoisturetWeatherCondition")]
        public async Task<IEnumerable<Moisture>> Get()
        {
            var json = await _FileRepository.ReadJsonFileAsync<Moisture>("../../DB/grupo0-moisture.json");
            return JsonConvert.DeserializeObject<List<Moisture>>(json);
        }
    }
}