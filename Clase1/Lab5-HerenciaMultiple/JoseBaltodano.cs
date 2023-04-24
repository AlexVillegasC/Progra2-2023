namespace Labs.Lab5_HerenciaMultiple;


public interface SSaltar
{
    void Saltar();
}

public interface CCaminar
{
    void Caminar();
}

public class Personaje : SSaltar, CCaminar
{
    public void Saltar()
    {
        Console.WriteLine("Mario está saltando...");
    }

    public void Caminar()
    {
        Console.WriteLine("Mario está Caminando...");
    }
}

internal class JoseBaltodano
{
    public static void Run()
    {
        Personaje MarioBross = new Personaje();
        MarioBross.Saltar ();
        MarioBross.Caminar();
    }
}
