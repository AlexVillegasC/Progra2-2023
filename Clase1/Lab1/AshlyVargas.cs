namespace Clase1.Lab1;

public class Animal
{
    public virtual void Sonidos()
    {
        Console.WriteLine("Sonidos");
    }
}

public class Perro : Animal
{
    public override void Sonidos()
    {
        Console.WriteLine("El perro ladra");
    }
}

public class Gato : Animal
{
    public override void Sonidos()
    {
        Console.WriteLine("El gato maulla");
    }
}

public class Pato : Animal
{
    public override void Sonidos()
    {
        Console.WriteLine("El pato grazna");
    }
}

public class Lobo : Animal
{
    public override void Sonidos()
    {
        Console.WriteLine("El lobo aulla");
    }
}

internal class AshlyVargas
{
    public static void Run()
    {
        Animal[] animales = new Animal[4];

        animales[0] = new Perro();
        animales[1] = new Gato();
        animales[2] = new Pato();
        animales[3] = new Lobo();

        foreach ( Animal animal in animales)
        {
            animal.Sonidos();
        }

    }
}