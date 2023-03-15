using System;
namespace Clase1.Lab1;


public class Motocicleta
{
    public virtual void Avanzar()
    {
        Console.WriteLine("Avanzar de forma genérica");
    }
}



public class Deportiva : Motocicleta
{
    public override void Avanzar()
    {
        Console.WriteLine("Estoy conduciendo una motocicleta deportiva...");
    }
}

public class Chopper : Motocicleta
{
    public override void Avanzar()
    {
        Console.WriteLine("Estoy conduciendo una motocicleta chopper...");
    }
}

public class Enduro : Motocicleta
{
    public override void Avanzar()
    {
        Console.WriteLine("Estoy conduciendo una motocicleta enduro...");
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
            motocicleta.Avanzar();
        }

    }
}
