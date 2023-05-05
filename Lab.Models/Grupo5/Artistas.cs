

namespace Lab.Models.Grupo5;
public class Artistas
{
    private string nombre;

    public Artistas (string nombre)
    {
        this.nombre = nombre;
    }


    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
}

