using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Models.GrupoHolaMundo
{
    public class PaqueteInternet
    {
        private double velocidad;
        private double precio;

        public PaqueteInternet() { }

        public PaqueteInternet(double velocidad, double precio)
        {
            this.velocidad = velocidad;
            this.precio = precio;
        }

        public double Velocidad
        {
            get { return velocidad; }
            set { velocidad = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; } 
        }

    }
}
