using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Models.Grupo4;
class CPU
{
    private Motherboard motherboard;
    private RAM ram;
    private HardDrive hardDrive;
    private PowerSupply powerSupply;

    public CPU(Motherboard motherboard, RAM ram, HardDrive hardDrive, PowerSupply powerSupply)
    {
        this.motherboard = motherboard;
        this.ram = ram;
        this.hardDrive = hardDrive;
        this.powerSupply = powerSupply;
    }

    public void Start()
    {
        powerSupply.TurnOn();
        motherboard.PowerOn();
        ram.LoadBootProgram(hardDrive.ReadBootSector());
        motherboard.ExecuteProgram();
    }

    public void ShutDown()
    {
        motherboard.PowerOff();
        powerSupply.TurnOff();
    }
}