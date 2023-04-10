
namespace Labs.Lab1;

public class TransporteJB
{
    public virtual void Avanzar()
    {
        Console.WriteLine("Avanzar de forma genérica");
    }
}

public class Helicoptero : Transporte
{
    public override void Avanzar()
    {
        Console.WriteLine("Volando!");
    }
}

public class Vaca : Transporte
{
    public override void Avanzar()
    {
        Console.WriteLine("Galopando!");
    }
}

public class Moto    : Transporte
{
    public override void Avanzar()
    {
        Console.WriteLine("Rodando!");
    }
}

internal class VictorBustos
{
    public static void Run()
    {
        Transporte[] transportes = new Transporte[3];

        transportes[0] = new Helicoptero();
        transportes[1] = new Vaca();
        transportes[2] = new Moto();

        foreach (Transporte transporte in transportes)
        {
            transporte.Avanzar();
        }
    }
}