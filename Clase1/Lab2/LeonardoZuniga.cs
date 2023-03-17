using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Lab2
{
    public class Transporte
    {

        public virtual void Avanzar()
        {
            Console.WriteLine("Avanza");
        }

    }

    public class Avion : Transporte
    {

        public override void Avanzar()
        {
            Console.WriteLine("Vuela");
        }

    }

    public class Caballo : Transporte
    {
        public override void Avanzar()
        {
            Console.WriteLine("Galopa");
        }

    }

    public class Carro : Transporte
    {
        public override void Avanzar()
        {
            Console.WriteLine("Rodando");
        }

    }
    class LeonardoZuniga
    {
        public static void Run()
        {

            bool continuar = true;
            string opcion;

            Avion boeing = new Avion();
            Caballo caballo = new Caballo();
            Carro carro = new Carro();

            Transporte[] transportes = new Transporte[]{ boeing, caballo, carro};

            do
            {
                foreach (Transporte t in transportes) { 
                    t.Avanzar();
                }
                Console.WriteLine("Desea Salir?");

                opcion = Console.ReadLine();
                if (opcion == "Yes")
                {
                    continuar = false;
                }

            } while (continuar == true);




            
        }
    }
}
