namespace Labs.Lab2
{
    public class Especie
    {
        public virtual void Jugar()
        {
            Console.WriteLine("Jugar ");
        }
    }

    public class Borrego : Especie
    {
        public override void Jugar()
        {
            Console.WriteLine("Jugar con pelota");
        }
    }

    public class Conejo : Especie
    {
        public override void Jugar()
        {
            Console.WriteLine("Jugar con raton");
        }
    }

    public class Tortuga : Especie
    {
        public override void Jugar()
        {
            Console.WriteLine("Jugar con barro");
        }
    }

    public class YoilinCastrillo
    {

        public static void Run()
        {
            Especie[] especies = new Especie[3];

            especies[0] = new Borrego();
            especies[1] = new Conejo();
            especies[2] = new Tortuga();

            foreach (Especie especie in especies)
            {
                especie.Jugar();
            }

        }
    }

}
