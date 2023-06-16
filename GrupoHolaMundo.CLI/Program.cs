using Infrastructure.Shared.Files;
using Lab.Models.GrupoHolaMundo;
using Newtonsoft.Json;
using System.Collections.Generic;


Alquiler GetDatosAlquiler()
{

    var casasVirtualPath = "../../../../Infrastructure.Shared/DB/grupoHolaMundo-casas.json";
    var clientesVirtualPath = "../../../../Infrastructure.Shared/DB/grupoHolaMundo-clientes.json";
    var paquetesVirtualPath = "../../../../Infrastructure.Shared/DB/grupoHolaMundo-paquetes.json";
}

Alquiler myAlquiler = GetDatosAlquiler();

Console.WriteLine("Casa:");

foreach (var casa1 in myAlquiler.casa)
{
    Console.WriteLine(casa1.Habitaciones);
    Console.WriteLine(casa1.Banos);
    Console.WriteLine(casa1.Comedor);
    Console.WriteLine(casa1.Piscina);
}

Console.WriteLine("Cliente:");
foreach (var clientes in myAlquiler.cliente)
{
    Console.WriteLine(clientes.Nombre);
    Console.WriteLine(clientes.Apellidos);
    Console.WriteLine(clientes.Cedula);
}

Console.WriteLine("Paquetes:");
foreach (var paquetes in myAlquiler.paquete)
{
    Console.WriteLine(paquetes.Velocidad);
    Console.WriteLine(paquetes.Precio);
}

