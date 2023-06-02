using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


  namespace Lab.Models.Grupo9
  {
    public class Paquetes
    {
        public int Codigo { get; set; }
        public string Remitente { get; set; }
        public string Destinatario { get; set; }
        public double Peso { get; set; }
        public string Status { get; set; }




        public void AgregarPaquete(int codigo, string remitente, string destinatario, double peso)
        {
            Codigo = codigo;
            Remitente = remitente;
            Destinatario = destinatario;
            Peso = peso;
            Status = "Circulando";
        }

        public void ActualizarStatus(string nuevoStatus)
        {
            Status = nuevoStatus;
        }
    }


  }


