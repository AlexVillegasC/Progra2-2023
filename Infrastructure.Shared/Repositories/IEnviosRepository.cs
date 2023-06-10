using Lab.Models.Grupo9;

namespace Infrastructure.Shared.Repositories
{
    public interface IEnviosRepository
    {

        Task<List<Lab.Models.Grupo9.Cliente>> GetCliente();

        Task<List<Status>> GetStatus();

        Task<List<Paquete>> GetPaquete();

    }
}
