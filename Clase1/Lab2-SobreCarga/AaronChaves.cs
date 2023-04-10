namespace Labs.Lab2;




public class Jugador

{
    public virtual void Patear()
    {

        Console.Write("Patear");
    }

    public virtual void Patear(int potencia = 0)
    {
        Console.WriteLine("Patear: " + potencia);
    }
}


public class Portero : Jugador
    {
        public override void Patear()
        {
            Console.WriteLine("Patear para hacer un saque de volea");
        }

        public override void Patear(int potencia = 0)
        {
            potencia = potencia * 5;
            Console.WriteLine("Patear para hacer un saque de volea: " + potencia);
        }
    }


    public class Defensa : Jugador
    {
        public override void Patear()
        {
            Console.WriteLine("Patear para realizar un despeje");
        }
        public override void Patear(int potencia = 0)
        {
            Console.WriteLine("Patear para realizar un despeje: " + potencia);
        }
    }

    public class Mediocampista : Jugador
    {
        public override void Patear()
        {
            Console.WriteLine("Patear para poner un pase de profundidad");
        }
        
        public override void Patear(int potencia = 0)
        {
            Console.WriteLine("Patear para poner un pase de profundidad: " + potencia);
        }
        
    }

    public class Delantero : Jugador
    {
        public override void Patear()
        {
            Console.WriteLine("Patear para hacer un tiro a marco");
        }

        public override void Patear(int potencia = 0)
        {
            potencia = potencia * 2;
            Console.WriteLine("Patear para hacer un tiro a marco: " + potencia);
        }

    }

internal class AaronChaves
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

            jugador.Patear(potencia: 1);

        }
    }
}
    

