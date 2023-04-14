using System;

namespace Labs.Lab4;
//GET Y SET
public class Carro
{
    private string modelo;
    private string _color;


    public Carro() { }

    public Carro(int modelo, string color)
    {
        modelo = modelo;
        color = color;
    }

    public Carro(string v1, string v2)
    {
    }

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public string color
    {
        get { return color; }

        set
        {
            if (!value.Equals(""))
            {
                color = value;
            }
        }
    }
}

public class YoilinCastrillo
{
    public static void Run()
    {
        // 1st Example:
        Carro carro1 = new Carro();
        carro1.Modelo = "New";
        carro1.color = "Rojo";
        Console.WriteLine("First Name: " + carro1.Modelo);
        Console.WriteLine("Last Name: " + carro1.color);

        // 2nd Example:
        Carro carro2 = new Carro("o", "o");
        Console.WriteLine("First Name: " + carro2.Modelo);
        Console.WriteLine("Last Name: " + carro2.color);
    }
}
