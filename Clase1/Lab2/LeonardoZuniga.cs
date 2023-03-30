using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;


namespace Labs.Lab2
{
    public class Transporte4x4
    {
        public virtual void Avanzare()
        {
            Console.WriteLine("Avanza...");
        }
        public virtual void Avanzare(int velocidad)
        {
            Console.WriteLine("Avanza a " + velocidad);
        }

    }

    public class Avion4 : Transporte4x4
    {
        public override void Avanzare()
        {
            Console.WriteLine("Vuela...");
        }
        public override void Avanzare(int velocidad)
        {
            Console.WriteLine("Vuela a " + velocidad);
        }

    }

    public class Caballo4 : Transporte4x4
    {
        public override void Avanzare()
        {
            Console.WriteLine("Galopa...");
        }
        public override void Avanzare(int velocidad)
        {
            Console.WriteLine("Galopa a " + velocidad);
        }

    }

    public class Carro4 : Transporte4x4
    {
        public override void Avanzare()
        {
            Console.WriteLine("Rodando...");
        }
        public override void Avanzare(int velocidad)
        {
            Console.WriteLine("Rodando " + velocidad);
        }

    }

    public class LeonardoZuniga

    {
        public static void Run()
        {

            Avion4 boeing = new Avion4();
            Caballo4 caballo = new Caballo4();
            Carro4 carro = new Carro4();

            Transporte4x4[] transportes = new Transporte4x4[] { boeing, caballo, carro };



            foreach (Transporte4x4 t in transportes)
            {
                t.Avanzare(3);
            }


        }
    }
    }
