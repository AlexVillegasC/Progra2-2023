namespace Infrastructure.Shared.Repositories;

public interface IEnviosRepository
{
    Task<List<Cliente>> GetClientes();
}
