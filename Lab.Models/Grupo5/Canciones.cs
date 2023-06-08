using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Models.Grupo5;


public class Canciones
{
    public  List<string> listaCanciones = new List<string>();
    public List<Album> Albums { get; set; }
    public List<Artista> Artistas { get; set; }
    public List<Letra> Letras { get; set; }

    /*  public void AgregarCancion(string nombreCancion, Album album, Artista artista, Letra letra)
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
      }*/
}
