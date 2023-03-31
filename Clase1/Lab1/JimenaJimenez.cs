namespace Labs.Lab1;

public class Formas 
{
    public virtual void Area()
    {
        Console.WriteLine("Calcular");
    }
}

public class Triangulo : Formas
{
    public override void Area()
    {
        Console.WriteLine("Calcular");
    }
}

public class Cuadrado : Formas
{
    public override void Area()
    {
        Console.WriteLine("Calcular");
    }
}

public class Circulo : Formas
{
    public override void Area()
    {
        Console.WriteLine("Calcular");
       
    }
}

internal class JimenaJimenez
{
    public static void Run()
    {
        Formas[] Formas = new Formas[3];

        Formas[0] = new Triangulo();
        Formas[1] = new Cuadrado();
        Formas[2] = new Circulo ();

        foreach (Formas formas in Formas)
        {
         //   Formas.Avanzar();
        }
    }
}


