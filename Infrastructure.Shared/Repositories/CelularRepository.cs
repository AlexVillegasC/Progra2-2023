
using Infrastructure.Shared.Files;
using Lab.Models.Grupo3;

namespace Infrastructure.Shared.Repositories;

public class CelularRepository   : FileRepository, ICelularRepository
{
    private const string Bateriavirtualpath = "../Infrastructure.Shared/DB/grupo3-bateria.json";
    private const string Memoriavirtualpath = "../Infrastructure.Shared/DB/grupo3-memoria.json";

    public async Task<List<Bateria>> GetBaterias()
    {
        return await ReadJsonFileAsync<List<Bateria>>(Bateriavirtualpath);
    }

    public async Task<List<Memoria>> GetMemorias()
    {
        return await ReadJsonFileAsync<List<Memoria>>(Memoriavirtualpath);
    }
}
