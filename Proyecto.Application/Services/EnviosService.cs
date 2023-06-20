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
        List<Lab.Models.Grupo6.Clientes> clientes = await _enviosRepository.GetClientes();
        List<Seguimiento> seguimientos = await _enviosRepository.GetSeguimientos();
        List<Cotizaciones> cotizaciones = await _enviosRepository.GetCotizaciones();
        Envios envios = new Envios()
        {
            Clientes = clientes,
            Seguimientos = seguimientos,
            Cotizaciones = cotizaciones
        };
    
      
        return envios; 
    }
}
