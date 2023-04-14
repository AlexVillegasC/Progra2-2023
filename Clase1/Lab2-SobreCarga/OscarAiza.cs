namespace Labs.Lab2;


public class avion
{
    public virtual void Avanzar()
    {
        Console.WriteLine("Avanzar de forma general");
    }
    public virtual void Avanzar(int velocidad = 8)
    {
        Console.WriteLine("Avanzar de forma general a velocidad: " + velocidad);
    }

}



public class jet : avion
{
    public override void Avanzar()
    {
        Console.WriteLine("Estoy pilotando un jet ...");
    }
    public override void Avanzar(int velocidad = 280)
    {
        velocidad = velocidad * 2;
        Console.WriteLine("Avanzar a velocidad: " + velocidad);
    }

}

public class Carga : avion
{
    public override void Avanzar()
    {
        Console.WriteLine("Estoy conduciendo un avion de carga...");
    }
    public override void Avanzar(int velocidad = 150)
    {
        velocidad = velocidad * 2;
        Console.WriteLine("volando a velocidad: " + velocidad);
    }
}

public class combate : avion
{
    public override void Avanzar()
    {
        Console.WriteLine("Estoy volando un avion de carga...");
    }
    public override void Avanzar(int velocidad = 160)
    {
        velocidad = velocidad * 2;
        Console.WriteLine("Avanzar a velocidad: " + velocidad);
    }
}




internal class Oscar
{
    public static void Run()
    {
        avion[] aviones = new avion[3];
        aviones[0] = new jet();
        aviones[1] = new Carga();
        aviones[2] = new combate();

        foreach (avion avion in aviones)
        {
            avion.Avanzar(200);
        }

    }
}
