using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab5;

public interface Volar {
    void Aereo();
}
public interface Navegar {
    void Maritimo();
}
public class Transporte : Volar, Navegar
{
    public void Aereo()
    {
        Console.WriteLine("El transporte es Aereo");
    }

    public void Maritimo()
    {
        Console.WriteLine("El transporte es Maritimo");
    }
}


 internal class EmmanuelPorras
{
    public static void Run()
    {
        Transporte Porras = new Transporte();
        Porras.Aereo();
        Porras.Maritimo();
    }

   
}
   
    

