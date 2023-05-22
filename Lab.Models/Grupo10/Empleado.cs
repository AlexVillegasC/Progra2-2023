namespace Lab.Models.Grupo10;


public class Empleado
{
    public int Id { get; }
    public string Nombre { get; set; }
    public Departamento? Departamento { get; set; }
    public Salario? Salario { get; }
    public Empleado(int id,string nombre, Departamento? departamento, Salario? salario)
    {
        Id = id;
        Nombre = nombre;
        Departamento = departamento;
        Salario = salario;
    }
    
    public double ObtenerSalario()
    {
        if (Salario != null)
        {
            return Salario.ObtenerSalario();
        }
        else
        {
            throw new Exception("El salario no está asignado.");
        }
    }
}