using Infrastructure.Shared.Files;
using Lab.Models.GrupoHolaMundo;
using Newtonsoft.Json;
using System.Collections.Generic;


Alquiler GetDatosAlquiler()
{

    var casasVirtualPath = "../../../../Infrastructure.Shared/DB/grupoHolaMundo-casas.json";
    var clientesVirtualPath = "../../../../Infrastructure.Shared/DB/grupoHolaMundo-clientes.json";
    var paquetesVirtualPath = "../../../../Infrastructure.Shared/DB/grupoHolaMundo-paquetes.json";

    FileRepository fileRepo = new FileRepository();

    List<Casa> casas = fileRepo.ReadJsonFileAsync<List<Casa>>(casasVirtualPath).Result;
    List<Cliente> clientes = fileRepo.ReadJsonFileAsync<List<Cliente>>(clientesVirtualPath).Result;
    List<Paquetes> paquetes = fileRepo.ReadJsonFileAsync<List<Paquetes>>(paquetesVirtualPath).Result;

    Alquiler alquiler = new Alquiler();
    alquiler.Casa = casas;
    alquiler.Cliente = clientes;
    alquiler.PaqueteInternet = paquetes;

    return alquiler;
}

Alquiler myAlquiler = GetDatosAlquiler();

Console.WriteLine("Casa:");

foreach (var casa in myAlquiler.Casas)
{
    Console.WriteLine(casa.habitaciones);
    Console.WriteLine(casa.banos);
    Console.WriteLine(casa.comedor);
    Console.WriteLine(casa.piscina);
}

Console.WriteLine("Cliente:");
foreach (var clientes in myAlquiler.Clientes)
{
    Console.WriteLine(clientes.nombre);
    Console.WriteLine(clientes.apellidos);
    Console.WriteLine(clientes.cedula);
}

Console.WriteLine("Paquetes:");
foreach (var paquetes in myAlquiler.Paquetes)
{
    Console.WriteLine(paquetes.velocidad);
    Console.WriteLine(paquetes.precio);
}