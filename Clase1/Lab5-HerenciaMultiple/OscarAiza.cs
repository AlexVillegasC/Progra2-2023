using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab5_HerenciaMultiple
{

    public interface IHerencia
    {
        void correr();
    }

    public interface IIHerencia 
    {
        void comer();
    }

    public class Caballo : IHerencia ,  IIHerencia
    {
        public void correr() {
            Console.WriteLine("Esta corriendo");
        }

        public void comer()
        {
            Console.WriteLine("Esta comiendo");
        }

    }
    public class OscarAiza
    {
        public static void Run() { 

            Caballo caballo = new Caballo();
            caballo.correr();
            caballo.comer();
        
        }

    }
}
