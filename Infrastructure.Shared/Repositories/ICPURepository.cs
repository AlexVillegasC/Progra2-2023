
using Lab.Models.Grupo4;

namespace Infrastructure.Shared.Repositories;

public interface ICPURepository
{
    Task<List<Case>> GetCase();
    Task<List<Almacenamiento>> GetAlmacenamiento();
    Task<List<T_Grafica>> GetT_Grafica();
}
