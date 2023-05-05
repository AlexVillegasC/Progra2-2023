using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Models.Grupo3
{
    internal class celular
    {
        public Bateria bateria { get; set; }
        public Memoria memoria { get; set; }
        public TarjetaSim tarjetaSim { get; set; }

        public string Marca { get; set; }
        public string Modelo { get; set; }  
        public string Color { get; set; }
    }   
}
