
using Infrastructure.Shared.Files;
using Lab.Models.GrupoHolaMundo;

namespace Infrastructure.Shared.Repositories;
public class AlquilerRepository : FileRepository, IAlquilerRepository
{
    private const string casasVirtualPath = "../../../../Infrastructure.Shared/DB/grupoHolaMundo-casas.json";
    private const string clientesVirtualPath = "../../../../Infrastructure.Shared/DB/grupoHolaMundo-clientes.json";
    private const string paquetesVirtualPath = "../../../../Infrastructure.Shared/DB/grupoHolaMundo-paquetes.json";

    public async Task<List<Casa>> GetCasas() {

        return await ReadJsonFileAsync<List<Casa>>(casasVirtualPath);
    }

    public async Task<List<Cliente>> GetClientes()
    {

        return await ReadJsonFileAsync<List<Cliente>>(clientesVirtualPath);
    }

    public async Task<List<PaqueteInternet>> GetPaquetes()
    {

        return await ReadJsonFileAsync<List<PaqueteInternet>>(paquetesVirtualPath);
    }
}

