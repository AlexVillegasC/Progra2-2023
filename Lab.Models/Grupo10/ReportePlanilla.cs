namespace Lab.Models.Grupo10;

using System.Collections.Generic;
public class ReportePlanilla
{
    private List<Empleado> empleados;
    private List<Departamento> departamentos;
    private 

    public ReportePlanilla()
    {
        empleados = new List<Empleado>();
        departamentos = new List<Departamento>();
    }

    public void Contratar(Empleado empleado)
    {
        empleados.Add(empleado);
    }

    public void Despedir(Empleado empleado)
    {
        empleados.Remove(empleado);
    }

    public Empleado BuscarEmpleado(int id)
    {
        return empleados.Find(empleado => empleado.Id == id);
    }

    public double CalcularSalarioTotal()
    {
        double totalSalario = 0;
        foreach (Empleado empleado in empleados)
        {
            totalSalario += empleado.ObtenerSalario().CalcularSalario();
        }
        return totalSalario;
    }

    public double CalcularSalarioPromedio()
    {
        double totalSalario = CalcularSalarioTotal();
        int numEmpleados = empleados.Count;
        return totalSalario / numEmpleados;
    }
}