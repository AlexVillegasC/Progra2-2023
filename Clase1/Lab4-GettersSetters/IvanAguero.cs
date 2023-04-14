using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab4_GettersSetters
{
    public class Estudiante
    {
        private string _Nombre;
        private string _Carrera;


        public Estudiante() { }

        public Estudiante(string Nombre, string Carrera)
        {
            _Nombre = Nombre;
            _Carrera = Carrera;
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Carrera
        {
            get { return _Carrera; }

            set
            {
                if (!value.Equals(""))
                {
                    _Carrera = value;
                }
            }
        }
    }

    public class IvanAgueroP
    {
        public static void Run()
        {
            // Ejemplo 1:
            Estudiante estudiante1 = new Estudiante();
            estudiante1.Nombre = "Julio.";
            estudiante1.Carrera = "Turismo.";
            Console.WriteLine("Nombre del estudiante: " + estudiante1.Nombre);
            Console.WriteLine("Carrera de estudiante : " + estudiante1.Carrera);

            // Ejemplo 2:
            Estudiante estudiante2 = new Estudiante("Maria", "Ingenieria");
            Console.WriteLine("Nombre del estudiante: " + estudiante2.Nombre);
            Console.WriteLine("Carrera del estudiante: " + estudiante2.Carrera);
        }
    }

}
