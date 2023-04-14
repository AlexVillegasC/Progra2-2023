using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Clase1.Lab1;

//Editable
public class VideoJuegos
{
    public virtual void Prollectar()
    {
        Console.WriteLine("Avanzar de forma genérica");
    }
}

public class Avetura : VideoJuegos
{
    public override void Prollectar()
    {
        Console.WriteLine("Volando!");
    }
}

public class Terror : VideoJuegos
{
    public override void Prollectar()
    {
        Console.WriteLine("Galopando!");
    }
}

public class Accion
    : VideoJuegos
{
    public override void Prollectar()
    {
        Console.WriteLine("Rodando!");
    }
}

internal class AxelRamos
{
    public static void Run()
    {
        VideoJuegos[] transportes = new VideoJuegos[3];

        transportes[0] = new Avetura();
        transportes[1] = new Terror();
        transportes[2] = new Terror();

        foreach (VideoJuegos transporte in transportes)
        {
            transporte.Prollectar();
        }
    }
}