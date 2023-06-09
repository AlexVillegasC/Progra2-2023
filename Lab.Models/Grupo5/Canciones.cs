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
}
