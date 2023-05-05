using System;

class Program
{
    static void Main(string[] args)
    {

    }
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Carrera { get; set; }

        public Cliente(int id, string nombre, string cedula, string carrera)
        {
            Id = id;
            Nombre = nombre;
            Cedula = cedula;
            Carrera = carrera;
        }

        public void SolicitarPrestamo(string mensaje)
        {
            Console.WriteLine("Indique su nombre completo y carrera " + Nombre + " (" + Carrera + ")");
            Console.WriteLine("Mensaje: " + mensaje);
        }

        public override string ToString()
        {
            return "El Cliente" + Id + ": " + Nombre + " (" + Cedula + ")";
        }
    }

}
