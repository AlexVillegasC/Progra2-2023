
using Lab.Models.GrupoHolaMundo;

namespace Infrastructure.Shared.Repositories;

public interface IAlquilerRepository
{
    Task<List<Casa>> GetCasas();
    Task<List<Cliente>> GetClientes();
    Task<List<PaqueteInternet>> GetPaquetes();

}
