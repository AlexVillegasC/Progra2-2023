using Lab.Models.Grupo6;
using Infrastructure.Shared.Files;

namespace Infrastructure.Shared.Repositories;

public class EnviosRepository : FileRepository, IEnviosRepository
{
    private const string CliVirtualPath = "../Infrastructure.Shared/DB/grupo06-Clientes.Json";
    private const string CotVirtualPath = "../Infrastructure.Shared/DB/grupo06-Cotizaciones.Json";
    private const string SegVirtualPath = "../Infrastructure.Shared/DB/grupo06-Seguimientos.Json";

    public async Task<List<Cliente>> GetClientes()
    {
       return await ReadJsonFileAsync<List<Cliente>>(CliVirtualPath);
    }

    public async Task<List<Seguimiento>> GetSeguimientos()
    {
        return await ReadJsonFileAsync<List<Seguimiento>>(SegVirtualPath);
    }
    public async Task<List<Cotizaciones>> GetCotizaciones()
    {
        return await ReadJsonFileAsync<List<Cotizaciones>>(CotVirtualPath);
    }
}

