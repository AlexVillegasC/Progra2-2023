namespace Labs.Lab4;

public class Persona
{
    private string _Cedula;
    private string _Numero;


    public Persona() { }

    public Persona(string Cedula, string Numero)
    {
        _Cedula = Cedula;
        _Numero = Numero;
    }

    public string Cedula
    {
        get { return _Cedula; }
        set { _Cedula = value; }
    }

    public string Numero
    {
        get { return _Numero; }

        set
        {
            if (!value.Equals(""))
            {
                _Numero = value;
            }
        }
    }
}
public class SofiaSanchezProgram
{
    public static void Run()
    {
        // 1st Example:
        Persona person1 = new Persona();
        person1.Cedula= "504560592";
        person1.Numero = "87540716";
        Console.WriteLine("Cedula: " + person1.Cedula);
        Console.WriteLine("Numero: " + person1.Numero);

        // 2nd Example:
        Persona person2 = new Persona("Sofia", "Sanchez");
        Console.WriteLine("Cedula: " + person2.Cedula);
        Console.WriteLine("Numero: " + person2.Numero);
    }
}
