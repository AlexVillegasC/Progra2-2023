using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Models.Grupo5;


class Canciones
{
    private List<string> listaCanciones = new List<string>();
    private List<Album> listaAlbums = new List<Album>();
    private List<Artista> listaArtistas = new List<Artista>();
    private List<Letra> listaLetras = new List<Letra>();

    public void AgregarCancion(string nombreCancion, Album album, Artista artista, Letra letra)
    {
        listaCanciones.Add(nombreCancion);
        listaAlbums.Add(album);
        listaArtistas.Add(artista);
        listaLetras.Add(letra);
    }

    public void VerListaCanciones()
    {
        for (int i = 0; i < listaCanciones.Count; i++)
        {
            Console.WriteLine($"Canción: {listaCanciones[i]}, Álbum: {listaAlbums[i].NombreAlbum}, Artista: {listaArtistas[i].NombreArtista}, Letra: {listaLetras[i].Contenido}");
        }
    }
}
