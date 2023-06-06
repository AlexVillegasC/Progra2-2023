
using Infrastructure.Shared.Files;

using Lab.Models.Grupo9;
using Newtonsoft.Json;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;


Envio GetEnvio()
{  
    //Datos del Archivo Json 
    var virtualPath = "../../../../Infrastructure.Shared/DB/Grupo9-Cliente.json";
    var virtualStatusPath = "../../../../Infrastructure.Shared/DB/Grupo9-Status.json";
 
    FileRepository fileRepos = new FileRepository();


    string clienteJson = fileRepos.ReadJsonFileAsync<string>(virtualPath).Result;
    string statusJson = fileRepos.ReadJsonFileAsync<string>(virtualStatusPath).Result;
    



    List<Cliente> clientes = JsonConvert.DeserializeObject <List<Cliente>>(clienteJson);
    List<Estatus> estatus = JsonConvert.DeserializeObject< List<Estatus>>(statusJson);
    




    Envio envio = new Envio();
    envio.Clientes = clientes;
    envio.Status= estatus;

    return envio;
}

 Envio envio = GetEnvio();

foreach (var cliente in envio.Clientes)
{
    Console.WriteLine(cliente.Nombre);
    Console.WriteLine(cliente.Direccion);
    Console.WriteLine(cliente.Telefono);

}

foreach(var status in envio.Status)
{
    Console.WriteLine(status.Codigo);
    Console.WriteLine(status.Descripcion);
    
    

}

