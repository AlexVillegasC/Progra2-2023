﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Models.Grupo4
{
    public class Case
    {
        int Id;
        string Nombre;
        double Tamanno;
        string Color;
        decimal Costo;

        public Case(int id, string nombre, double tamanno, string color, decimal costo)
        {
            this.Id = id;
            Nombre = nombre;
            Tamanno = tamanno;
            Color = color;
            Costo = costo;
        }
        public int getId() { return Id; }
        public string getNombre() {  return Nombre; }
        public double getTamanno() { return Tamanno; }
        public string getColor() { return Color; }
        public decimal getCosto() {  return Costo; }

        public void setId(int id) { this.Id = id; }
        public void setNombre(string nombre) { this.Nombre = nombre; }
        public void setTamanno(double tamanno) { this.Tamanno = tamanno; }
        public void setColor(string color) {  this.Color = color; }
        public void setCosto(decimal costo) { this.Costo = costo; }



    }
}