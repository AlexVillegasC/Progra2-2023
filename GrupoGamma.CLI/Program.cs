
using Infrastructure.Shared.Files;
using Lab.Models.GrupoGamma;
using Newtonsoft.Json;

Empresa getMyEmpresa()
{
    var SoftwarevirtualPhat = "../../../../Infrastructure.Shared/DB/grupoGamma-Software.json";
    var ClientevirtualPhat = "../../../../Infrastructure.Shared/DB/grupoGamma-Clientes.json";
    var EmpleadovirtualPhat = "../../../../Infrastructure.Shared/DB/grupoGamma-Empleado.json";
    FileRepository fileRepo = new FileRepository();

    List<Software> softwareList = fileRepo.ReadJsonFileAsync<List<Software>>(SoftwarevirtualPhat).Result;
    List<Lab.Models.GrupoGamma.Cliente> clienteList = fileRepo.ReadJsonFileAsync<List<Lab.Models.GrupoGamma.Cliente>>(ClientevirtualPhat).Result;
    List<Empleado> empleadosList = fileRepo.ReadJsonFileAsync<List<Empleado>>(EmpleadovirtualPhat).Result;

    Empresa empresa = new Empresa();
    empresa.Software = softwareList;
    empresa.Cliente = clienteList;
    empresa.Empleado = empleadosList;
    return empresa;
}

Empresa myEmpresa = getMyEmpresa();
Empresa empresa = new Empresa();
foreach (var cliente in empresa.Cliente)
{
    Console.WriteLine(cliente.Nombre);
    Console.WriteLine(cliente.Id);
    Console.WriteLine(cliente.Telefono);
}

foreach ( var empleado in empresa.Empleado)
{
    Console.WriteLine(empleado.Nombre_emp);
    Console.WriteLine(empleado.id);
    Console.WriteLine(empleado.campo);
    Console.WriteLine(empleado.Telefono_emp);
}

foreach (var software in empresa.Software)
{
    Console.WriteLine(software.Nombre_app);
    Console.WriteLine(software.funcion);
    Console.WriteLine(software.Requerimientos);
    Console.WriteLine(software.fecha_inicio);
    Console.WriteLine(software.fecha_entrega);
        
}