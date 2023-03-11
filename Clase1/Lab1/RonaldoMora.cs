using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//definiendo clase abstracta DispositivoElectronico
public abstract class DispositivoElectronico
{

    //Metodo encender   
    public abstract void Encender();
}


//Definiendo clase Televisor
public class Televisor : DispositivoElectronico
{

    //Sobrescreibiendo metodo encender
    public override void Encender()
    {
        Console.WriteLine("El televisor está encendido.");
    }
}


//Definiendo clase Smartphone
public class Smartphone : DispositivoElectronico
{

    //Sobrescreibiendo metodo encender
    public override void Encender()
    {
        Console.WriteLine("El smartphone está encendido.");
    }
}


//Definiendo clase Laptop
public class Laptop : DispositivoElectronico
{
    public override void Encender()
    {
        //Sobrescreibiendo metodo encender
        Console.WriteLine("La laptop está encendida.");
    }
}



namespace Clase1.Lab1
{
    internal class RonaldoMora
    {
        public static void Run()
        {

            //Definiendo arreglo DispositivoElectronico con 3 elementos
            DispositivoElectronico[] dispositivos = new DispositivoElectronico[3];

        //Instanciando objetos de las clases Televisor, Smartphone y Laptop
        dispositivos[0] = new Televisor();
        dispositivos[1] = new Smartphone();
        dispositivos[2] = new Laptop();

        //Llamando al método Encender() en cada objeto.
        foreach (DispositivoElectronico dispositivo in dispositivos)
        {

            dispositivo.Encender();
        }

    Console.ReadKey();
    }


    }
}
