using Infrastructure.Shared.Repositories;
using Lab.Models.Grupo9;

namespace Proyecto.Application.Services;

public class EnviosService
{

    private readonly IEnviosRepository _enviosRepository;


    public EnviosService(IEnviosRepository enviosRepository)
    {
        _enviosRepository = enviosRepository;

    }

    public async Task<Envio>GetMiEnvio() 
    {
        List <Lab.Models.Grupo9.Cliente> clientes = await _enviosRepository.GetCliente();
        List<Status> statuses = await _enviosRepository.GetStatus();
        List<Paquete> paquetes = await _enviosRepository.GetPaquete();

        Envio envio = new Envio()
        {
            Clientes = clientes,
            Statuses = statuses,
            Paquetes = paquetes



        };

        return envio;

    }
}
