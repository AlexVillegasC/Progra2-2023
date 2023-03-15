namespace Clase1.Lab1;

public class Persona 
{
    public virtual void Saludar()
    {
        Console.WriteLine("Saludar ");
    }
}

public class Profesor : Persona
{
    public override void Saludar ()
    {
        Console.WriteLine("Hola soy el profesor!");
    }
}

public class Estudiante : Persona
{
    public override void Saludar()
    {
        Console.WriteLine("Hola soy el estudiante!");
    }
}

public class Director : Persona
{
    public override void Saludar()
    {
        Console.WriteLine("Hola soy el director!");
    }
}

internal class JosePablo
{
    public static void Run()
    {
        Persona[] personas = new Persona[3];

        personas[0] = new Profesor();
        personas[1] = new Estudiante();
        personas [2] = new Director ();

        foreach (Persona persona in personas)
        {
            persona.Saludar();
        }
        
        Console.ReadKey();
    }
}




