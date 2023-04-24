namespace Labs.Lab5;

public interface ISuperHeroe
{
    
    void DetenerElCrimen();
    
}

public interface IFotografo1
{
    void TomarFotos();

}

public class PeterParker : ISuperHeroe, IFotografo1
{

    public void DetenerElCrimen()
    {
        Console.WriteLine("Peter Parker esta deteniendo el crimen en NY");
    }


    public void TomarFotos()

    {
        Console.WriteLine("Peter Parker esta fotografiando al Hombre Araña");
    }
}

internal class AaronChavesProgram

{
    public static void Run()
    {
        PeterParker SpiderMan = new PeterParker();
            SpiderMan.DetenerElCrimen();
            SpiderMan.TomarFotos();
    }
}







