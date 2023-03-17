using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Lab2;

   




    public class Animales
    {
        public virtual void caminar()
        {
            Console.WriteLine("camina normalmente");
        }
    public virtual void caminar(int velocidad = 0)
    {
        Console.WriteLine("Avanzar de forma genérica a velocidad: " + velocidad);
    }
}

    public class Zorro : Animales
    {
        public override void caminar()
        {
            Console.WriteLine("Se va corriendo");
        }
    public override void caminar(int velocidad = 0)
    {
        velocidad = velocidad * 5;
        Console.WriteLine("caminando a una velocidad de: " + velocidad);
    }
}

    public class Paloma : Animales
    {
        public override void caminar()
        {
            Console.WriteLine("Se va volando");
        }
    public override void caminar(int velocidad = 0)
    {
        velocidad = velocidad * 5;
        Console.WriteLine("Volando a una  velocidad: " + velocidad);
    }
}

    public class Tiburon : Animales
    {
        public override void caminar()
        {
            Console.WriteLine("Se va nadando");
        }
    public override void caminar(int velocidad = 0)
    {
        velocidad = velocidad * 5;
        Console.WriteLine("nadando a una velocidad de: " + velocidad);
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


