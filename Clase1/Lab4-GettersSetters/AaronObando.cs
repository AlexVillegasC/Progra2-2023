using System;

class Persona
{
    private string nombre;
    private int edad;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Persona persona1 = new Persona();
        persona1.Nombre = "Juan";
        persona1.Edad = 25;

        Console.WriteLine("Nombre: " + persona1.Nombre);
        Console.WriteLine("Edad: " + persona1.Edad);
    }
}
