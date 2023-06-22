
using Infrastructure.Shared.Files;
using Lab.Models.Grupo4;

namespace Infrastructure.Shared.Repositories;

public class CPURepository : FileRepository, ICPURepository
{
    private const string virtualpathcase = "../Infrastructure.Shared/DB/Grupo4-Case.json";
    private const string PathStorage = "../Infrastructure.Shared/DB/Grupo4-Almacenamiento.json";
    private const string PathGraph = "../Infrastructure.Shared/DB/Grupo4-T_Grafica.json";

    public async Task<List<Case>> GetCase()
    {
       return await ReadJsonFileAsync<List<Case>>(virtualpathcase);
    }

    public async Task<List<Almacenamiento>> GetAlmacenamiento()
    {
        return await ReadJsonFileAsync<List<Almacenamiento>>(PathStorage);
    }

    public async Task<List<T_Grafica>> GetT_Grafica()
    {
        return await ReadJsonFileAsync<List<T_Grafica>>(PathGraph);
    }
}
