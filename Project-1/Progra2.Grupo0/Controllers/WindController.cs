using Infrastructure.Shared.Files;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Progra2.Grupo0.Models;

namespace Progra2.Grupo0.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WindController : ControllerBase
    {
        private readonly IFileRepository _FileRepository;

        public WindController(IFileRepository fileRepository)
        {
            _FileRepository = fileRepository;            
        }

        [HttpGet(Name = "GetWindForecast")]
        public async Task<IEnumerable<Wind>> Get()
        {
            var json = await _FileRepository.ReadJsonFileAsync<Wind>("../../DB/grupo0-wind.json");
            return JsonConvert.DeserializeObject<List<Wind>>(json);
        }
    }
}