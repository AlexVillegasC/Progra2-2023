public class Animal1
{
    public virtual void Desplazarse()
    {
        Console.WriteLine("Desplazarse de forma generica ");
    }
}

public class Conejo1 : Animal
{
    public override void Desplazarse()
    {
        Console.WriteLine("Saltando!");
    }
}

public class Pez1 : Animal
{
    public override void Desplazarse()
    {
        Console.WriteLine("Nadando!");
    }
}

public class Ave1 : Animal
{
    public override void Desplazarse()
    {
        Console.WriteLine("Volando!");
    }
}

internal class GénesisGómez
{
    public static void Run()
    {
        Animal[] animales = new Animal[3];

        animales[0] = new Conejo();
        animales[1] = new Pez();
        animales[2] = new Ave();

        foreach (Animal animal in animales)
        {
            animal.Desplazarse();
        }
    }
}

