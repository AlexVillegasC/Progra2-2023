using System;
namespace EjemploHerenciaMultiple
{
    public interface IMovil
    {
        void Mover();
    }

    public interface ISonoro
    {
        void HacerSonido();
    }

    public class Coche : IMovil, ISonoro
    {
        public void Mover()
        {
            Console.WriteLine("El coche está en movimiento.");
        }

        public void HacerSonido()
        {
            Console.WriteLine("El coche está haciendo un sonido.");
        }
    }

    public class Avion : IMovil, ISonoro
    {
        public void Mover()
        {
            Console.WriteLine("El avión está en el aire.");
        }

        public void HacerSonido()
        {
            Console.WriteLine("El avión está haciendo un ruido.");
        }

        public void Aterrizar()
        {
            Console.WriteLine("El avión está aterrizando.");
        }
    }

    internal class Program
    {
        public static void Main()
        {
            Coche miCoche = new Coche();
            miCoche.Mover();
            miCoche.HacerSonido();

            Avion miAvion = new Avion();
            miAvion.Mover();
            miAvion.HacerSonido();
            miAvion.Aterrizar();
        }
    }
}
