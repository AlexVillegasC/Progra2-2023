public class Cliente
{
    private string nombre;
    private string apellidos;
    private int cedula;

    public Cliente()
    {
        // Constructor vacío
    }

    public Cliente(string nombre, string apellidos, int cedula)
    {
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.cedula = cedula;
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Apellidos
    {
        get { return apellidos; }
        set { apellidos = value; }
    }

    public int Cedula
    {
        get { return cedula; }
        set { cedula = value; }
    }
}
