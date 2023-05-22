namespace Lab.Models.Grupo10;

using System.Collections.Generic;
public class ReportePlanilla
{
    public List<Empleado> Empleados;
    public List<Departamento> Departamentos;
    public List<Salario> Salarios;

    public ReportePlanilla()
    {
        Empleados = new List<Empleado>();
        Departamentos = new List<Departamento>();
        Salarios = new List<Salario>();
    }

    public void Contratar(Empleado empleado)
    {
        Empleados.Add(empleado);
    }

    public void Despedir(Empleado empleado)
    {
        Empleados.Remove(empleado);
    }

    public Empleado? BuscarEmpleado(int id)
    {
        return Empleados.Find(empleado => empleado.Id == id);
    }

    public double CalcularSalarioTotal()
    {
        double totalSalario = 0;
        foreach (Empleado empleado in Empleados)
        {
            totalSalario += empleado.ObtenerSalario();
        }
        return totalSalario;
    }

    public double CalcularSalarioPromedio()
    {
        double totalSalario = CalcularSalarioTotal();
        int numEmpleados = Empleados.Count;
        return totalSalario / numEmpleados;
    }
}