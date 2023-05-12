using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Models.Grupo9;

public class Envio
{
    public string Paquete { get; set; }
    public string Status { get; set; }
    public string Cliente { get; set; }

    public Envio(string paquete, string status, string cliente)
    {
        Paquete = paquete;
        Status = status;
        Cliente = cliente;
    }

    public void ActualizarStatus(string nuevoStatus)
    {
        Status = nuevoStatus;
        Console.WriteLine("El estado del envío se ha actualizado a: " + nuevoStatus);
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Información del envío:");
        Console.WriteLine("Paquete: " + Paquete);
        Console.WriteLine("Estado: " + Status);
        Console.WriteLine("Cliente: " + Cliente);
    }
}
