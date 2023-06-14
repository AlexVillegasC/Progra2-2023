using Infrastructure.Shared.Files;
using Lab.Models.Grupo2;

namespace Infrastructure.Shared.Repositories;

public class InventarioRepository : FileRepository, I_InventarioRepository
{
    private const string FrutasVirtualPath = "../Infrastructure.Shared/DB/Grupo02-Frutas.json";
    private const string BebidasVirtualPath = "../Infrastructure.Shared/DB/Grupo02-Bebidas.json";

    public async Task<List<Frutas>> GetFrutas()
    {
        return await ReadJsonFileAsync<List<Frutas>>(FrutasVirtualPath);
    }

    public async Task<List<Bebidas>> GetBebidas()
    {
        return await ReadJsonFileAsync<List<Bebidas>>(BebidasVirtualPath);
    }


}
