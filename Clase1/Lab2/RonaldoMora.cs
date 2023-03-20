
namespace Clase1.Lab2;

public class Dispositivo
{
    public virtual void Encender()
    {
        Console.WriteLine("El dispositivo se está encendiendo.");
    }

    public virtual void Apagar()
    {
        Console.WriteLine("El dispositivo se está apagando.");
    }
}

public class Televisor : Dispositivo
{
    public override void Encender()
    {
        Console.WriteLine("El televisor se está encendiendo.");
    }

    public override void Apagar()
    {
        Console.WriteLine("El televisor se está apagando.");
    }
}

public class Smartphone : Dispositivo
{
    public override void Encender()
    {
        Console.WriteLine("El smartphone se está encendiendo.");
    }

    public override void Apagar()
    {
        Console.WriteLine("El smartphone se está apagando.");
    }
}

public class ComputadoraPortatil : Dispositivo
{
    public override void Encender()
    {
        Console.WriteLine("La computadora portátil se está encendiendo.");
    }

    public override void Apagar()
    {
        Console.WriteLine("La computadora portátil se está apagando.");
    }

}

internal class RonaldoMora
{
    public static void Run()
    {
        Dispositivo[] dispositivos = new Dispositivo[3];

        dispositivos[0] = new Televisor();
        dispositivos[1] = new Smartphone();
        dispositivos[2] = new ComputadoraPortatil();

        foreach (Dispositivo dispositivo in dispositivos)
        {
            dispositivo.Encender();
            dispositivo.Apagar();
        }
    }
}

