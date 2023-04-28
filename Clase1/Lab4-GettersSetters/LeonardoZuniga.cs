using Labs.Lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab4_GettersSetters
{
    public class Bicicleta
    {
        private string _marca;
        private bool _esDeMontana;

        Bicicleta() { }

        Bicicleta(string marca, bool esDeMontana) {
            _marca = marca;
            _esDeMontana = esDeMontana;
        }

        public string Marca { 

            get { return _marca; } 
            set { _marca = value; } 
        }

        public bool getEsDeMontana()
        {
            return _esDeMontana;
        }

        public void setEsDeMontana(bool esDeMontana) 
        {
            _esDeMontana = esDeMontana;
        }

        public class LeonardoZuniga {
            public static void Run()
            {
                // 1st Example:
                Bicicleta bicicleta = new Bicicleta();
                bicicleta.Marca = "Scott";
                bicicleta.setEsDeMontana(true);
                Console.WriteLine("Marca: " + bicicleta.Marca);
                Console.WriteLine("Es de montaña: " + bicicleta.getEsDeMontana);

            }
        }


    }
}
