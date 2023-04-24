namespace Labs.Lab5;
public interface IFotografo
{
    void Fotografiar();
}

public interface IEstudiante
{
    void Estudiar();
}

public class Adolecente : IFotografo, IEstudiante
{
    public void Fotografiar()
    {
        Console.WriteLine("El adolecente esta fotografiando con el dron");
    }

    public void Estudiar()
    {
        Console.WriteLine("El adolecente esta estudiando en la casa ");
    }
}
internal class JoséPabloProgram
{
    public static void Run()
    {
        Adolecente JoséPablo = new Adolecente();
        JoséPablo.Fotografiar();
        JoséPablo.Estudiar();
    }
}