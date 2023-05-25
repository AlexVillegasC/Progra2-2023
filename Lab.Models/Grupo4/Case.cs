using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Models.Grupo4
{
    public class Case
    {
        public int Id;
        public string Nombre;
        public double Tamanno;
        public string Color;
        public decimal Costo;
        public string Forma;

        public Case(int id, string nombre, double tamanno, string color, decimal costo, string forma)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Tamanno = tamanno;
            this.Color = color;
            this.Costo = costo;
            this.Forma = forma;
        }

        public Case()
        {
        }
    
        public int GetId() { return Id; }
        public string GetNombre() { return Nombre; }
        public double GetTamanno() { return Tamanno; }
        public string GetColor() { return Color; }
        public decimal GetCosto() { return Costo; }
        public string GetForma() { return Forma; }

        public void SetId(int id) { this.Id = id; }
        public void SetNombre(string nombre) { this.Nombre = nombre; }
        public void SetTamanno(double tamanno) { this.Tamanno = tamanno; }
        public void SetColor(string color) { this.Color = color; }
        public void SetCosto(decimal costo) { this.Costo = costo; }
        public void SetForma(string forma) { this.Forma = forma; }
       

    }
}
