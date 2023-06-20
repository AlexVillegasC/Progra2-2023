using Lab.Models.Grupo2;

namespace Infrastructure.Shared.Repositories;

public interface I_InventarioRepository
{
    Task<List<Frutas>> GetFrutas();
    Task<List<Bebidas>> GetBebidas();

}
