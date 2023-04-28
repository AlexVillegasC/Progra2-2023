namespace Labs.Lab2;

public class AshlyVargasG
{
       public class Animal2
        {
           public virtual void Desplazarse()
           {
            Console.WriteLine("Desplazarse de forma generica ");
           }
    
    
            public virtual void Sonidos(int velocidad = 0)
            {
             Console.WriteLine("Desplazarse de forma genérica a velocidad: " + velocidad);
            }
    }
    
    
    public class Perro : Animal2
    {
        public override void Desplazarse()
        {
            Console.WriteLine("Corriendo!");
        }
    
    
        public override void Desplazarse(int velocidad = 0)
        {
            velocidad = velocidad *3 ;
            Console.WriteLine("Corriendo a una velocidad de: " + velocidad);
        }
    
    }
    
    public class Ave : Animal2
    {
        public override void Desplazarse()
        {
            Console.WriteLine("volando!");
        }
    
        public override void Desplazarse(int velocidad = 0)
        {
            velocidad = velocidad * 4;
            Console.WriteLine("Volando a una velocidad de: " + velocidad);
        }
    
    }
    
    public class Nutria : Animal2
    {
        public override void Desplazarse()
        {
            Console.WriteLine("Nadando!");
        }
    
        public override void Desplazarse(int velocidad = 0)
        {
            velocidad = velocidad * 4;
            Console.WriteLine("Nadando a una velocidad de: " + velocidad);
        }
    }
    
    internal class AshlyVargas
    {
        public static void Run()
        {
            Animal2[] animales = new Animal2[3];
    
            animales[0] = new Perro();
            animales[1] = new Ave();
            animales[2] = new Nutria();
    
            foreach (Animal2 animal in animales)
            {
                animal.Desplazarse();
            }
        }
    }
    

}