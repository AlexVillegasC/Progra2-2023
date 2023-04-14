using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

{
    {
        Console.WriteLine("Desplazarse de forma generica ");
    }
}

public class Conejo : Animal
{
    public override void Desplazarse()
    {
        Console.WriteLine("Saltando!");
    }
}

public class Pez : Animal
{
    public override void Desplazarse()
    {
        Console.WriteLine("Nadando!");
    }
}

public class Ave : Animal
{
    public override void Desplazarse()
    {
        Console.WriteLine("Volando!");
    }
}

internal class GenesisGomez
{
    public static void Run()
    {
        Animal[] animales = new Animal[3];

        animales[0] = new Conejo();
        animales[1] = new  Pez();
        animales[2] = new  Ave();

        foreach (Animal animal in animales)
        {
            animal.Desplazarse();
        }
    }

}
