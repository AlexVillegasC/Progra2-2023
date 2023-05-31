using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab2_SobreCarga
{
    public class Persona

    {
        public virtual void Trabaja()
        {

            Console.Write("Trabaja");
        }
        public virtual void Trabaja(int Salario = 0)
        {
            Console.WriteLine("Trabaja en y Gana: " + Salario);
        }
    }

    public class Doctor : Persona
    {
        public override void Trabaja()
        {
            Console.WriteLine("Trabaja en el hospital");
        }
        public override void Trabaja(int Salario = 0)
        {
            Salario = Salario * 600;
            Console.WriteLine("Trabaja en el hospital y Gana: " + Salario);
        }

    }



    public class Profesor : Persona
    {
        public override void Trabaja()
        {
            Console.WriteLine("Trabaja en la Universidad");
        }
        public override void Trabaja(int Salario = 0)
        {
            Salario = Salario * 400;
            Console.WriteLine("Trabaja en la Universidad y Gana: " + Salario);
        }

    }

    public class Chef : Persona
    {
        public override void Trabaja()
        {
            Console.WriteLine("Trabaja en el Restaurante");
        }
        public override void Trabaja(int Salario = 0)
        {
            Salario = Salario * 200;
            Console.WriteLine("Trabaja en Resaurante y Gana: " + Salario);
        }

    }

    public class Bombero : Persona
    {
        public override void Trabaja()
        {
            Console.WriteLine("Trabaja en la Estacion");
        }
        public override void Trabaja(int Salario = 0)
        {
            Salario = Salario * 500;
            Console.WriteLine("Trabaja en la Estacion y Gana: " + Salario);
        }
    }

    internal class PriscilaDiaz2
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

                persona.Trabaja(1);

            }
        }
    }
}