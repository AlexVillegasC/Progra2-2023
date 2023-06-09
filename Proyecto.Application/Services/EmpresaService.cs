

using Infrastructure.Shared.Repositories;
using Lab.Models.GrupoGamma;

namespace Proyecto.Application.Services;

public class EmpresaService
{
    private readonly IEmpresaRepository _empresaRepository;

    public EmpresaService(IEmpresaRepository empresaRepository)
    {
        _empresaRepository = empresaRepository;
    }

public async Task<Empresa> getMyEmpresa()
    {
        List<Software> software = await _empresaRepository.GetSoftware();
        List<Lab.Models.GrupoGamma.Cliente> cliente = await _empresaRepository.GetCliente();
        List<Empleado> empleado = await _empresaRepository.GetEmpleado();


        Empresa empresa = new Empresa()
        {
            Software = software,
            Cliente = cliente,
            Empleado = empleado
        };

        return empresa; 
    }
}
