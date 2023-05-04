namespace Lab.Models.Grupo10;

public class HR
{
    public string Nombre;
    public List<Empleado> Empleados;
    public Empleado Gerente;
    public string Ubicacion;
     
    public void Contratar(Empleado empleado)
    {
        Empleados.Add(empleado);
    }
    
    public void Despedir(Empleado empleado)
    {
        Empleados.Remove(empleado);
    }
    
    public void Promover(Empleado empleado)
    {
        Gerente = empleado;
    }
    
    public void CambiarUbicacion(string ubicacion)
    {
        Ubicacion = ubicacion;
    }
    
    public List<Empleado> ObtenerEmpleados()
    {
        return Empleados;
    }
    
    public class Empleado
    {
        public string nombre;
        public int edad;
        public string puesto;
        public float salario;
    }
}