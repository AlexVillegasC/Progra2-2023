namespace Labs.Lab1;

public class Instrumento
    {
        public virtual void Tocar()
        {
            Console.WriteLine("Toque fuerte y claro");
        }
    }

    public class Guitarra : Instrumento
    {
        public override void Tocar()
        {
            Console.WriteLine("Cuerdas nylon");
        }
    }

    public class Piano : Instrumento
    {
        public override void Tocar()
        {
            Console.WriteLine("Teclas");
        }
    }

    public class Bateria : Instrumento
    {
        public override void Tocar()
        {
            Console.WriteLine("Bolillos");
        }
    }


    internal class JosueFernandez
    {

        public static void Run()
        {
            Instrumento[] instrumentos = new Instrumento[3];

            instrumentos[0] = new Guitarra();
            instrumentos[1] = new Piano();
            instrumentos[2] = new Bateria();

            foreach (Instrumento instrumento in instrumentos)
            {
                instrumento.Tocar();
            }
        }
    }

