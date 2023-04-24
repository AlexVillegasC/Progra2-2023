namespace Labs.Lab2;

public class Transporte
{
    public virtual void Acelerar()
    {
        Console.WriteLine("El transporte está acelerando.");
    }

    public virtual void Frenar()
    {
        Console.WriteLine("El transporte está frenando.");
    }
}

public class Camion : Transporte
{
    public virtual void Acelerar()
    {
        Console.WriteLine("El camion está acelerando.");
    }

    public virtual void Frenar()
    {
        Console.WriteLine("El camion está frenando.");
    }
}

public class Carro : Transporte
{
    public virtual void Acelerar()
    {
        Console.WriteLine("El carro está acelerando.");
    }

    public virtual void Frenar()
    {
        Console.WriteLine("El carro está frenando.");
    }
}

public class Motocicleta : Transporte
{
    public virtual void Acelerar()
    {
        Console.WriteLine("El moto está acelerando.");
    }

    public virtual void Frenar()
    {
        Console.WriteLine("El moto está frenando.");
    }

}

internal class PabloObando
{
    public static void Run()
    {
        Transporte[] transporte = new Transporte[3];

        transporte[0] = new Camion();
        transporte[1] = new Carro();
       transporte[2] = new Motocicleta();

        foreach (Transporte transportes in transporte)
        {
            transportes.Acelerar();
            transportes.Frenar();
        }
    }
}
