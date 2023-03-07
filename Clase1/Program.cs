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

public class Program
{
    public static void Main()
    {
        Transporte[] figuras = new Transporte[3];

        figuras[0] = new Avion();
        figuras[1] = new Caballo();
        figuras[2] = new Carro();

        foreach (Transporte figura in figuras)
        {
            figura.Dibujar();
        }
    }
}