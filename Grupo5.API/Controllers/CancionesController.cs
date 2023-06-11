using Lab.Models.Grupo5;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Application.Services;

namespace Grupo5.API.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class CancionesController : Controller
    {
        private readonly CancionesService _cancionesService;

        public CancionesController(CancionesService cancionesService)
        {
            _cancionesService = cancionesService;
        }

        [HttpGet(Name = "GetCanciones")]
        public Task<Canciones> Get()
        {
            return _cancionesService.GetMyCanciones();

        }
    }
}

