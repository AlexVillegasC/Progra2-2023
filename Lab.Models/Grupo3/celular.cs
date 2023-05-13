using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Models.Grupo3
{
    public class Celular
    {
        public List<Bateria> bateria { get; set; }
        public List<Memoria> memoria { get; set; }


        public string Marca { get; set; }
        public string Modelo { get; set; }  
        public string Color { get; set; }
    }   
}
