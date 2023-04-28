
namespace Labs.Lab4;

public class Carro
{
    private string _Marca;
    private string _Color;


    public Carro() { }

    public Carro(string Marca, string Color)
    {
        _Marca = Marca;
        _Color = Color;
    }

    public string Marca
    {
        get { return _Marca; }
        set { _Marca = value; }
    }

    public string Color
    {
        get { return _Color; }

        set
        {
            if (!value.Equals(""))
            {
                _Color = value;
            }
        }
    }
}

public class GenesisGomez
{
    public static void Run()
    {
        // 1st Example:
        Carro carro1 = new Carro();
        carro1.Marca = "Toyota";
        carro1.Color = "Blanco";
        Console.WriteLine("Marca: " + carro1.Marca);
        Console.WriteLine("Color: " + carro1.Color);

        // 2nd Example:
        Carro carro2 = new Carro("Honda", "Negro");
        Console.WriteLine("Marca: " + carro2.Marca);
        Console.WriteLine("Color: " + carro2.Color);
    }
}
