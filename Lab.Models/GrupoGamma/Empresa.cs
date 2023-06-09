namespace Lab.Models.GrupoGamma;

public class Empresa
{
    public List<Empleado> Empleado { get; set; }
    public List<Software> Software { get; set; }
    public List<Cliente> Cliente { get; set; }
    public String Nombre { get; set; }
    public String Direccion { get; set; }
    public int Telefono { get; set; }
    public String Correo { get; set; }
}



