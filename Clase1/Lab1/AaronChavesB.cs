namespace Clase1.Lab1;

public class Jugador

{
    public virtual void Patear()
    {

        Console.Write("Patear");
    }
    
    }

public class Portero : Jugador
    {
        public override void Patear()
        {
            Console.WriteLine("Patear para hacer un saque de volea");
        }
        
    }

    public class Defensa : Jugador
    {
        public override void Patear()
        {
            Console.WriteLine("Patear para realizar un despeje");
        }
        
    }

    public class Mediocampista : Jugador
    {
        public override void Patear()
        {
            Console.WriteLine("Patear para poner un pase de profundidad");
        }

    }

    public class Delantero : Jugador
    {
        public override void Patear()
        {
            Console.WriteLine("Patear para hacer un tiro a marco");
        }
    }

    internal class AaronChavesB

    {
        public static void Run()
        {

            Jugador[] jugadores = new Jugador[4];

            jugadores[0] = new Portero();
            jugadores[1] = new Defensa();
            jugadores[2] = new Mediocampista();
            jugadores[3] = new Delantero();

            foreach (Jugador jugador in jugadores)
            {

                jugador.Patear();

            }
        }
    }

    

