using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab2;


    public class  Instrumento
{
    public virtual void Tocar()
    {
        Console.WriteLine("Tocar con fuerza");
    }

    public virtual void Tocar(int velocidad = 0)
    {
        Console.WriteLine("Tocar a velocidad: " + velocidad);
    }
}

public class Guitarra : Instrumento
{
    public override void Tocar()
    {
        Console.WriteLine("Cuerdas nylon");
    }
    public override void Tocar(int velocidad = 0)
    {
        velocidad = velocidad * 5;
        Console.WriteLine("Tocando a velocidad: " + velocidad);
    }
}

public class Piano : Instrumento
{
    public override void Tocar()
    {
        Console.WriteLine("Teclas");
    }
    public override void Tocar(int velocidad = 0)
    {
        Console.WriteLine("Tocando a velocidad: " + velocidad);
    }
}

public class Bateria : Instrumento
{
    public override void Tocar()
    {
        Console.WriteLine("Bolillos");
    }

    public override void Tocar(int velocidad = 0)
    {
        velocidad = velocidad * 2;
        Console.WriteLine("Tocando a velocidad: " + velocidad);
    }
}


    internal class JOSUE_fernandez
    {
    public static void Run()
    {
        Instrumento[] instrumentos = new Instrumento[3];

        instrumentos[0] = new Guitarra();
        instrumentos[1] = new Piano();
        instrumentos[2] = new Bateria();

        foreach (Instrumento intrumento  in instrumentos)
        {
            intrumento.Tocar(1);
        }
    }
   }

