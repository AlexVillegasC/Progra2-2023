namespace Labs.Lab2;

public class Persona 
{
    public virtual void Saludar()
    {
        Console.WriteLine("Saludar");
        
    }
    public virtual void Saludar(String Nombre )
    {
        Console.WriteLine("Saludar " + Nombre);
        
    }
}

public class Profesor : Persona
{
    public override void Saludar ()
    {
        Console.WriteLine("Hola soy el profesor!");
    }
    public override void Saludar(String Nombre)
    {
        Nombre = "Aaron";
        Console.WriteLine("Hola soy el estudiante! como estas " + Nombre);
    }

}

public class Estudiante : Persona
{
    public override void Saludar()
    {
        Console.WriteLine("Hola soy el estudiante!");
    }

    public override void Saludar(String Nombre)
    {
        Nombre = "Jose";
       Console.WriteLine("Hola soy el estudiante! como estas " + Nombre);
    }
    
}

public class Director : Persona
{
    public override void Saludar()
    {
        Console.WriteLine("Hola soy el director!");
    }
    public override void Saludar(String Nombre)
    {
        Nombre = "Ashly";
        Console.WriteLine("Hola soy el estudiante! como estas " + Nombre);
    }

}

public class JosePabloS_Sobrecaga
{
    public static void Run()
    {
        Persona[] personas = new Persona[3];

        personas[0] = new Profesor();
        personas[1] = new Estudiante();
        personas[2] = new Director();
        

        foreach (Persona persona in personas)
        {
            persona.Saludar(Nombre: null);
        }

    }
}
    
