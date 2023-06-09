using Lab.Models.GrupoGamma;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Application.Services;

namespace GrupoGamma.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpresaController : Controller
    {
        private readonly EmpresaService _empresaService;

        public EmpresaController(EmpresaService empresaService) 
        {
            _empresaService = empresaService;
        }

        [HttpGet(Name = "GetEmpresa")]
        public Task<Empresa> Get()
        {
            return _empresaService.getMyEmpresa();
        }
    }
}
