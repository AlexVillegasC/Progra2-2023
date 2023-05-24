using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using static Lab.Models.Grupo4.CPU;

namespace Lab.Models.Grupo4;

public class CPU
{
    public Almacenamiento Almacenamiento { get; set; }
    public Case Case { get; set; }
    public Almacenamiento TarjetaGrafica { get; set; }
}

//    CPU miCPU = new CPU();

//    CPU.Almacenamiento = new Almacenamiento();
//    CPU.Case = new Case();
//    CPU.TarjetaGrafica = new Grafica();
//}