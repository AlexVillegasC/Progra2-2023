
using Lab.Models.Grupo3;

namespace Infrastructure.Shared.Repositories;

public interface ICelularRepository
{
     Task<List<Bateria>> GetBaterias();

     Task<List<Memoria>> GetMemorias();
}
