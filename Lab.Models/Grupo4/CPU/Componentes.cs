using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab.Models.Grupo4.CPU.CPU;

namespace Lab.Models.Grupo4.CPU.CPU
{
    internal class Componentes
    {
        CPU.Componentes componentes = new CPU.Componentes();
        componentes.motherboard = "ASUS";
componentes.ram = "8GB";
componentes.hardDrive = "1TB";
componentes.powerSupply = "500W";

CPU miCPU = new CPU(componentes);

    }
}
