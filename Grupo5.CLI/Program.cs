
using Infrastructure.Shared.Files;
using Lab.Models.Grupo5;
using Newtonsoft.Json;
using System.Text.Json.Nodes;   

Canciones GetMyCanciones()
{
    var virtualPath = "../../../../Infrastructure.Shared/DB/Grupo5-Album.json";
    var ArtistavirtualPath = "../../../../Infrastructure.Shared/DB/Grupo5-Artista.json";
    FileRepository fileRepo = new FileRepository();

    //string albumsJson = fileRepo.ReadJsonFileAsync<string>(virtualPath).Result;
    List<Album> albums = fileRepo.ReadJsonFileAsync<List<Album>>(virtualPath).Result;
    List<Artista> artistas = fileRepo.ReadJsonFileAsync<List<Artista>>(ArtistavirtualPath).Result;


    Canciones canciones = new Canciones();
    canciones.Albums = albums;
    canciones.Artistas = artistas;
    return canciones;

}

Canciones canciones = GetMyCanciones();

foreach (var Album in canciones.Albums)
{
    Console.WriteLine(Album.NombreAlbum);
}

foreach (var Artista in canciones.Artistas)
{
    Console.WriteLine(Artista.NombreArtista);
}

/*foreach (var Letra in canciones.Albums)
{
    Console.WriteLine(Letra.NombreAlbum);
}

*/