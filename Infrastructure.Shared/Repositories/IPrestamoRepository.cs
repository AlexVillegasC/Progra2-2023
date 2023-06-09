using Lab.Models.Grupo7;

namespace Infrastructure.Shared.Repositories;

public interface IPrestamoRepository
{
    Task<List<Libro>> GetLibros();
    Task<List<Tarifa>> GetTarifas();
    Task<List<Cliente>> GetClientes();
}
