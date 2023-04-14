namespace Clase1.Lab1;
public class Persona_
{
    public virtual void Caminar()
    {
        Console.WriteLine("Caminando..");
    }

}

public class Bebe : Persona_
{
    public override void Caminar()
    {
        Console.WriteLine("Gatea lento.");
    }
}

public class Ninno : Persona_
{
    public override void Caminar()
    {
        Console.WriteLine("Camina normal.");
    }
}

public class Joven : Persona_
{
    public override void Caminar()
    {
        Console.WriteLine("Camina rapido y trota.");
    }
}

public class Adulto : Persona_
{
    public override void Caminar()
    {
        Console.WriteLine("Camina regular.");

    }
}

public class AdultoMayor : Persona_
{
    public override void Caminar()
    {
        Console.WriteLine("Camina lento y con baston.");
    }
}

internal class JoseBaltodanoH
{
    public static void Run()
    {
        Persona_[] personas_ = new Persona_[5];

        personas_[0] = new Bebe();
        personas_[1] = new Ninno();
        personas_[2] = new Joven();
        personas_[3] = new Adulto();
        personas_[4] = new AdultoMayor();

        foreach (Persona_ persona_ in personas_)
        {
            persona_.Caminar();
        }

        Console.ReadKey();

    }
}
