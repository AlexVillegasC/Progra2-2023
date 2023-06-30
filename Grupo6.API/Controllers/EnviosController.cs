using Lab.Models.Grupo6;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Application.Services;

namespace Grupo6.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EnviosController : Controller
    {
        private readonly EnviosGrupo6Service _enviosService;
        public EnviosController(EnviosGrupo6Service enviosService) 
        {
            _enviosService = enviosService;
        }

        [HttpGet(Name = "GetEnvios")]
        public Task<Envios> Get()
        {
            return _enviosService.GetMyEnvios();
        }
    }
}
