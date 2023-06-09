

using System.Reflection.Metadata;
using Infrastructure.Shared.Files;
using Lab.Models.GrupoGamma;

namespace Infrastructure.Shared.Repositories;

public class EmpresaRepository : FileRepository, IEmpresaRepository
{
    public const string SoftwarevirtualPhat = "../Infrastructure.Shared/DB/grupoGamma-Software.json";
    public const string ClientevirtualPhat = "../Infrastructure.Shared/DB/grupoGamma-Clientes.json";
    public const string EmpleadovirtualPhat = "../Infrastructure.Shared/DB/grupoGamma-Empleado.json";


    public async Task<List<Software>> GetSoftware()
    {
        return await ReadJsonFileAsync<List<Software>>(SoftwarevirtualPhat);

    }

    public async Task<List<Lab.Models.GrupoGamma.Cliente>> GetCliente()
    {
        return await ReadJsonFileAsync<List<Lab.Models.GrupoGamma.Cliente>>(ClientevirtualPhat);
    }

    public async Task<List<Empleado>> GetEmpleado()
    {
        return await ReadJsonFileAsync<List<Empleado>>(EmpleadovirtualPhat);

    }
}
