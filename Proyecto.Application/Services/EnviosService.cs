using Infrastructure.Shared.Repositories;
using Lab.Models.Grupo6;

namespace Proyecto.Application.Services;

public class EnviosService
{
    private readonly IEnviosRepository _enviosRepository;

    public EnviosService(IEnviosRepository enviosRepository)
    {
        _enviosRepository = enviosRepository;
    }

    public async Task<Envios> GetMyEnvios()
    {
        List<Clientes> clientes = await _enviosRepository.GetClientes();

        Envios envios = new Envios()
        {
            Clientes = clientes
        };
    
      
        return envios; 
    }
}
