using Infrastructure.Shared.Files;
using Lab.Models.Grupo7;

namespace Infrastructure.Shared.Repositories;

public class PrestamoRepository : FileRepository, IPrestamoRepository
{
    private const string libroVirtualPath = "../Infrastructure.Shared/DB/grupo7-Libro.json";
    private const string tarifavirtualPath = "../Infrastructure.Shared/DB/grupo7-Tarifa.json";
    private const string clientevirtualPath = "../Infrastructure.Shared/DB/grupo7-Cliente.json";

    public async Task<List<Libro>> GetLibros() 
    {
        return await ReadJsonFileAsync<List<Libro>>(libroVirtualPath);
    }

    public async Task<List<Tarifa>> GetTarifas()
    {
        return await ReadJsonFileAsync<List<Tarifa>>(tarifavirtualPath);
    }

    public async Task<List<Cliente>> GetClientes()
    {
        return await ReadJsonFileAsync<List<Cliente>>(clientevirtualPath);
    }
}
