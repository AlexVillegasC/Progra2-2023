using Infrastructure.Shared.Files;
using Lab.Models.Grupo10;
using Newtonsoft.Json;

ReportePlanilla GetReportePlanilla()

{
    var Empleadovirtualpath = "../../../../Infrastructure.Shared/DB/grupo10-Empleado.json";
    var DepartamentovirtualPath = "../../../../Infrastructure.Shared/DB/grupo10-departamento.json";

    FileRepository fileRepository = new FileRepository();
    
    List<Empleado> empleados = fileRepository.ReadJsonFileAsync<List<Empleado>>(Empleadovirtualpath).Result;
    List<Departamento> departamentos = fileRepository.ReadJsonFileAsync<List<Departamento>>(DepartamentovirtualPath).Result;

    
    ReportePlanilla reportePlanilla = new ReportePlanilla();
    reportePlanilla.Empleados = empleados;
    reportePlanilla.departamentos = departamentos;
    
    return reportePlanilla;
}

ReportePlanilla reportePlanilla = GetReportePlanilla();

foreach (var empleado in reportePlanilla.Empleados)
{
    Console.WriteLine("El id del empleado es: " + empleado.Id);
    Console.WriteLine("El nombre del empleado es:" + empleado.Nombre);
    Console.WriteLine("Su departamento es: " + empleado.Departamento?.NombreDepartamento);
    Console.WriteLine("Su roll es: " + empleado.Salario?.Roll);
    Console.WriteLine("Su salario es: " + empleado.Salario?.Monto + "$");
    Console.WriteLine("");
}