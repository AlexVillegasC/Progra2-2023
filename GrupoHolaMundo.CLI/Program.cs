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
    alquiler.casa = casas;
    alquiler.cliente = clientes;
    alquiler.paquete = paquetes;

    return alquiler;
}

Alquiler myAlquiler = GetDatosAlquiler();

Console.WriteLine("Casa:");

foreach (var casa in myAlquiler.casa)
{
    Console.WriteLine(casa.habitaciones);
    Console.WriteLine(casa.banos);
    Console.WriteLine(casa.comedor);
    Console.WriteLine(casa.piscina);
}

Console.WriteLine("Cliente:");
foreach (var clientes in myAlquiler.cliente)
{
    Console.WriteLine(clientes.nombre);
    Console.WriteLine(clientes.apellidos);
    Console.WriteLine(clientes.cedula);
}

Console.WriteLine("Paquetes:");

foreach (var paquetes in myAlquiler.paquete)
{
    Console.WriteLine(paquetes.velocidad);
    Console.WriteLine(paquetes.precio);
}




//Alquiler alquiler = new Alquiler();
//alquiler.cliente = new List<Cliente>();

//string nombre, apellidos;
//int cedula;


//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Ingrese los datos de los clientes en el siguiente orden (nombre, apellidos, cedula)", "", "Cliente "+ (i+1));

//    nombre = Console.ReadLine();
//    apellidos = Console.ReadLine();
//    cedula = int.Parse(Console.ReadLine());
//    Cliente cliente = new Cliente() { Nombre = nombre, Apellidos = apellidos, Cedula = cedula };
//    alquiler.cliente.Add(cliente);
//    Console.Clear();
// }




//for (int i = 0; i < 5; i++)
//{
//    int decision;

//    alquiler.calcularTotalBase(i);

//    Console.WriteLine("Cliente " + (i + 1), " ", "Casa " + (i + 1), " ", "Desea agregar un paquete de internet? (1 paran si, 0 para no)");
//    decision = int.Parse(Console.ReadLine());
//    if (decision == 1)
//    {

//    }
//    else
//    {

//    }

//    Console.WriteLine(alquiler.cliente[i]);
//    Console.WriteLine(alquiler.casa[i]);
//}

//Agregar implementación de clases en este archivo. Revisar el codigo comentado en alquiler commo guía

