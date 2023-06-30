using Lab.Models.Grupo6;
using Infrastructure.Shared.Files;

namespace Infrastructure.Shared.Repositories;

public class EnviosGrupo6Repository : FileRepository, IEnviosGrupo6Repository
{
    private const string CliVirtualPath = "../Infrastructure.Shared/DB/grupo06-Clientes.Json";
    private const string CotVirtualPath = "../Infrastructure.Shared/DB/grupo06-Cotizaciones.Json";
    private const string SegVirtualPath = "../Infrastructure.Shared/DB/grupo06-Seguimientos.Json";

    public async Task<List<Lab.Models.Grupo6.Clientes>> GetClientes()
    {
       return await ReadJsonFileAsync<List<Lab.Models.Grupo6.Clientes>>(CliVirtualPath);
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

