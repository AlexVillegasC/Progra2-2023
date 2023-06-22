namespace Lab.Models.Grupo10;

public class Salario

{
    
private List<Salario> salarios;

private List<Empleado> empleados { get; set; }

public Salario()
{
    empleados = new List<Empleado>();
}
    public int Id { get; set; }
    public string Roll { get; set; }
    public int Monto { get; set; }
}

