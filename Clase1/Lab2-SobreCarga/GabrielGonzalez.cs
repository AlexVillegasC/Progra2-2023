using System;
namespace Labs.Lab2_SobreCarga;
public interface IRutina
{
    void MostrarRutina();
}

public interface IPlanAlimenticio
{
    void MostrarPlanAlimenticio();
}

public abstract class EjercicioBase : IRutina, IPlanAlimenticio
{
    protected string rutina;
    protected string planAlimenticio;

    public string Rutina
    {
        get { return rutina; }
        set { rutina = value; }
    }

    public string PlanAlimenticio
    {
        get { return planAlimenticio; }
        set { planAlimenticio = value; }
    }

    public EjercicioBase(string rutina, string planAlimenticio)
    {
        Rutina = rutina;
        PlanAlimenticio = planAlimenticio;
    }

    public abstract void MostrarRutina();

    public abstract void MostrarPlanAlimenticio();
}

public class Ejercicio : EjercicioBase
{
    public Ejercicio(string rutina, string planAlimenticio) : base(rutina, planAlimenticio)
    {
    }

    public override void MostrarRutina()
    {
        Console.WriteLine("Rutina: " + Rutina);
    }

    public override void MostrarPlanAlimenticio()
    {
        Console.WriteLine("Plan alimenticio: " + PlanAlimenticio);
    }
}

public class Calistenia : EjercicioBase
{
    public Calistenia(string rutina, string planAlimenticio) : base(rutina, planAlimenticio)
    {
    }

    public override void MostrarRutina()
    {
        Console.WriteLine("Rutina de Calistenia: " + Rutina);
    }

    public override void MostrarPlanAlimenticio()
    {
        Console.WriteLine("Plan alimenticio para Calistenia: " + PlanAlimenticio);
    }
}

public class Crossfit : EjercicioBase
{
    public Crossfit(string rutina, string planAlimenticio) : base(rutina, planAlimenticio)
    {
    }

    public override void MostrarRutina()
    {
        Console.WriteLine("Rutina de Crossfit: " + Rutina);
    }

    public override void MostrarPlanAlimenticio()
    {
        Console.WriteLine("Plan alimenticio para Crossfit: " + PlanAlimenticio);
    }
}

internal class GabrielGonzalez
{
    public static void Run()
    {
        EjercicioBase gym = new Ejercicio("Rutina de Gym", "Plan alimenticio para Gym");
        EjercicioBase calistenia = new Calistenia("Rutina de Calistenia", "Plan alimenticio para Calistenia");
        EjercicioBase crossfit = new Crossfit("Rutina de Crossfit", "Plan alimenticio para Crossfit");

        MostrarInformacion(gym);
        MostrarInformacion(calistenia);
        MostrarInformacion(crossfit);

        Console.ReadLine();
    }

    public static void MostrarInformacion(IRutina ejercicio)
    {
        ejercicio.MostrarRutina();
    }
}


