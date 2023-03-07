namespace Clase1.Lab1;

public class Transporte
{
    public virtual void Dibujar()
    {
        Console.WriteLine("Dibujando una figura genérica");
    }
}

public class Avion : Transporte
{
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un triángulo");
    }
}

public class Caballo : Transporte
{
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un círculo");
    }
}

public class Carro : Transporte
{
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un cuadrado");
    }
}

internal class AlexVillegas
{
    public static void Run()
    {
        // Alex VC - 503990937
        Transporte[] transporte = new Transporte[3];

        transporte[0] = new Avion();
        transporte[1] = new Caballo();
        transporte[2] = new Carro();

        foreach (Transporte figura in transporte)
        {
            figura.Dibujar();
        }
    }
}
