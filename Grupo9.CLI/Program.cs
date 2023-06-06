
using Infrastructure.Shared.Files;

using Lab.Models.Grupo9;
using Newtonsoft.Json;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;


Envio GetMiEnvio()
{  
    //Datos del Archivo Json 
    var virtualPath = "../../../../Infrastructure.Shared/DB/Grupo9-Cliente.json";
    var virtualStatusPath = "../../../../Infrastructure.Shared/DB/Grupo9-Status.json";
 
    FileRepository fileRepos = new FileRepository();

    List<Cliente> clientes = fileRepos.ReadJsonFileAsync<List<Cliente>>(virtualPath).Result;
    List<Status> statuses = fileRepos.ReadJsonFileAsync<List<Status>>(virtualStatusPath).Result;






    Envio Mienvio = new Envio();
    Mienvio.Clientes = clientes;
    Mienvio.Statuses= statuses;

    return Mienvio;
}

 Envio envio = GetMiEnvio();

Console.WriteLine("CLIENTE");
Console.WriteLine("");

foreach (var cliente in envio.Clientes)
{
    Console.WriteLine(cliente.Nombre);
    Console.WriteLine(cliente.Direccion);
    Console.WriteLine(cliente.Telefono);

}
Console.WriteLine("");
Console.WriteLine("STATUS");
Console.WriteLine("");

foreach (var status in envio.Statuses)
{
   Console.WriteLine(status.Codigo);
   Console.WriteLine(status.Descripcion);
    
    
}

