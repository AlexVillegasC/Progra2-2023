
using Infrastructure.Shared.Files;
using Lab.Models.Grupo5;

namespace Infrastructure.Shared.Repositories;

public class CancionesRepository : FileRepository, ICancionesRepository
{
    private const string AlbumVirtualPath = "../Infrastructure.Shared/DB/Grupo5-Album.json";
    private const string ArtistaVirtualPath = "../Infrastructure.Shared/DB/Grupo5-Artista.json";
   /* private const string LetraVirtualPatch = "../../../../Infrastructure.Shared/DB/Grupo5-Letra.json";*/

    public async Task<List<Album>> GetAlbums()

    { 
        return await ReadJsonFileAsync<List<Album>>(AlbumVirtualPath);
    }

    public async Task<List<Artista>> GetArtistas()
    {
        return await ReadJsonFileAsync<List<Artista>>(ArtistaVirtualPath);
    }

   
}
     