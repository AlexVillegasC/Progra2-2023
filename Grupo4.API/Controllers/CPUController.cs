using Lab.Models.Grupo4;
using Microsoft.AspNetCore.Mvc;

namespace Grupo4.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CPUController : Controller
    {
        public CPUController() 
        { 
           
        }

        [HttpGet(Name = "GetCPU")]
        public Task<CPU> Get()
        {
            return null;
        }
    }
}
