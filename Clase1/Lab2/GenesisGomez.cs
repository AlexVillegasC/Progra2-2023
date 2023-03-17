using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab2
{
    internal class Genesis_Gomez
    {
    
}
public class Animal
{
    public virtual void Desplazarse()
    {
        Console.WriteLine("Desplazarse de forma generica ");
    }
    public virtual void Desplazarse(int velocidad = 0)
    {
        Console.WriteLine("Desplazarse de forma genérica a velocidad: " + velocidad);
    }
}

public class Conejo : Animal
{
    public override void Desplazarse()
    {
        Console.WriteLine("Saltando!");
    }

   

    public override void Desplazarse (int velocidad = 0)
    {
        velocidad = velocidad * 5;
        Console.WriteLine("Saltando a velocidad: " + velocidad);
    }
}

public class Pez : Animal
{
    public override void Desplazarse()
    {
        Console.WriteLine("Nadando!");
    }
        public override void Desplazarse(int velocidad = 0)
        {
            Console.WriteLine("Nadando a velocidad: " + velocidad);
        }

    }

public class Ave : Animal
{
    public override void Desplazarse()
    {
        Console.WriteLine("Volando!");
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
            Animal[] animales = new Animal[3];

            animales[0] = new Conejo();
            animales[1] = new Pez();
            animales[2] = new Ave();

            foreach (Animal animal in animales)
            {
                animal.Desplazarse(1);
            }
        }
    }
}