using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab1
{
    public class Zoologico
    {
        public string nombre;
        public int capacidad;

        public void MostrarInfoZoologico()
        {
            Console.WriteLine("Nombre del zoologico: " + nombre);
            Console.WriteLine("Capacidad del zoologico: " + capacidad);
        }
    }

    public class Animal
    {
        public string nombre;
        public int edad;
        public string especie;
        public string habitat;

        public void MostrarInfoAnimal()
        {
            Console.WriteLine("Nombre del animal: " + nombre);
            Console.WriteLine("Edad del animal: " + edad);
            Console.WriteLine("Especie del animal: " + especie);
            Console.WriteLine("Habitat del animal: " + habitat);
        }
    }

    public class Mamifero : Animal
    {
        public bool gestacion;
        public string alimento;

        public void MostrarInfoMamifero()
        {
            MostrarInfoAnimal();
            Console.WriteLine("Gestación del mamífero: " + gestacion);
            Console.WriteLine("Alimento del mamífero: " + alimento);
        }
    }

    public class Ave : Animal
    {
        public bool vuela;
        public string plumaje;

        public void MostrarInfoAve()
        {
            MostrarInfoAnimal();
            Console.WriteLine("¿Vuela el ave? " + vuela);
            Console.WriteLine("Plumaje del ave: " + plumaje);
        }
    }

    //Ejemplo de uso
    public class Program
    {
        public static void Main()
        {
            Zoologico zoologico1 = new Zoologico();
            zoologico1.nombre = "Zoologico de New York";
            zoologico1.capacidad = 1000;
        }
    }
}

