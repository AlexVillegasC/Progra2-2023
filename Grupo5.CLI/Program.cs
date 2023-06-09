
using Infrastructure.Shared.Files;
using Lab.Models.Grupo5;
using Newtonsoft.Json;
using System.Text.Json.Nodes;   

Canciones GetMyCanciones()
{
    var AlbumVirtualPath = "../../../../Infrastructure.Shared/DB/Grupo5-Album.json";
    var ArtistaVirtualPath = "../../../../Infrastructure.Shared/DB/Grupo5-Artista.json";
    var LetraVirtualPatch = "../../../../Infrastructure.Shared/DB/Grupo5-Letra.json";
    FileRepository fileRepo = new FileRepository();

    //string albumsJson = fileRepo.ReadJsonFileAsync<string>(virtualPath).Result;
    List<Album> albums = fileRepo.ReadJsonFileAsync<List<Album>>(AlbumVirtualPath).Result;
    List<Artista> artistas = fileRepo.ReadJsonFileAsync<List<Artista>>(ArtistaVirtualPath).Result;
    List<Letra> letras = fileRepo.ReadJsonFileAsync<List<Letra>>(LetraVirtualPatch).Result;

    Canciones canciones = new Canciones();
    canciones.Albums = albums;
    canciones.Artistas = artistas;
    canciones.Letras = letras;
    return canciones;

}

Canciones canciones = GetMyCanciones();

foreach (var Album in canciones.Albums)
{
    Console.WriteLine("Album: "+Album.NombreAlbum);
}

foreach (var Artista in canciones.Artistas)
{
    Console.WriteLine("Artista: "+Artista.NombreArtista);
}

foreach (var Letra in canciones.Letras)
{
    Console.WriteLine("letra: "+Letra.Contenido);
}

