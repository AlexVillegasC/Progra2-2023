using System;

public class Figura
{
    public virtual void CalcularArea()
    {
        Console.WriteLine("Calculando el área de una figura genérica");
    }
}

public class Triangulo : Figura
{
    public override void CalcularArea()
    {
        Console.WriteLine("Calculando el área de un triángulo");
    }
}

public class Circulo : Figura
{
    public override void CalcularArea()
    {
        Console.WriteLine("Calculando el área de un círculo");
    }
}

public class Rectangulo : Figura
{
    public override void CalcularArea()
    {
        Console.WriteLine("Calculando el área de un rectángulo");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Figura[] figuras = new Figura[3];

        figuras[0] = new Triangulo();
        figuras[1] = new Circulo();
        figuras[2] = new Rectangulo();

        foreach (Figura figura in figuras)
        {
            figura.CalcularArea();
        }
    }
}
