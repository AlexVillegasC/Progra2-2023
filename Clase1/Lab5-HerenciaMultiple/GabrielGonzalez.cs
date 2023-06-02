using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab5_HerenciaMultiple;
using System;

public interface IRutina
{
    void MostrarRutina();
}

public interface IPlanAlimenticio
{
     void MostrarPlanAlimenticio();
}

public class EjercicioBase : IRutina, IPlanAlimenticio
{
    private string rutina;
    private string planAlimenticio;

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

    public void MostrarRutina()
    {
        Console.WriteLine("Rutina: " + Rutina);
    }

    public void MostrarPlanAlimenticio()
    {
        Console.WriteLine("Plan alimenticio: " + PlanAlimenticio);
    }
}

public class Ejercicio : EjercicioBase
{
    public Ejercicio(string rutina, string planAlimenticio) : base(rutina, planAlimenticio)
    {
    }
}

public class Calistenia : EjercicioBase
{
    public Calistenia(string rutina, string planAlimenticio) : base(rutina, planAlimenticio)
    {
    }
}

public class Crossfit : EjercicioBase
{
    public Crossfit(string rutina, string planAlimenticio) : base(rutina, planAlimenticio)
    {
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

    public static void MostrarInformacion(IPlanAlimenticio ejercicio)
    {
        ejercicio.MostrarPlanAlimenticio();
    }
}


