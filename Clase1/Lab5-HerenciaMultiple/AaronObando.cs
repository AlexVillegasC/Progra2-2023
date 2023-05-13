using System;

interface IPersona
{
    void Saludar();
}

interface IEstudiante
{
    void Estudiar();
}

class Persona : IPersona
{
    public void Saludar()
    {
        Console.WriteLine("Hola, soy una persona.");
    }
}

class Estudiante : IEstudiante
{
    public void Estudiar()
    {
        Console.WriteLine("Estoy estudiando.");
    }
}

class EstudiantePersona : IPersona, IEstudiante
{
    Persona persona = new Persona();
    Estudiante estudiante = new Estudiante();

    public void Saludar()
    {
        persona.Saludar();
    }

    public void Estudiar()
    {
        estudiante.Estudiar();
    }
}

class Program
{
    static void Main(string[] args)
    {
        EstudiantePersona estudiantePersona = new EstudiantePersona();

        estudiantePersona.Saludar();
        estudiantePersona.Estudiar();
    }
}
