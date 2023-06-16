using Infrastructure.Shared.Repositories;
using Lab.Models.Grupo5;

namespace Proyecto.Application.Services;

public class CancionesService
{

    private readonly ICancionesRepository _cancionesRepository;

    public CancionesService (ICancionesRepository cancionesRepository)
    {
    _cancionesRepository = cancionesRepository;
    }

    public async Task<Canciones> GetMyCanciones()
    {

        List<Album> albums = await _cancionesRepository.GetAlbums();
        List<Artista> artistas = await _cancionesRepository.GetArtistas();
        List<Letra> letras = await _cancionesRepository.GetLetra();


        Canciones canciones = new Canciones()
        {
            Albums = albums,
            Artistas = artistas,
            Letras = letras
        };

        return canciones;
    }
}
