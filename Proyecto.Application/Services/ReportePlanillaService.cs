using Infrastructure.Shared.Repositories;
using Lab.Models.Grupo10;

namespace Proyecto.Application.Services;

public class ReportePlanillaService
{
    private readonly IReporteRepository _reporteRepository;

    public ReportePlanillaService(IReporteRepository reporteRepository)
    {
        _reporteRepository = reporteRepository;
    }

    public async Task<ReportePlanilla> GetEmpleados()
    {
        List<Empleado> empleados = await _reporteRepository.GetEmpleados();
        
        ReportePlanilla reportePlanilla = new ReportePlanilla()
        {
            Empleados = empleados
        };
        return reportePlanilla;
    }
}