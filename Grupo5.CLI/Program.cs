
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

Console.WriteLine("----------Lista de Albums----------");
Console.WriteLine("");

foreach (var Album in canciones.Albums)
{
    Console.WriteLine("Album: "+Album.NombreAlbum);
}
Console.WriteLine("");
Console.WriteLine("----------Lista de Artistas----------");
Console.WriteLine("");
foreach (var Artista in canciones.Artistas)
{
    Console.WriteLine("Artista: "+Artista.NombreArtista);
}
Console.WriteLine("");
Console.WriteLine("----------Lista de Letras----------");
Console.WriteLine("");

var le = 1;
foreach (var Letra in canciones.Letras)
{
    Console.WriteLine("Letra "+le+": "+Letra.Contenido);
    Console.WriteLine("");
    le = le +1;
}

