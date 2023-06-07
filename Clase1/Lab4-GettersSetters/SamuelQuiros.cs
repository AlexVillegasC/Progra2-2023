using System;

namespace Labs.Lab4
{
    public class Animal
    {
        private string nombre;
        private string raza;
        private int edad;
        private string due�o;

        public Animal() { }

        public Animal(string _nombre, string _raza, int _edad, string _due�o)
        {
            this.nombre = _nombre;
            this.raza = _raza;
            this.edad = _edad;
            this.due�o = _due�o;
        }

        public string _nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int _edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string _due�o
        {
            get { return due�o; }
            set { due�o = value; }
        }

        public string _raza
        {
            get { return raza; }
            set
            {
                if (!value.Equals(""))
                {
                    raza = value;
                }
            }
        }
    }

    public class SamuelQuiros
    {
        public static void Run()
        {
            // 1st Example:
            Animal animal = new Animal();
            animal._nombre = "Mechas";
            animal._raza = "Schnauzer";
            animal._edad = 1;
            animal._due�o = "Sam Quiros";
            Console.WriteLine("Nombre: " + animal._nombre);
            Console.WriteLine("Raza: " + animal._raza);
            Console.WriteLine("Edad: " + animal._edad);
            Console.WriteLine("Due�o: " + animal._due�o);

            // 2nd Example:
            Animal animal2 = new Animal();
            animal2._nombre = "Pastelito de amor";
            animal2._raza = "Pitbull";
            animal2._edad = 3;
            animal2._due�o = "Brayan Ganoza";
            Console.WriteLine("Nombre: " + animal2._nombre);
            Console.WriteLine("Raza: " + animal2._raza);
            Console.WriteLine("Edad: " + animal2._edad);
            Console.WriteLine("Due�o: " + animal2._due�o);
        }
    }
}
