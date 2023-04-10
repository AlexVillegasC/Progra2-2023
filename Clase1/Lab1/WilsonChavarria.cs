namespace Labs.Lab1;


public class Personas
{
    public string? Nombre { get; set; }

    public virtual string Saludar()
    {
        return "Saludo Generico";
    }
}

public class Alumno : Personas
{
    public Alumno(string nombre)
    {
        this.Nombre = nombre;
    }
    public override string Saludar()
    {
        string saludo = "Hola, mi nombre es " + this.Nombre + " y soy un alumno";
        return saludo;
    }
}


public class Empleado : Personas
{
    public Empleado(string nombre)
    {
        this.Nombre = nombre;
    }
    public override string Saludar()
    {
        string saludo = "Hola, mi nombre es " + this.Nombre + " y soy un empleado";
        return saludo;
    }
}

internal class WilsonChavarria
{
    public static void Run()
    {

        Personas[] personas = new Personas[2];
        personas[0] = new Alumno("Jaime Correa");
        personas[1] = new Empleado("Juan Perez");
        for (int i = 0; i < personas.Length; i++)
        {
            Console.WriteLine(personas[i].Saludar());
        }
    }
