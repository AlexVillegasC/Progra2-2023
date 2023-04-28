
using Labs.Lab4_GettersSetters;
using System;

namespace Labs.Lab4_GettersSetters;

public class Figura
{
    private double ancho;
    private double alto;

    // Getter para el ancho
    public double Ancho
    {
        get { return ancho; }
        set { ancho = value; }
    }

    // Getter para el alto
    public double Alto
    {
        get { return alto; }
        set { alto = value; }
    }
}


public class FiguraGeometrica
{
    private double ancho;

    // Getter para el ancho
    public double Ancho
    {
        get { return ancho; }
        set { ancho = value; }
    }

    // Setter para el ancho
    public void SetAncho(double nuevoAncho)
    {
        if (nuevoAncho > 0)
        {
            ancho = nuevoAncho;
        }
        else
        {
            Console.WriteLine("Error: el ancho debe ser mayor que cero.");
        }
    }
}


public class JimenaJimenez
{
    public static void Run()
    {
        // 1st Example:
        Figura figura1 = new Figura();
        figura1.Ancho = 10 ;
        figura1.Alto =  5 ;
        Console.WriteLine(" Ancho: " + figura1.Alto);
        Console.WriteLine(" Alto : " + figura1.Ancho);

        // 2nd Example:
        Figura figura2 = new Figura(10, 5);
        Console.WriteLine(" Ancho: " + figura2.Alto);
        Console.WriteLine(" Alto : " + figura2.Ancho);

    }
}


