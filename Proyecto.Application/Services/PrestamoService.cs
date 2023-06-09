using Lab.Models.Grupo7;

namespace Proyecto.Application.Services;

public class PrestamoService
{
    private readonly IPrestamoRepository _prestamoRepository;


    public PrestamoService(IPrestamoRepository prestamoRepository)
    {
         _prestamoRepository = prestamoRepository;
    }

    public async Task<Prestamo> ListaPrestamo()
    {
        List<Libro> Libros = await _prestamoRepository.GetLibros();
        List<Libro> Clientes = await _prestamoRepository.GetClientes();
        List<Libro> Tarifas = await _prestamoRepository.GetTarifas();


        Prestamo Prestamo = new Prestamo()
        {
            Libros = Libros,
            Clientes = Clientes,
            Tarifas = Tarifas
        };

        return Prestamo;
    }
}
