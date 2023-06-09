

using Lab.Models.GrupoGamma;

namespace Infrastructure.Shared.Repositories;

public interface IEmpresaRepository
{
    Task<List<Software>> GetSoftware();

    Task<List<Empleado>> GetEmpleado();

    Task<List<Lab.Models.GrupoGamma.Cliente>> GetCliente();


}
