public class Videojuego
{
    public string[] generos = { "Disparos", "Aventura", "Terror" };
}
public class JuegoDisparos : Videojuego
{
    public void Disparar()
    {
        Console.WriteLine("¡Disparando!");
    }
}

public class JuegoAventura : Videojuego
{
    public void Explorar()
    {
        Console.WriteLine("¡Explorando el mundo del juego!");
    }
}

public class JuegoTerror : Videojuego
{
    public void Asustar()
    {
        Console.WriteLine("¡Sintiendo miedo con cada paso!");
    }
}
class r
{
    static void Main(string[] args)
    {
        JuegoDisparos juego1 = new JuegoDisparos();
        JuegoAventura juego2 = new JuegoAventura();
        JuegoTerror juego3 = new JuegoTerror();

        Console.WriteLine("Generos de videojuegos:");
        foreach (string genero in juego1.generos)
        {
            Console.WriteLine(genero);
        }

        Console.WriteLine("\nJuego de disparos:");
        juego1.Disparar();

        Console.WriteLine("\nJuego de aventura:");
        juego2.Explorar();

        Console.WriteLine("\nJuego de terror:");
        juego3.Asustar();
    }
}


