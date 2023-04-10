namespace Labs.Lab1;

public class Celular
{
    public virtual void Encender()
    {
        Console.WriteLine("Encender celular ...");
    }
}

public class Iphone : Celular
{
    public override void Encender()
    {
        Console.WriteLine("Encendiendo Iphone!");
    }
}

public class Samsung : Celular
{
    public override void Encender()
    {
        Console.WriteLine("Encendiendo Samsung!");
    }
}

public class Huawei : Celular
{
    public override void Encender()
    {
        Console.WriteLine("Encendiendo Huawei!");
    }
}

internal class DannyJimenez
{
    public static void Run()
    {
        Celular[] celulares = new Celular[3];

        celulares[0] = new Iphone();
        celulares[1] = new Samsung();
        celulares[2] = new Huawei();

        foreach (Celular celular in celulares)
        {
            celular.Encender();
        }
    }
}
