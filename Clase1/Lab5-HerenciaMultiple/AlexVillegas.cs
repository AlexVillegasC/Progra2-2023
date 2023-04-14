
namespace Labs.Lab5;

public interface IVolador
{
    void Volar();
}

public interface INadador
{
    void Nadar();
}

public class Pato : IVolador, INadador
{
    public void Volar()
    {
        Console.WriteLine("El pato está volando.");
    }

    public void Nadar()
    {
        Console.WriteLine("El pato está nadando.");
    }
}

internal class AlexVillegasProgram
{
    public static void Run()
    {
        Pato lucas = new Pato();
        lucas.Nadar();
        lucas.Volar();
    }
}
