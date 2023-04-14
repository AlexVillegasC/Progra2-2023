namespace Labs.Lab1;

    public class Hospital
    {
        public virtual void Consultar()
        {
            Console.WriteLine("Atender de forma eficiente");
        }
    }

    public class Cirugía : Hospital
    {
        public override void Consultar()
        {
            Console.WriteLine("Operar");
        }
    }

    public class Odontología : Hospital
    {
        public override void Consultar()
        {
            Console.WriteLine("Calzar muela");
        }
    }

    public class GinecologíaYobstetricia : Hospital
    {
        public override void Consultar()
        {
            Console.WriteLine("Asistir parto");
        }
    }

    internal class SofiaSJ
    {
            public static void Run()
            {
                Hospital[] hospitales = new Hospital[3];

                hospitales[0] = new Cirugía();
                hospitales[1] = new Odontología();
                hospitales[2] = new GinecologíaYobstetricia();

                foreach (Hospital hospital in hospitales)
                {
                    hospital.Consultar();
                }
            }
       


    }

