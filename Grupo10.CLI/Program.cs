﻿using Infrastructure.Shared.Files;
using Lab.Models.Grupo10;
using Newtonsoft.Json;

ReportePlanilla GetReportePlanilla()

{
    var virtualpath = "../../../../Infrastructure.Shared/DB/grupo10-Empleado.json";
    FileRepository fileRepository = new FileRepository();
    
    List<Empleado> empleados = fileRepository.ReadJsonFileAsync<List<Empleado>>(virtualpath).Result;
    
    ReportePlanilla reportePlanilla = new ReportePlanilla();
    reportePlanilla.Empleados = empleados;
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