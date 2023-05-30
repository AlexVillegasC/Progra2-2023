using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab1_Polimorfismo
{
    public class Persona

    {
        public virtual void Trabaja()
        {

            Console.Write("Trabaja");
        }
    }

    public class Doctor : Persona
    {
        public override void Trabaja()
        {
            Console.WriteLine("Trabaja en el hospital");
        }

    }


    public class Profesor : Persona
    {
        public override void Trabaja()
        {
            Console.WriteLine("Trabaja en la Universidad");
        }

    }

    public class Chef : Persona
    {
        public override void Trabaja()
        {
            Console.WriteLine("Trabaja en el Restaurante");
        }

    }

    public class Bombero : Persona
    {
        public override void Trabaja()
        {
            Console.WriteLine("Trabaja en la Estacion");
        }
    }



    internal class PriscilaDiaz
    {
        public static void Run()
        {
            Persona[] personas = new Persona[4];

            personas[0] = new Doctor();
            personas[1] = new Profesor();
            personas[2] = new Chef();
            personas[3] = new Bombero();

            foreach (Persona persona in personas)
            {

                persona.Trabaja();

            }
        }
    }
}

}
