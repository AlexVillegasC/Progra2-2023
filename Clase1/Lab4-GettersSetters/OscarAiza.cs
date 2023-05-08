using Labs.Lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab4_GettersSetters
{
    public class Carro
    {
        private string _marca;
        private bool _toyota;

        Carro() { }

        Carro(string marca, bool toyota) {
            _marca = marca;
            _toyota = toyota;
        }

        public string Marca { 

            get { return _marca; } 
            set { _marca = value; } 
        }

        public bool getToyota()
        {
            return _toyota;
        }

        public void setToyota(bool toyota) 
        {
            _toyota = toyota;
        }

        public class OscarAiza {
            public static void Run()
            {
                // 1st Example:
                Carro carro = new Carro();
                carro.Marca = "Scott";
                carro.setToyota(true);
                Console.WriteLine("Marca: " + carro.Marca);
                Console.WriteLine("toyota: " + carro.getToyota);

            }
        }


    }
}
