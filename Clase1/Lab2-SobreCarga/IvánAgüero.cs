using System;
namespace Labs.Lab2;


public class Figura
{
    public virtual void Area()
    {
        Console.WriteLine("Area de la figura");
    }

    public virtual void Area(int area = 3)
    {
        Console.WriteLine("El area de la figura es: " + area);
    }
}



public class Rectangulo : Figura
{
    public override void Area()
    {
        Console.WriteLine("El area es lo largo por lo ancho.");
    }

    public override void Area(int area = 2)
    {
        area = area * area;
        Console.WriteLine("El area es de: " + area);
    }
}

public class Rombo : Figura
{
    public override void Area()
    {
        Console.WriteLine("El area es la multiplicacion de las diagonales dibidido en 2.");
    }

    public override void Area(int area = 2)
    {
        area = area * area/2;
        Console.WriteLine("El area es: " + area);
    }
}

public class Cuadro : Figura
{
    public override void Area()
    {
        Console.WriteLine("El area del cuadrado es el lado por el lado.");
    }

    public override void Area(int area = 5)
    {
        area = area * area;
        Console.WriteLine("El area es de: " + area);
    }
}




internal class IvánAgüero
{
    public static void Run()
    {
        Figura[] figuras = new Figura[3];
        figuras[0] = new Rectangulo();
        figuras[1] = new Rombo();
        figuras[2] = new Cuadro();

        foreach (Figura figura in figuras)
        {
            figura.Area(15);
        }

    }
}


