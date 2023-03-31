using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab1
{
    public class Transporte2x4
    {
        public virtual void Avanzari()
        {
            Console.WriteLine("Avanza");
        }


    }

    public class Avion3 : Transporte2x4
    {

        public override void Avanzari()
        {
            Console.WriteLine("Vuela");
        }

    }

    public class Caballo3 : Transporte2x4
    {
        public override void Avanzari()
        {
            Console.WriteLine("Galopa");
        }

    }

    public class Carro3 : Transporte2x4
    {
        public override void Avanzari()
        {
            Console.WriteLine("Rodando");
        }

    }
    class LeonardoZuniga
    {
        public static void Run()
        {
            Avion3 boeing = new Avion3();
            Caballo3 caballo = new Caballo3();
            Carro3 carro = new Carro3();

            Transporte2x4[] transportes = new Transporte2x4[] { boeing, caballo, carro };


            foreach (Transporte2x4 t in transportes)
            {
                t.Avanzari();
            }

        }
    }
}
