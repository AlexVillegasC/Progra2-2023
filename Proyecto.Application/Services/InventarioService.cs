
using Infrastructure.Shared.Repositories;
using Lab.Models.Grupo2;

namespace Proyecto.Application.Services;

public class InventarioService
{
    private readonly I_InventarioRepository _InventarioRepository ;


    public InventarioService(I_InventarioRepository InventarioRepository)
    {
        _InventarioRepository = InventarioRepository;
    }

    public async Task<Inventario> GetMyInventario()
    { 
        List<Frutas> frutas = await _InventarioRepository.GetFrutas();
        List<Bebidas> bebidas = await _InventarioRepository.GetBebidas();



        Inventario inventario = new Inventario()
        {
            Frutas = frutas,
            Bebidas = bebidas
        };

        return inventario;
    }
}