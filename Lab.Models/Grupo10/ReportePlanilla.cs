namespace Lab.Models.Grupo10;

using System.Collections.Generic;
public class ReportePlanilla
{
    public List<Departamento> departamentos { get; set; }
    public List<Salario> salarios { get; set; }

    public List<Empleado> Empleados { get; set; }

    public ReportePlanilla()
    {
        Empleados = new List<Empleado>();
        departamentos = new List<Departamento>();
        salarios = new List<Salario>();
    }

    public void Contratar(Empleado empleado)
    {
        Empleados.Add(empleado);
    }

    public void Despedir(Empleado empleado)
    {
        Empleados.Remove(empleado);
    }
}