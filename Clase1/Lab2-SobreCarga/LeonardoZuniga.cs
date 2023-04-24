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
        public virtual void Avanzari(double velocidad) 
        {
            Console.WriteLine("Avanza a " + velocidad );
        }


    }

    public class Avion3 : Transporte4x4
    {

        public override void Avanzari(double velocidad)
        {
            Console.WriteLine("Vuela a " + velocidad);
        }

    }

    public class Caballo3 : Transporte4x4
    {
        public override void Avanzari(double velocidad)
        {
            Console.WriteLine("Galopa a " + velocidad);
        }

    }

    public class Carro3 : Transporte4x4
    {
        public override void Avanzari(double velocidad)
        {
            Console.WriteLine("Rodando" + velocidad);
        }

    }
    class LeonardoZuniga
    {
        public static void Run()
        {
            Avion3 boeing = new Avion3();
            Caballo3 caballo = new Caballo3();
            Carro3 carro = new Carro3();

            Transporte4x4[] transportes = new Transporte4x4[] { boeing, caballo, carro };


            foreach (Transporte4x4 t in transportes)
            {
                t.Avanzari(20);
            }

        }
    }
}
