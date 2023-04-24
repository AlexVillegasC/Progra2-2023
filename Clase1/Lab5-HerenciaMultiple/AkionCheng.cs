namespace Labs.Lab5;

public interface NGolpear
{
    void Golpear();
}

public interface IDodgea
{
    void Dodgea();
}

public class Boxeador : NGolpear, IDodgea
{
    public void Golpear()
    {
        Console.WriteLine("El boxeador a golpeado al rival.");
    }

    public void Dodgea()
    {
        Console.WriteLine("El boxeador a esquivado el golpe del rival.");
    }
}

internal class AkionCheng
{
    public static void Run()
    {
        Boxeador Messi = new Boxeador();
        Messi.Golpear();
        Messi.Dodgea();
    }
}

