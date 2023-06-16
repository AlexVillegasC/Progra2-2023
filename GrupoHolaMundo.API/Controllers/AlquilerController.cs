using Lab.Models.GrupoHolaMundo;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Application.Services;

namespace GrupoHolaMundo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlquilerController : Controller
    {
        private readonly AlquilerService _alquilerService;
        public AlquilerController(AlquilerService alquilerService) {
        
            _alquilerService = alquilerService;
        }

        [HttpGet(Name = "GetAlquiler")]
        public Task<Alquiler> Get()
        {
            return _alquilerService.GetMyDatosAlquiler();
        }
    }
}
