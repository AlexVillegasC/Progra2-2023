namespace Clase1.Lab1;

public class TransportePrueba
{
    public virtual void Avanzar()
    {
        Console.WriteLine("Avanzar de forma genérica");
    }
}

public class AvionPrueba : Transporte
{
    public override void Avanzar()
    {
        Console.WriteLine("Volando!");
    }
}

public class CaballoAvionPrueba : Transporte
{
    public override void Avanzar()
    {
        Console.WriteLine("Galopando!");
    }
}

public class CarroAvionPrueba : Transporte
{
    public override void Avanzar()
    {
        Console.WriteLine("Rodando!");
    }
}

internal class PruebaIgnorar
{
    public static void Run()
    {
        Transporte[] transportes = new Transporte[3];

        transportes[0] = new Avion();
        transportes[1] = new Caballo();
        transportes[2] = new Carro();

        foreach (Transporte transporte in transportes)
        {
            transporte.Avanzar();
        }
    }
}
