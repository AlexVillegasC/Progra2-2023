using Infrastructure.Shared.Files;
using Lab.Models.Grupo10;

namespace Infrastructure.Shared.Repositories;

public class ReporteRepository : FileRepository, IReporteRepository
{
    private string Empleadovirtualpath = "../Infrastructure.Shared/DB/grupo10-Empleado.json";

    public async Task<List<Empleado>> GetEmpleados()
    {
        return await ReadJsonFileAsync<List<Empleado>>(Empleadovirtualpath);
    }
}
