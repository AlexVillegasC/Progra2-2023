using System;


namespace Lab.Models.Grupo9
{
    public class Cliente
   
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public void AgregarCliente(string Nombre, string Direccion)
        {
            this.Nombre = Nombre;
            this.Direccion = Direccion;
        }
    }

}
