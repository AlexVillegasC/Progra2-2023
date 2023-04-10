namespace Labs.Lab2;

public class LineasTelefonicas
{
    public virtual void Plan() { }
    public virtual void Plan(string time)
    {
        Console.WriteLine("Plan Base");
    }
}
// Emmanuel Porras 208570524
public class Claro : LineasTelefonicas
{

    public override void Plan(string time)
    {
        Console.WriteLine("Plan Claro hasta el dia : " + time);
    }
}

public class Movistar : LineasTelefonicas
{
    public override void Plan(string time)
    {
        Console.WriteLine("Plan Movistar hasta el dia : " + time);
    }
}

public class Kolbi : LineasTelefonicas
{
    public override void Plan(string time)
    {
        Console.WriteLine("Plan Kolbi hasta el dia : " + time);
    }
}
//Test
internal class EmmanuelPorras
{
    public static void Run()
    {
        LineasTelefonicas[] transportes = new LineasTelefonicas[3];

        transportes[0] = new Claro();
        transportes[1] = new Movistar();
        transportes[2] = new Kolbi();



    }


}