using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab1
{
    public class animal
    {
        public virtual void Correr()
        {
            Console.WriteLine("Correr");
        }
    }

    public class leon : animal
    {
        public override void Correr()
        {
            Console.WriteLine("El leon es muy rapido");
        }
    }

    public class perro : animal
    {
        public override void Correr()
        {
            Console.WriteLine("El perro es un poco rapido");
        }
    }

    public class gato : animal
    {
        public override void Correr()
        {
            Console.WriteLine("El gato no es tan rapido");
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
                animal.Correr();
            }
        }
    }
}
