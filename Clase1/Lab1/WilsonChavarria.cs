using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labs.Lab1.WilsonChavarria;

namespace Labs.Lab1
{
    internal class WilsonChavarria
    {
        public abstract class Persona
        {
            public string? Nombre { get; set; }

            public abstract string Saludar();
        }
        public class Alumno : Persona
        {
            public Alumno(string nombre)
            {
                this.Nombre = nombre;
            }
            public override string Saludar()
            {
                string saludo = "Hola, mi nombre es " + this.Nombre + " y soy un alumno";
                return saludo;
            }
        }


        public class Empleado : Persona
        {
            public Empleado(string nombre)
            {
                this.Nombre = nombre;
            }
            public override string Saludar()
            {
                string saludo = "Hola, mi nombre es " + this.Nombre + " y soy un empleado";
                return saludo;
            }
        }
    }


    namespace Labs.Lab1
    {
        class Program
        {
            static void Main(string[] args)
            {

                Persona[] personas = new Persona[2];
                personas[0] = new Alumno("Jaime Correa");
                personas[1] = new Empleado("Juan Perez");
                for (int i = 0; i < personas.Length; i++)
                {
                    Console.WriteLine(personas[i].Saludar());
                }
            }
        }
    }
}
