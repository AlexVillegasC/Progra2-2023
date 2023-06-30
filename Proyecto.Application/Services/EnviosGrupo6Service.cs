using Infrastructure.Shared.Repositories;
using Lab.Models.Grupo6;

namespace Proyecto.Application.Services;

public class EnviosGrupo6Service
{
    private readonly IEnviosGrupo6Repository _enviosRepository;

    public EnviosGrupo6Service(IEnviosGrupo6Repository enviosRepository)
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
