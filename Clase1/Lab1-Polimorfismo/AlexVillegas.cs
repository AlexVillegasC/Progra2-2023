namespace Labs.Lab1;

public class Transporte
{
    public virtual void Avanzar()
    {
        Console.WriteLine("Avanzar de forma genérica");
    }
}

public class Avion : Transporte
{
    public override void Avanzar()
    {
        Console.WriteLine("Volando!");
    }
}

public class Caballo : Transporte
{
    public override void Avanzar()
    {
        Console.WriteLine("Galopando!");
    }
}

public class Carro : Transporte
{
    public override void Avanzar()
    {
        Console.WriteLine("Rodando!");
    }
}

internal class AlexVillegas
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
