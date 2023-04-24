

namespace Labs.Lab2;

public class Animal1
{
    public virtual void Desplazarse()
    {
        Console.WriteLine("Desplazarse");
    }

    public virtual void Desplazarse(int velocidad = 0)
    {
        Console.WriteLine(" Desplazarse a una velocidad de: " + velocidad);
    }
}

public class Conejo11 : Animal1
{
    public override void Desplazarse()
    {
        Console.WriteLine("El conejo es muy rapido");
    }

    public override void Desplazarse(int velocidad = 0)
    {
        velocidad = velocidad * 5;
        Console.WriteLine("Saltando a velocidad: " + velocidad);
    }
}

public class Pez : Animal1
{
    public override void Desplazarse()
    {
        Console.WriteLine("El Pez es un poco rapido");
    }
    public override void Desplazarse(int velocidad = 0)
    {
        Console.WriteLine("Nadando a velocidad de: " + velocidad);
    }
}

public class Ave : Animal1
{
    public override void Desplazarse()
    {
        Console.WriteLine("El Ave no es tan rapido");
    }

    public override void Desplazarse(int velocidad = 0)
    {
        velocidad = velocidad * 2;
        Console.WriteLine("Volando a velocidad: " + velocidad);
    }
}

internal class GenesisGomez
{
    public static void Run()
    {
        Animal1[] animales = new Animal1[3];
        animales[0] = new Conejo11();
        animales[1] = new Pez();
        animales[2] = new Ave();

        foreach (Animal1 animal in
            animales)
        {
            animal.Desplazarse(1);
        }
    }
}