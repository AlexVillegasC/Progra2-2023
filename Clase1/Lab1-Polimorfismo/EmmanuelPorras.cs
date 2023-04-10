namespace Labs.Lab1;
using System;

public class LineasTelefonicas
{
    public virtual void Plan()
    {
        Console.WriteLine("Plan Base");
    }
}

public class Claro : LineasTelefonicas
{
    public override void Plan()
    {
        Console.WriteLine("Plan Claro");
    }
}

public class Movistar : LineasTelefonicas
{
    public override void Plan()
    {
        Console.WriteLine("Plan Movistar");
    }
}

public class Kolbi : LineasTelefonicas
{
    public override void Plan()
    {
        Console.WriteLine("Plan Kolbi");
    }
}
//Test
public class EmmanuelPorras
{
    public static void Run()
    {
        LineasTelefonicas[] transportes = new LineasTelefonicas[3];

        transportes[0] = new Claro();
        transportes[1] = new Movistar();
        transportes[2] = new Kolbi();



    }


}