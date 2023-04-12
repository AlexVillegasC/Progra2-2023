namespace Labs.Lab2;


public class Vehiculo
{
    public virtual void Avanzar()
    {
        Console.WriteLine("Avanzar de forma genérica");
    }

    public virtual void Avanzar(int velocidad = 0)
    {
        Console.WriteLine("Avanzar de forma genérica a velocidad: " + velocidad);
    }
}

public class Helicoptero : Vehiculo
{
    public override void Avanzar()
    {
        Console.WriteLine("Volando!");
    }
    public override void Avanzar(int velocidad = 0)
    {
        velocidad = velocidad * 5;
        Console.WriteLine("Volando a velocidad: " + velocidad);
    }
}

public class Vaca : Vehiculo
{
    public override void Avanzar()
    {
        Console.WriteLine("Galopando!");
    }
    public override void Avanzar(int velocidad = 0)
    {
        Console.WriteLine("Galopando a velocidad: " + velocidad);
    }
}

public class Moto : Vehiculo
{
    public override void Avanzar()
    {
        Console.WriteLine("Rodando!");
    }

    public override void Avanzar(int velocidad = 0)
    {
        velocidad = velocidad * 2;
        Console.WriteLine("Rodando a velocidad: " + velocidad);
    }
}

internal class VictorBustos
{
    public static void Run()
    {
        Vehiculo[] transportes = new Vehiculo[3];

        transportes[0] = new Helicoptero();
        transportes[1] = new Vaca();
        transportes[2] = new Moto();

        foreach (Vehiculo transporte in transportes)
        {
            transporte.Avanzar(1);
        }
    }
}
