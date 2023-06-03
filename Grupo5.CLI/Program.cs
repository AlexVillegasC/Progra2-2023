
using Infrastructure.Shared.Files;
using Lab.Models.Grupo5;
using Newtonsoft.Json;
using System.Text.Json.Nodes;   

Canciones GetMyCanciones()
{
    var virtualPath = "../../../../Infrastructure.Shared/DB/Grupo5-Album.json";
    FileRepository fileRepo = new FileRepository();

    //string albumsJson = fileRepo.ReadJsonFileAsync<string>(virtualPath).Result;
    List<Album> albums = fileRepo.ReadJsonFileAsync<List<Album>>(virtualPath).Result;


    Canciones canciones = new Canciones();
    canciones.Albums = albums;
    return canciones;

}

Canciones canciones = GetMyCanciones();

foreach (var Album in canciones.Albums)
{
    Console.WriteLine(Album.NombreAlbum);
}


