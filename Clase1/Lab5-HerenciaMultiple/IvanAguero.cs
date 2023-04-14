using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab5_HerenciaMultiple
{
    public interface ICorredor
    {
        void Correr();
    }

    public interface IComedor
    {
        void Comer();
    }

    public class Pantera : ICorredor, IComedor
    {
        public void Correr()
        {
            Console.WriteLine("La pantera está corriendo.");
        }

        public void Comer()
        {
            Console.WriteLine("La pantera esta comiendo.");
        }
    }

    internal class IvanAgueroP
    {
        public static void Run()
        {
            Pantera Rosa = new Pantera();
            Rosa.Correr();
            Rosa.Comer();
        }
    }

}
