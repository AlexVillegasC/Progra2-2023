using Lab.Models.Grupo10;
using Newtonsoft.Json;
//using System.Text.Json;


ReportePlanilla GetReportePlanilla()
{
    string json = File.ReadAllText("C:/Users/Suare/RiderProjects/Progra2/Infrastructure.Shared/DB/grupo10-reporteplanilla.json");

    Empleado[]? listEmpleados = JsonConvert.DeserializeObject<Empleado[]>(json);
    ReportePlanilla reportePlanilla = new ReportePlanilla();
    reportePlanilla.Empleados = listEmpleados != null ? new List<Empleado>(listEmpleados) : new List<Empleado>();

    return reportePlanilla;
    
    /*string json = File.ReadAllText("C:/Users/Suare/RiderProjects/Progra2/Infrastructure.Shared/DB/grupo10-reporteplanilla.json");

    Empleado[]? listEmpleados = JsonSerializer.Deserialize<Empleado[]>(json);
    ReportePlanilla reportePlanilla = new ReportePlanilla();
    reportePlanilla.Empleados = listEmpleados != null ? new List<Empleado>(listEmpleados) : new List<Empleado>();

    return reportePlanilla;*/
}

ReportePlanilla reportePlanilla = GetReportePlanilla();

foreach(var empleado in reportePlanilla.Empleados)
{ 
    Console.WriteLine("El id del empleado es: " + empleado.Id);
    Console.WriteLine("El nombre del empleado es:" + empleado.Nombre);
    Console.WriteLine("Su departamento es: " + empleado.Departamento?.NombreDepartamento);
    Console.WriteLine("Su roll es: " + empleado.Salario?.Roll);
    Console.WriteLine("Su salario es: " + empleado.Salario?.Monto);
    Console.WriteLine("");
}