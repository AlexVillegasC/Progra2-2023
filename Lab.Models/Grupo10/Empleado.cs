namespace Lab.Models.Grupo10;


public class Empleado
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public Departamento Departamento { get; set; }
    public Salario Salario { get; set; }

    public double ObtenerSalario()
    {
        return Salario.ObtenerSalario();
    }
}