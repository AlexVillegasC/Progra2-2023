
namespace Labs.Lab5;

public interface IEnergia
{
    void Energia();
}

public interface IGasolina
{
    void Gasolina();
}

public class Vehiculo : IEnergia, IGasolina
{
    public void Energia()
    {
        Console.WriteLine("El vehiculo esta usando energia.");
    }

    public void Gasolina()
    {
        Console.WriteLine("El vehivulo esta usando gasolina.");
    }
}

internal class DannyJimenezProgram
{
    public static void Run()
    {
        Vehiculo Bmw = new Vehiculo();
        Bmw.Gasolina();
        Bmw.Energia();
    }
}
