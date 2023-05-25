namespace Clase1.Lab1;

public class videojuegos
{
    public virtual void Proyectar()
    {
        Console.WriteLine("Proyectar en pantalla");
    }
}

public class Disparos : videojuegos
{
    public override void Proyectar (int ray)
    {
        Console.WriteLine("Armas!"); +ray 
    }
}

public class Aventura : videojuegos
{
    public override void Proyectar()
    {
        Console.WriteLine("Explorar!");
    }
}

public class  Terror : videojuegos
{
    public override void Proyectar()
    {
        Console.WriteLine("Asustar!");
    }
}

internal class AxelRamosVillegas
{
    public static void Run()

    {
        videojuegos[] Estilos = new videojuegos[3];

        Estilos[0] = new Disparos();
        Estilos[1] = new Aventura();
        Estilos[2] = new Terror ();

        foreach (videojuegos transporte in Estilos)
        {
            transporte.Proyectar();
        }
    }
}
