using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Models.GrupoHolaMundo
{
    internal class Alquiler
    {
        private Cliente cliente;
        private Casa casa;
        private double totalBase = 0;
        private double totalCost;

        public Alquiler() { }

        public Alquiler(Cliente cliente, Casa casa) 
        {
            this.cliente = cliente;
            this.casa = casa;
        }

        public Cliente getCliente() { return cliente; }
        public Casa getCasa() {  return casa; }

        public double TotalBase 
        { 
            get 
            {
                if (totalBase > 0)
                {
                    return totalBase;
                }
                else 
                {
                    Exception exception = new Exception("No se ha inicializado el valor del total base");
                    throw exception;
                }
            } 
            set { totalBase = value; }
        
        }

        public double TotalCost 
        {
            get { return totalCost + totalBase; }
        }

        public void setCasa(Casa casa) 
        {
            this.casa = casa;
        }

        public void setCliente(Cliente cliente) 
        { 
            this.cliente = cliente;
        }

        public void agregarInternet (PaqueteInternet paqueteInternet) 
        {
            totalCost = paqueteInternet.Precio * paqueteInternet.Velocidad;
        }

        public void calcularTotalBase() 
        {
            int precioBanno = 40;
            int precioComedor = 60;
            int precioPiscina = 200;
            int precioHabitaciones = 50;
            int precioServicios = 100;

            totalBase = (precioBanno * casa.Banos) +  (precioComedor * casa.Comedor) + (precioPiscina * casa.Piscina) + (precioHabitaciones * casa.Habitaciones) + precioServicios;

        }


    }

    public class GrupoHolaMundo 
    
    { 
        public static void run() 
        {
            Cliente cliente1 = new Cliente("Juan", "Ramírez", 118930456);
            Cliente cliente2 = new Cliente("Fabiola", "Jímenez", 508530456);
            Cliente cliente3 = new Cliente("Kamelia", "Torres", 704930476);

            Casa casaBase = new Casa(3, 1, 1, 0);
            Casa casaAcomodada = new Casa(4, 2, 1, 1);
            Casa casaGrande = new Casa(4, 2, 2, 1);

            PaqueteInternet _5mbs = new PaqueteInternet(5, 1);
            PaqueteInternet _15mbs = new PaqueteInternet(15, 0.75);
            PaqueteInternet _50mbs = new PaqueteInternet(50, 0.5);

            //inicialización de objetos


            Alquiler alquiler1 = new Alquiler(cliente1,casaBase);
            Alquiler alquiler2 = new Alquiler(cliente2,casaAcomodada);
            Alquiler alquiler3 = new Alquiler(cliente3,casaGrande);

            //Gestion de clases


            alquiler1.calcularTotalBase();
            alquiler2.calcularTotalBase();
            alquiler3.calcularTotalBase();


            alquiler1.agregarInternet(_5mbs);
            alquiler3.agregarInternet(_15mbs);

            Console.WriteLine("El precio del primer alquier es "+" "+alquiler1.TotalCost + ".  Al nombre de: " + alquiler1.getCliente().Nombre + " " + alquiler1.getCliente().Apellidos);
            Console.WriteLine("El precio del primer alquier es " + " " + alquiler2.TotalCost + ".  Al nombre de: " + alquiler2.getCliente().Nombre + " " + alquiler2.getCliente().Apellidos);
            Console.WriteLine("El precio del primer alquier es " + " " + alquiler3.TotalCost + ".  Al nombre de: " + alquiler3.getCliente().Nombre + " " + alquiler3.getCliente().Apellidos);
        }
    
    }
}
