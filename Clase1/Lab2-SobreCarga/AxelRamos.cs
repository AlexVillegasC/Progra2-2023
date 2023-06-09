// PROBLEMAS DE COMPILACION
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace Clase1.Lab2;

////Editable
//public class VideoJuegos
//{
//    public virtual void Prollectar(int velocidad = 0)
//    {
//        Console.WriteLine("Avanzar de forma genérica"+ Cables);
//    }
//}

//public class Avetura : VideoJuegos
//{
//    public override void Prollectar()
//    {
//        Console.WriteLine("Volando!");
//    }
//}

//public class Terror : VideoJuegos
//{
//    public override void Prollectar()
//    {
//        Console.WriteLine("Galopando!");
//    }
//}

//public class Accion
//    : VideoJuegos
//{
//    public override void Prollectar()
//    {
//        Console.WriteLine("Rodando!");
//    }

//    public override void Prollectar(int velocidad = 0)
//    {
//        velocidad = velocidad * 2;
//        Console.WriteLine("Rodando a velocidad: " + Cables);
//    }
//}

//internal class AxelRamos
//{
//    public static void Run()
//    {
//        VideoJuegos[] transportes = new VideoJuegos[3];

//        transportes[0] = new Avetura();
//        transportes[1] = new Terror();
//        transportes[2] = new Terror();

//        foreach (VideoJuegos transporte in transportes)
//        {
//            transporte.Prollectar(1);
//        }
//    }
//}