namespace Labs.Lab4;

public class Deporte
{
    private string _nombre;
    private int cantidadJugadores;

    public Deporte() { }

    public Deporte(string _nombre, int cantidadJugadores)
    {
        _nombre = Nombre;
         cantidadJugadores = CantidadJugadores;
    }

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    public int CantidadJugadores
    {
        get { return cantidadJugadores; }
        set { cantidadJugadores = value; }
    }
}

public class PabloObando
{
    public static void Run()
    {
        Deporte futbol = new Deporte();
        futbol.Nombre = "Fútbol";
        futbol.CantidadJugadores = 11;
        Console.WriteLine("Nombre del deporte: " + futbol.Nombre);
        Console.WriteLine("Cantidad de jugadores: " + futbol.CantidadJugadores);

    }



}
