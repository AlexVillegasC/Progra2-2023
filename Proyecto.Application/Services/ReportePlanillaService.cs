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
        List<Departamento> departamentos = await _reporteRepository.GetDepartamento();
        List<Salario> salarios = await _reporteRepository.GetSalario();

        ReportePlanilla reportePlanilla = new ReportePlanilla()

        {
            Empleados = empleados,
            departamentos = departamentos,
            salarios= salarios
            
        };
        return reportePlanilla;
    }
}