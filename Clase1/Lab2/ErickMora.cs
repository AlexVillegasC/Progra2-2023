using System;
namespace Labs.Lab2;


public class Motocicleta
{
    public virtual void Avanzar()
    {
        Console.WriteLine("Avanzar de forma general");
    }
    public virtual void Avanzar(int velocidad = 8)
    {
        Console.WriteLine("Avanzar de forma general a velocidad: " + velocidad);
    }

}



public class Deportiva : Motocicleta
{
    public override void Avanzar()
    {
        Console.WriteLine("Estoy conduciendo una motocicleta deportiva...");
    }
    public override void Avanzar(int velocidad = 280)
    {
        velocidad = velocidad * 2;
        Console.WriteLine("Avanzar a velocidad: " + velocidad);
    }

}

public class Chopper : Motocicleta
{
    public override void Avanzar()
    {
        Console.WriteLine("Estoy conduciendo una motocicleta chopper...");
    }
    public override void Avanzar(int velocidad = 150)
    {
        velocidad = velocidad * 2;
        Console.WriteLine("Rodando a velocidad: " + velocidad);
    }
}

public class Enduro : Motocicleta
{
    public override void Avanzar()
    {
        Console.WriteLine("Estoy conduciendo una motocicleta enduro...");
    }
    public override void Avanzar(int velocidad = 160)
    {
        velocidad = velocidad * 2;
        Console.WriteLine("Avanzar a velocidad: " + velocidad);
    }
}




internal class ErickMora
{
    public static void Run()
    {
        Motocicleta[] motocicletas = new Motocicleta[3];
        motocicletas[0] = new Deportiva();
        motocicletas[1] = new Chopper();
        motocicletas[2] = new Enduro();

        foreach (Motocicleta motocicleta in motocicletas)
        {
            motocicleta.Avanzar(200);
        }

    }
}
