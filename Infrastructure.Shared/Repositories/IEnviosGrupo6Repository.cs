using Lab.Models.Grupo6;

namespace Infrastructure.Shared.Repositories;

public interface IEnviosGrupo6Repository
{
    Task<List<Lab.Models.Grupo6.Clientes>> GetClientes();
    Task<List<Seguimiento>> GetSeguimientos();
    Task<List<Cotizaciones>> GetCotizaciones();
}
