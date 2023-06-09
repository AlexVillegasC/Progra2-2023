namespace Lab.Models.Grupo10;

using System.Collections.Generic;
public class ReportePlanilla
{
    public List<Departamento> departamentos;
    public List<Salario> salarios;

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

    //LINQ (Language-Integrated Query) es una característica de C# que proporciona una forma unificada de consultar
    //y manipular datos desde diversas fuentes de datos, como colecciones, bases de datos, servicios web, etc.
    public double SalarioTotal => Empleados.Sum(empleado => empleado.Salario?.Monto ?? 0);

    public double SalarioPromedio => Empleados.Any() ? SalarioTotal / Empleados.Count : 0;

}