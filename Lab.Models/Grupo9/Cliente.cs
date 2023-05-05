using System;


namespace Lab.Models.Grupo9
{
    public class Cliente
   
    {
        public string Nombre;
        public string Direccion;

        public void AgregarCliente(string Nombre, string Direccion)
        {
            this.Nombre = Nombre;
            this.Direccion = Direccion;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Cliente nuevoCliente = new Cliente();
            nuevoCliente.AgregarCliente("Juan", "Calle 123, Ciudad");
            Console.WriteLine("El cliente {0} vive en {1}", nuevoCliente.Nombre, nuevoCliente.Direccion);
        }
    }

}
