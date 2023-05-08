using program

public class Cliente
{
    private string nombre;
    private string matricula;
    private string carrera;

    public Cliente()
    {

    }

    public Cliente(string nombre, string matricula, string carrera)
    {
        this.nombre = nombre;
        this.matricula = matricula;
        this.carrera = carrera;
    }

    public string nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string matricula
    {
        get { return matricula; }
        set { matricula = value; }
    }

    public string carrera
    {
        get { return carrera; }
        set { carrera = value; }
    }
}