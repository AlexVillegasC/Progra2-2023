using Lab.Models.Grupo3;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Application.Services;

namespace Grupo3.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]


    public class CelularController : Controller
    {
        private readonly CelularService _celularService;

        public CelularController(CelularService celularService) 
        { 
            _celularService = celularService;
        }  

        [HttpGet(Name = "GetCelular")]

        public Task<Celular> Get()
        {
            return _celularService.GetMyCelular();
        }
    }
}
