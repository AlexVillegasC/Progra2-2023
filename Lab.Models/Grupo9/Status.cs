using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Models.Grupo9
{

    public class Estatus
    {
        private string codigo;
        private string descripcion;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }



        public void Registrar(string nuevoCodigo, string nuevaDescripcion)
        {
            Codigo = nuevoCodigo;
            Descripcion = nuevaDescripcion;
        }

        public string ObtenerStatusPaquete()
        {
            string status = "";

            if (Codigo == "ENTREGADO")
            {
                status = "El paquete ha sido entregado.";
            }
            else if (Codigo == "EN_TRANSITO")
            {
                status = "El paquete está en tránsito.";
            }
            else if (Codigo == "PENDIENTE")
            {
                status = "El paquete está pendiente de entrega.";
            }
            else
            {
                status = "El estado del paquete es desconocido.";
            }

            return status;
        }
    }


}
