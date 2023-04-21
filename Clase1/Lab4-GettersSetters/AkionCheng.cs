namespace Labs.Lab4;

public class Animal
{
    private string nombre;
    private string raza;
    private int edad;
    private string dueño;

    public Animal() { }

    public Animal(string _nombre, string _raza, int _edad, string _dueño)
    {
        this.nombre = _nombre;
        this.raza = _raza;
        this.edad = _edad;
        this.dueño = _dueño;
    }

    public string _nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public int _edad
    {
        get { return edad; }
        set { edad = value; }
    }
    public string _dueño
    {
        get { return dueño; }
        set { dueño = value; }
    }

    public string _raza
    {
        get { return raza; }

        set
        {
            if (!value.Equals(""))
            {
                raza = value;
            }
        }
    }
}

public class AkionCheng
{
    public static void Run()
    {
        // 1st Example:
        Animal animal = new Animal();
        animal._nombre = "Pacuso";
        animal._raza = "Pug";
        animal._edad = 1;
        animal._dueño = "Akion Cheng";
        Console.WriteLine("Nombre: " + animal._nombre);
        Console.WriteLine("raza: " + animal._raza);
        Console.WriteLine("raza: " + animal._edad);
        Console.WriteLine("raza: " + animal._dueño);

        // 2nd Example:
        Animal animal2 = new Animal();
        animal2._nombre = "pastelito de amor";
        animal2._raza = "pitbull";
        animal2._edad = 3;
        animal2._dueño = "Brayan Ganoza";
        Console.WriteLine("Nombre: " + animal2._nombre);
        Console.WriteLine("raza: " + animal2._raza);
        Console.WriteLine("raza: " + animal2._edad);
        Console.WriteLine("raza: " + animal2._dueño);
    }
}
