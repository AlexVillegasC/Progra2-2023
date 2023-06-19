using Infrastructure.Shared.Files;
using Lab.Models.Grupo10;
using Newtonsoft.Json;

ReportePlanilla GetReportePlanilla()

{
    var Empleadovirtualpath = "../../../../Infrastructure.Shared/DB/grupo10-Empleado.json";
    var DepartamentovirtualPath = "../../../../Infrastructure.Shared/DB/grupo10-Departamento.json";
    var SalariovirtualPath = "../../../../Infrastructure.Shared/DB/grupo10-Salario.json";

    FileRepository fileRepository = new FileRepository();
    
    List<Empleado> empleados = fileRepository.ReadJsonFileAsync<List<Empleado>>(Empleadovirtualpath).Result;
    List<Departamento> departamentos = fileRepository.ReadJsonFileAsync<List<Departamento>>(DepartamentovirtualPath).Result;
    List<Salario> salarios = fileRepository.ReadJsonFileAsync<List<Salario>>(SalariovirtualPath).Result;
    
    ReportePlanilla reportePlanilla = new ReportePlanilla();
    reportePlanilla.Empleados = empleados;
    reportePlanilla.departamentos = departamentos;
    reportePlanilla.salarios = salarios;
    
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
Console.WriteLine("La lista de departamentos es: ");
foreach (var departamento in reportePlanilla.departamentos)
    
{
    Console.WriteLine("El id del departamento es " + departamento.IdDepartamento);
    Console.WriteLine("El nombre del departamento es " + departamento.NombreDepartamento);
    Console.WriteLine("");
    
}
Console.WriteLine("La lista de departamentos es: ");
foreach (var salario in reportePlanilla.salarios)
    
{
    
    Console.WriteLine("El id del asalariado es " + salario.Id);
    Console.WriteLine("el roll del asalariado es " + salario.Roll);
    Console.WriteLine("el monto del asalariado es " + salario.Monto);
    Console.WriteLine("");
}
