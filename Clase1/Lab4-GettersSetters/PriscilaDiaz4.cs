using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labs.Lab1;

namespace Labs.Lab4_GettersSetters
{
    public class Animal
    {
        private string _Especie;
        private string _Habitad;


        public Animal() { }

        public Animal(string Especie, string Habitad)
        {
            _Especie = Especie;
            _Habitad = Habitad;
        }

        public string Especie
        {
            get { return _Especie; }
            set { _Especie = value; }
        }

        public string Habitad
        {
            get { return _Habitad; }

            set
            {
                if (!value.Equals(""))
                {
                    _Habitad = value;
                }
            }
        }
    }

    public class PriscilaDiaz
    {
        public static void Run()
        {
            // 1st Example:
            Animal Animal1 = new Animal();
            Animal1.Especie = "Jirafa";
            Animal1.Habitad = "Sabana";
            Console.WriteLine("Especie: " + Animal1.Especie);
            Console.WriteLine("Habitad: " + Animal1.Habitad);

            // 2nd Example:
            Animal Animal2 = new Animal("Mono", "Jungla");
            Console.WriteLine("First Name: " + Animal2.Especie);
            Console.WriteLine("Last Name: " + Animal2.Habitad);
        }
    }
}
