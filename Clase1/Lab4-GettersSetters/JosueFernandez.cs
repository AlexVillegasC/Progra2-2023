using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab4_GettersSetters
{
    public class Celular
    {
        private string _Marca;
        private string _Modelo;
        private int _Numero;


        public Celular() { }

        public Celular(string Marca, string Modelo, int Numero)
        {
            _Marca = Marca;
            _Modelo = Modelo;
            _Numero = Numero;
        }

        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }

        public string Modelo
        {
            get { return _Modelo; }

            set
            {
                if (!value.Equals(""))
                {
                    _Modelo = value;
                }
            }
        }

        public int Numero
        {
            get { return _Numero; }

            set { _Numero = value; }
        }
    }


    internal class JosueFernandez
    {
        public static void Run()
        {
            // 1st Example:
            Celular celular1 = new Celular();
            celular1.Marca = "SAMSUMG";
            celular1.Modelo = "Android 11";
            celular1.Numero = 93890;
            Console.WriteLine("marca: " + celular1.Marca);
            Console.WriteLine("modelo: " + celular1.Modelo);
            Console.WriteLine("numeroTelefono:" + celular1.Numero);

            // 2nd Example:
            Celular celular2 = new Celular();
            Console.WriteLine("marca: " + celular2.Marca);
            Console.WriteLine("modelo: " + celular2.Modelo);
            Console.WriteLine("numeroTelefono:" + celular2.Numero);
        }
    }
}
