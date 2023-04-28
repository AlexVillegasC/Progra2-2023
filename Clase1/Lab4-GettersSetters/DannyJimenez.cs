namespace Labs.Lab4;

public class Perro
{
    private string _nombre;
    private string _raza;


    public Perro() { }

    public Perro(string nombre, string raza)
    {
        _nombre = nombre;
        _raza = raza;
    }

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    public string Raza
    {
        get { return _raza; }

        set
        {
            if (!value.Equals(""))
            {
                _raza = value;
            }
        }
    }
}

public class DannyJimenez
{
    public static void Run()
    {

        Perro perro1 = new Perro();
        perro1.Nombre = "Coco";
        perro1.Raza = "Labrador";
        Console.WriteLine("Nombre: " + perro1.Nombre);
        Console.WriteLine("Raza: " + perro1.Raza);


        Perro perro2 = new Perro("Canelo", "Boxer");
        Console.WriteLine("Nombre: " + perro2.Nombre);
        Console.WriteLine("Raza: " + perro2.Raza);
    }
}
