using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab4_GettersSetters;

public class Tenis
{
    private string _marca;
    private string _talla;
    private string _color;


    public Tenis() { }

    public Tenis(string marca, string talla, string color)
    {
        _marca = marca;
        _talla = talla;
        _color = color;
    }

    public string Marca
    {
        get { return _marca; }
        set { _marca = value; }
    }

    public string Talla
    {
        get { return _talla; }

        set
        {
            if (!value.Equals(""))
            {
                _talla = value;
            }
        }
    }

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }
}

public class JoseBaltodano
{
    public static void Run()
    {
        // 1st Example:
        Tenis tenis1 = new Tenis();
        tenis1.Marca = "NIKE";
        tenis1.Talla = "45";
        tenis1.Color = "Rojo";
        Console.WriteLine("La marca es: " + tenis1.Marca);
        Console.WriteLine("La talla es: " + tenis1.Talla);
        Console.WriteLine("El Color es: " + tenis1.Color);

        // 2nd Example:
        Tenis tenis2 = new Tenis("ADIDAS","34","Blanco");
        Console.WriteLine("La marca es: " + tenis2.Marca);
        Console.WriteLine("La talla es: " + tenis2.Talla);
        Console.WriteLine("El Color es: " + tenis2.Color);

    }
}
