using Lab.Models.Grupo6;

namespace Infrastructure.Shared.Repositories;

public interface IEnviosRepository
{
    Task<List<Clientes>> GetClientes();
    Task<List<Seguimiento>> GetSeguimientos();
    Task<List<Cotizaciones>> GetCotizaciones();
}
