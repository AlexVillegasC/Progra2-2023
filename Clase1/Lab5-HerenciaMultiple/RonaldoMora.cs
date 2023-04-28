namespace Labs.Lab5
{
    public interface IGamer
    {
        void Jugar();
    }

    public interface IProgramador
    {
        void Programar();
    }

    public class Desarrollador : IGamer, IProgramador
    {
        public void Jugar()
        {
            Console.WriteLine("El Desarrollador está jugando.");
        }

        public void Programar()
        {
            Console.WriteLine("El Desarrollador está programando.");
        }
    }


    internal class RonaldoMora
    {
        public static void Run()
        {
            Desarrollador Alex = new Desarrollador();
            Alex.Jugar();
            Alex.Programar();
        }
    }
}
