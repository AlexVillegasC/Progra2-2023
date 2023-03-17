using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Lab1;




public class Animales
{
    public virtual void caminar()
    {
        Console.WriteLine("camina normalmente");
    }
}

public class Zorro : Animales
{
    public override void caminar()
    {
        Console.WriteLine("Se va corriendo");
    }
}

public class Paloma : Animales
{
    public override void caminar()
    {
        Console.WriteLine("Se va volando");
    }
}

public class Tiburon : Animales
{
    public override void caminar()
    {
        Console.WriteLine("Se va nadando");
    }
}

internal class AkionCheng
{
    public static void Run()
    {
        Animales[] animales = new Animales[3];

        animales[0] = new Zorro();
        animales[1] = new Paloma();
        animales[2] = new Tiburon();

        foreach (Animales Animales in animales)
        {
            Animales.caminar();
        }
    }
}
