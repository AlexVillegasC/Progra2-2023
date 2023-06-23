using Lab.Models.Grupo4;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Application.Services;

namespace Grupo4.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CPUController : Controller
    {
        private readonly CPUService _cPUService;
        //private CPUService _CPUService;

        public CPUController(CPUService cPUService) 
        {
            _cPUService = cPUService;
        }

        [HttpGet(Name = "GetCPU")]
        public Task<CPU> Get()
        {
            return _cPUService.GetCPU();        
        }
    }
}
