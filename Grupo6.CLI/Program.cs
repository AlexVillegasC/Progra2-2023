
using Infrastructure.Shared.Files;
using Lab.Models.Grupo6;
using Newtonsoft.Json;

Envios ObtenerEnvios()
{
    var CliVirtualPath = "../../../../Infrastructure.Shared/DB/grupo06-Clientes.Json";
    var CotVirtualPath = "../../../../Infrastructure.Shared/DB/grupo06-Cotizaciones.Json";
    var SegVirtualPath = "../../../../Infrastructure.Shared/DB/grupo06-Seguimientos.Json";
    FileRepository fileRepository = new FileRepository();

    List<Clientes> clientes = fileRepository.ReadJsonFileAsync<List<Clientes>>(CliVirtualPath).Result;
    List<Cotizaciones> cotizaciones = fileRepository.ReadJsonFileAsync<List<Cotizaciones>>(CotVirtualPath).Result;
    List<Seguimiento> seguimientos = fileRepository.ReadJsonFileAsync<List<Seguimiento>>(SegVirtualPath).Result;

    Envios envios = new Envios();
    envios.Clientes = clientes;
    envios.Cotizaciones = cotizaciones;
    envios.Seguimientos = seguimientos;
    return envios;
}

Envios MisEnvios = ObtenerEnvios();

foreach (var Clientes in MisEnvios.Clientes)
{
    Console.WriteLine(Clientes.ID);
    Console.WriteLine(Clientes.Nombre);
    Console.WriteLine(Clientes.Apellido);
}

foreach (var Cotizaciones in MisEnvios.Cotizaciones)
{
    Console.WriteLine(Cotizaciones.Tarifa);
    Console.WriteLine(Cotizaciones.Impuesto);
    Console.WriteLine(Cotizaciones.Descuento);
    Console.WriteLine(Cotizaciones.RangoDeCotizacion);
}

foreach (var Seguimientos in MisEnvios.Seguimientos)
{
    Console.WriteLine(Seguimientos.IdEnvio);
    Console.WriteLine(Seguimientos.EstadoRuta);
    Console.WriteLine(Seguimientos.IdPaquete);
}