using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Lab2;


public class Persona_
{
    public virtual void Caminar()
    {
        Console.WriteLine("Caminando..");
    }

    public virtual void Caminar(int pasos = 0)
    {
        Console.WriteLine("Camina a " + pasos + " pasos por minuto.");

    }

}

public class Bebe : Persona_
{
    public override void Caminar()
    {
        Console.WriteLine("Gatea lento.");
    }

    public override void Caminar(int pasos = 0)
    {
        pasos = pasos * 10;
        Console.WriteLine("Gatea  a " + pasos + " pasos por minuto");
    }
}

public class Ninno : Persona_
{
    public override void Caminar()
    {
        Console.WriteLine("Camina normal.");
    }
    public override void Caminar(int pasos = 0)
    {
        pasos = pasos * 30;
        Console.WriteLine("Camina a " + pasos + " pasos por minuto");
    }
}

public class Joven : Persona_
{
    public override void Caminar()
    {
        Console.WriteLine("Camina rapido y trota.");
    }

    public override void Caminar(int pasos = 0)
    {
        pasos = pasos * 50;
        Console.WriteLine("Camina a " + pasos + " pasos por minuto");
    }
}

public class Adulto : Persona_
{
    public override void Caminar()
    {
        Console.WriteLine("Camina regular.");
    }

    public override void Caminar(int pasos = 0)
    {
        pasos = pasos * 55;
        Console.WriteLine("Camina a " + pasos + " pasos por minuto");
    }
}

public class AdultoMayor : Persona_
{
    public override void Caminar()
    {
        Console.WriteLine("Camina lento y con baston.");
    }

    public override void Caminar(int pasos = 0)
    {
        pasos = pasos * 23;
        Console.WriteLine("Camina a " + pasos + " pasos por minuto");
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
            persona_.Caminar(1);
        }

        Console.ReadKey();
    }
}