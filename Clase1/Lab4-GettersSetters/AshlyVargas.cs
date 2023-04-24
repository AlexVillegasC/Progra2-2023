using Labs.Lab1;

namespace Labs.Lab4;

public class Estudiante
{
    private string _nombre;
    private string _apellido;
    private int _edad;

    public Estudiante()
    {
    }

    public Estudiante(string nombre, string apellido, int edad)
    {
        _nombre = nombre;
        _apellido = apellido;
        _edad = edad;
    }
    
    public string nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    
    public string apellido
    {
        get { return _apellido; }
        set { _apellido = value; }
    }
    
    public int edad
    {
        get { return _edad; }
        set { _edad = value; }
    }
}

public class AshlyVargasProgram
{
    public static void Run()
    {

        // 1st Example:
        Estudiante estudiante1 = new Estudiante();
        estudiante1.nombre = "Pablo";
        estudiante1.apellido = "Suarez";
        estudiante1.edad = 20;
        Console.WriteLine("nombre: " + estudiante1.nombre);
        Console.WriteLine("apellido: " + estudiante1.apellido);
        Console.WriteLine("edad: " + estudiante1.edad);

        Estudiante estudiante2 = new Estudiante("Aaron", "chaves", 20);
        Console.WriteLine("nombre: " + estudiante2.nombre);
        Console.WriteLine("apellido: " + estudiante2.apellido);
        Console.WriteLine("edad: " + estudiante2.edad);
        

    }
}
    