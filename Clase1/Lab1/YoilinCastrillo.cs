using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Lab1
{
    public class Especie
    {
        public virtual void Jugar()
        {
            Console.WriteLine("Jugar a ");
        }
        public virtual void Jugar(int velocidad = 0)
        {
            Console.WriteLine("Jugar a velocidad: " + velocidad);
        }
     
    }

    public class Borrego : Especie
    {
        public override void Jugar()
        {
            Console.WriteLine("Jugar con pelota");
        }
        public override void Jugar(int velocidad = 0)
        {
            Console.WriteLine("Jugando a velocidad: " + velocidad);
        }
    }

    public class Conejo : Especie
    {
        public override void Jugar()
        {
            Console.WriteLine("Jugar con raton");
        }
        public override void Jugar(int velocidad = 0)
        {
            Console.WriteLine("Jugando a velocidad: " + velocidad);
        }
    }

    public class Tortuga : Especie
    {
        public override void Jugar()
        {
            Console.WriteLine("Jugar con barro");
        }
        public override void Jugar(int velocidad = 0)
        {
            velocidad = velocidad * 4;
            Console.WriteLine("Jugando a velocidad: " + velocidad);
        }
    }

    public class YoilinCastrillo
    {

        public static void Run()
        {
            Especie[] especies = new Especie[3];

            especies[0] = new Borrego();
            especies[1] = new Conejo();
            especies[2] = new Tortuga();

            foreach (Especie especie in especies)
            {
                especie.Jugar(1);
            }

        }
    }

}
