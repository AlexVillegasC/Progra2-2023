namespace Labs.Lab5;

public interface ICiclista
{
    void Pedalear();
}

public interface IProfesor

{
    void Enseñar();
}

public class Persona : ICiclista, IProfesor
{
    public void Pedalear()
    {
        Console.WriteLine("La persona está pedaleando.");
    }

    public void Enseñar()
    {
        Console.WriteLine("La persona está enseñando.");
    }
}

internal class AshlyVargasProgram
{
    public static void Run()
    {
        Persona Nixon = new Persona();
        Nixon.Pedalear();
        Nixon.Enseñar();

    }
<<<<<<< HEAD
    //Hola
=======
>>>>>>> origin/AshlyVargas-Lab4
}
