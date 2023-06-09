using Infrastructure.Shared.Repositories;
using Lab.Models.Grupo7;

namespace Proyecto.Application.Services;

public class PrestamoService
{
    private readonly IPrestamoRepository _prestamoRepository;


    public PrestamoService(IPrestamoRepository prestamoRepository)
    {
         _prestamoRepository = prestamoRepository;
    }

    public async Task<Prestamos> ListaPrestamo()
    {
        List<Libro> libros = await _prestamoRepository.GetLibros();
        List<Cliente> clientes = await _prestamoRepository.GetClientes();
        List<Tarifa> tarifas = await _prestamoRepository.GetTarifas();


        Prestamos Prestamo = new Prestamos()
        {
            Libros = libros,
            Clientes = clientes,
            Tarifas = tarifas
        };

        return Prestamo;
    }
}
