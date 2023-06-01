
using Infrastructure.Shared.Files;

using Lab.Models.Grupo9;
using Newtonsoft.Json;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;


Envio GetEnvio()
{
    var virtualPath = "../../../../Infrastructure.Shared/DB/Grupo9-Cliente.json";
    FileRepository fileRepos = new FileRepository();

    //-string clienteJson = fileRepos.ReadJsonFileAsync<string>(virtualPath).Result;
    List<Cliente> clientes = fileRepos.ReadJsonFileAsync<List<Cliente>>(virtualPath).Result;




    Envio envio = new Envio();
    envio.Clientes = clientes;
    return envio;
}

 Envio envio = GetEnvio();

foreach (var cliente in envio.Clientes)
{
    Console.WriteLine(cliente.Nombre);
    Console.WriteLine(cliente.Direccion);
    Console.WriteLine(cliente.Telefono);

}