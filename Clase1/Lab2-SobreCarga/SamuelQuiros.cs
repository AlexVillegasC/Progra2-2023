//using System;

//namespace Clase1.Lab2
//{
//    public class Transporte
//    {
//        public virtual void Avanzar()
//        {
//            Console.WriteLine("Avanzar de forma genérica");
//        }

//        public virtual void Avanzar(int velocidad = 0)
//        {
//            Console.WriteLine("Avanzar de forma genérica a velocidad: " + velocidad);
//        }
//    }

//    public class Avion : Transporte
//    {
//        public override void Avanzar()
//        {
//            Console.WriteLine("Volando!");
//        }

//        public override void Avanzar(int velocidad = 0)
//        {
//            velocidad = velocidad * 5;
//            Console.WriteLine("Volando a velocidad: " + velocidad);
//        }
//    }

//    public class Caballo : Transporte
//    {
//        public override void Avanzar()
//        {
//            Console.WriteLine("Galopando!");
//        }

//        public override void Avanzar(int velocidad = 0)
//        {
//            Console.WriteLine("Galopando a velocidad: " + velocidad);
//        }
//    }

//    public class Carro : Transporte
//    {
//        public override void Avanzar()
//        {
//            Console.WriteLine("Rodando!");
//        }

//        public override void Avanzar(int velocidad = 0)
//        {
//            velocidad = velocidad * 2;
//            Console.WriteLine("Rodando a velocidad: " + velocidad);
//        }
//    }

//    internal class SamuelQuiros
//    {
//        public static void Run()
//        {
//            Transporte[] transportes = new Transporte[3];

//            transportes[0] = new Avion();
//            transportes[1] = new Caballo();
//            transportes[2] = new Carro();

//            foreach (Transporte transporte in transportes)
//            {
//                transporte.Avanzar(1);
//            }
//        }
//    }
//}
