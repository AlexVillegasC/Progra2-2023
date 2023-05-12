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

}
