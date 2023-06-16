using Lab.Models.GrupoHolaMundo;
using Microsoft.AspNetCore.Mvc;

namespace GrupoHolaMundo.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AlquilerController : Controller
    {
        public AlquilerController() { 
        }

        [HttpGet(Name = "GetAlquiler")]
        public Task<Alquiler> Get()
        {
            return null;
        }
    }
}
