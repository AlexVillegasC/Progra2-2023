using Lab.Models.Grupo5;

namespace Infrastructure.Shared.Repositories;

public interface ICancionesRepository
{

    Task<List<Album>> GetAlbums();
    Task<List<Artista>> GetArtistas();
    Task<List<Letra>> GetLetra();
}
