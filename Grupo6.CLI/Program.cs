
Envios envios = new Envios();

envios.Clientes = new List<Clientes>();
envios.Cotizaciones = new List<Cotizaciones>();
envios.Seguimientos = new List<Seguimientos>();


Clientes cliente1 = new Clientes();

cliente1.ID = 504520162;
cliente1.Nombre = "Akion";
cliente1.Apellido = "Cheng";


envios.clientes.Add(cliente1);


foreach (var Clientes in envios.Clientes)
{
    Console.WriteLine(Clientes.ID);
    Console.WriteLine(Clientes.Nombre);
    Console.WriteLine(Clientes.Apellido);
}



Cotizaciones Cotizacion1 = new Cotizaciones();

Cotizacion1.Tarifa = 4200;
Cotizacion1.Impuesto = 200;
Cotizacion1.Descuento = 50;
Cotizacion1.RangoDeCotizacion = "3KG-4KG";


envios.Cotizaciones.Add(Cotizacion1);


foreach (var Cotizaciones in envios.Cotizaciones)
{
    Console.WriteLine(Cotizaciones.Tarifa);
    Console.WriteLine(Cotizaciones.Impuesto);
    Console.WriteLine(Cotizaciones.Descuento);
    Console.WriteLine(Cotizaciones.RangoDeCotizacion);
}