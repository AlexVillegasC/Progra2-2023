

using Lab.Models.Grupo5;

Canciones GetMyCanciones()
{

}
Canciones canciones = GetMyCanciones();

foreach (var Album in canciones.Albums)
{
    Console.WriteLine(Album.NombreAlbum);
}

