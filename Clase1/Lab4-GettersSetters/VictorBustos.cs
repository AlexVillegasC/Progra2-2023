public class Persona
{
    private string nombre;
    private string apellido;
    private int cedula;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Apellido  
    {
        get { return apellido; }
        set { apellido = value; }
    }

    public int Cedula
    {
        get { return cedula; }
        set { cedula = value; }
    }

    public void run()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Apellido: " + Apellido);
        Console.WriteLine("Cédula: " + Cedula);
    }
}
