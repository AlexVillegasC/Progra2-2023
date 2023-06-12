using Infrastructure.Shared.Files;
using Lab.Models.Grupo10;

namespace Infrastructure.Shared.Repositories;

public class ReporteRepository : FileRepository, IReporteRepository
{
    private string Empleadovirtualpath = "../Infrastructure.Shared/DB/grupo10-Empleado.json";
    private const string DepartamentovirtualPath = "../Infrastructure.Shared/DB/grupo10-Departamento.json";
    private const string SalariovirtualPath = "../Infrastructure.Shared/DB/grupo10-Salario.json";

    public async Task<List<Empleado>> GetEmpleados()
    {
        return await ReadJsonFileAsync<List<Empleado>>(Empleadovirtualpath);
    }

    public async Task<List<Departamento>> GetDepartamento()
    {
        return await ReadJsonFileAsync<List<Departamento>>(DepartamentovirtualPath);
        
    }

    public async Task<List<Salario>> GetSalario()
    {
        return await ReadJsonFileAsync<List<Salario>>(SalariovirtualPath);
    }


}


