

using Infrastructure.Shared.Repositories;
using Lab.Models.GrupoHolaMundo;

namespace Proyecto.Application.Services;

public class AlquilerService
{
    private readonly IAlquilerRepository _alquilerRepository;

    public AlquilerService(IAlquilerRepository alquilerRepository) {
    
        _alquilerRepository = alquilerRepository;
    }

    public async Task<Alquiler> GetMyDatosAlquiler() {

        List<Casa> casas = await _alquilerRepository.GetCasas();
        List<Cliente> clientes = await _alquilerRepository.GetClientes();
        List<PaqueteInternet> paquetes = await _alquilerRepository.GetPaquetes();

        Alquiler alquiler = new Alquiler() {
            casa = casas,
            cliente = clientes,
            paquete = paquetes
        };

        foreach(var casa in casas) 
        {
            casa.calcularTotalBase(); 
        }

        return alquiler;
    }
}
