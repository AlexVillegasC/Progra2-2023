
namespace Labs.Lab5;

public interface Icorredor
{
    void correr();
}

public interface Irematador
{
    void rematar();
}

public class CR7 : Icorredor, Irematador
{
    public void correr()
    {
        Console.WriteLine("Cr7 esta corriendo en el partido.");
    }

    public void rematar()
    {
        Console.WriteLine("Cr7 esta remtando en el partido.");
    }
}

internal class EmmanuelPinedaProgram
{
    public static void Run()
    {
        jugador Messi = new jugador();
        Messi.correr();
        Messi.rematar();
    }
}
