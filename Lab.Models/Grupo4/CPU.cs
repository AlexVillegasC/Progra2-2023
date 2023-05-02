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
    private Componentes componentes;

    public CPU(Componentes componentes)
    {
        this.componentes = componentes;
    }

    public void Start()
    {
        // Inicia el encendido del CPU
    }

    public void ShutDown()
    {
        // Apaga el CPU
    }

    public class Componentes
    {
        public string motherboard;
        public string ram;
        public string hardDrive;
        public string powerSupply;
    }
}
