using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab5_HerenciaMultiple
{
    public interface Camina
    {
        void camina();
    }

    public interface Corre
    {
        void corre();
    }

    public class Persona : Camina, Corre
    {
        public void camina()
        {
            Console.WriteLine("La persona está Caminando.");
        }

        public void corre()
        {
            Console.WriteLine("La persona está corriendo.");
        }
    }

    internal class PriscilaDiaz
    {
        public static void Run()
        {
            Persona persona = new Persona();
            persona.camina();
            persona.corre();
        }
    }
}
