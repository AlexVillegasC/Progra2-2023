namespace Labs.Lab4;

public class Dron
{
    private string _marca;
    private string _modelo;
    private int _precio;

    public Dron()
    {
    }

    public Dron(string marca, string modelo, int precio)
    {
        _marca = marca;
        _modelo = modelo;
        _precio = precio;
    }
    
    public string Modelo
    {
        get { return _modelo; }
        set { _modelo = value; }
    }
    public int Precio
    {
        get { return _precio; }
        set { _precio = value; }
    }

    public string Marca
    {
        get { return _marca; }

        set
        {
            if (!value.Equals(""))
            {
                _marca = value;
            }
        }
    }
}

public class JoséPabloProgram
{
    public static void Run()
    {
        // 1st Example:
        Dron dron1 = new Dron();
        dron1.Marca = "DJI";
        dron1.Modelo = "Mavic Air 2";
        dron1.Precio = 1000;
        Console.WriteLine("Marca: " + dron1.Marca);
        Console.WriteLine("Modelo: " + dron1.Modelo);
        Console.WriteLine("Precio: " + dron1.Precio);

        // 2nd Example:
        Dron dron2 = new Dron("Autel", "EvoIII", 9000);
        Console.WriteLine("Marca: " + dron2.Marca);
        Console.WriteLine("Modelo: " + dron2.Modelo);
        Console.WriteLine("Precio: " + dron2.Precio);
    }
}