using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab5_HerenciaMultiple
{
    public interface Correr
    {
        void Correr();
    }

    public interface saltar
    {
        void saltar();
    }

    public class Rana : Correr, saltar
    {
        public void Correr()
        {
            Console.WriteLine("La rana esta Corriendo");
        }

        public void saltar()
        {
            Console.WriteLine("La rana esta Saltando.");
        }
    }

    internal class JosueFernandez
    {
        public static void Run()
        {
            Rana Tommy = new Rana();
            Tommy.saltar();
            Tommy.Correr();
        }
    }
}
