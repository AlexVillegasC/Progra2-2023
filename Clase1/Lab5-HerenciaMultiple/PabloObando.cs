namespace Labs.Lab5;

public interface ILadrador
{
    void Ladrar();
}

public interface IMordedor
{
    void Morder();
}

public class Perro : ILadrador, IMordedor
{
    public void Ladrar()
    {
        Console.WriteLine("El perro esta ladrando.");
    }

    public void Morder()
    {
        Console.WriteLine("El perro esta mordiendo.");
    }
}

internal class PabloObando
{
    public static void Run()
    {
        Perro Dante = new Perro();
        Dante.Ladrar();
        Dante.Morder();
    }
}
