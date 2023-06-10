using Microsoft.AspNetCore.Mvc;
using Proyecto.Application.Services;
using Lab.Models.Grupo9;

namespace Grupo9.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EnviosController : Controller  
    {

        private readonly EnviosService _enviosService;

        public EnviosController(EnviosService enviosService) 
        {

            _enviosService = enviosService;

        }

        [HttpGet(Name = "GetEnvios")]
        public Task<Envio> Get()
        {
            return _enviosService.GetMiEnvio();
        }
    }
}
