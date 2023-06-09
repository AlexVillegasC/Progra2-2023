using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab5_HerenciaMultiple
{

    public interface IHerenciaMultiple
    {
        void nadar();
    }

    public interface IIHerenciaMultiple 
    {
        void comer();
    }

    public class Pez : IHerenciaMultiple ,  IIHerenciaMultiple
    {
        public void nadar() {
            Console.WriteLine("Esta nadando");
        }

        public void comer()
        {
            Console.WriteLine("Esta comiendo");
        }

    }
    public class LeonardoZuniga
    {
        public static void Run() { 

            Pez pez = new Pez();
            pez.nadar();
            pez.comer();
        
        }

    }
}
