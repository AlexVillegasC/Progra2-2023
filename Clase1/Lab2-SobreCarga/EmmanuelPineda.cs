using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab2
{
    public class animal
    {
        public virtual void Correr()
        {
            Console.WriteLine("Correr");
        }

        public virtual void Correr(int velocidad = 0)
        {
            Console.WriteLine("Correr a una velocidad de: " + velocidad);
        }
    }

    public class leon : animal
    {
        public override void Correr()
        {
            Console.WriteLine("El leon es muy rapido");
        }

        public override void Correr(int velocidad = 0)
        {
            velocidad = velocidad * 5;
            Console.WriteLine("Corriendo a velocidad: " + velocidad);
        }
    }

    public class perro : animal
    {
        public override void Correr()
        {
            Console.WriteLine("El perro es un poco rapido");
        }
        public override void Correr(int velocidad = 0)
        {
            Console.WriteLine("Corriendo a velocidad de: " + velocidad);
        }
    }

    public class gato : animal
    {
        public override void Correr()
        {
            Console.WriteLine("El gato no es tan rapido");
        }

        public override void Correr(int velocidad = 0)
        {
            velocidad = velocidad * 2;
            Console.WriteLine("Corriendo a velocidad: " + velocidad);
        }
    }

    internal class EmmanuelPineda
    {
        public static void Run()
        {
            animal[] animales = new animal[3];
            animales[0] = new leon();
            animales[1] = new perro();
            animales[2] = new gato();

            foreach (animal animal in
                animales)
            {
                animal.Correr(1);
            }
        }
    }




}
