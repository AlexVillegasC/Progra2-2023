using Lab.Models.Grupo10;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Application.Services;

namespace Grupo10.API.Controllers
{
    
 [ApiController]
 [Route("[controller]")]
    public class ReportePlanillaController : Controller
    {
        private readonly ReportePlanillaService _reportePlanillaService;
        
        public ReportePlanillaController(ReportePlanillaService reportePlanillaService)
        {
            _reportePlanillaService = reportePlanillaService;
        }
    
        // GET
        [HttpGet(Name = "GetReportePlanilla")]
        
        public Task<ReportePlanilla> Get()
        {
            return _reportePlanillaService.GetReportePlanilla();
        }
    }
}