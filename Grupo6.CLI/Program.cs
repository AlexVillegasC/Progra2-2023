
Envios envios = new Envios();

envios.clientes = new List<Clientes>();
envios.cotizaciones = new List<Cotizaciones>();
envios.seguimiento = new List<Seguimiento>();


Clientes cliente1 = new Clientes();

cliente1.ID = 504520162;
cliente1.Nombre = "Akion";
cliente1.Apellido = "Cheng";


envios.clientes.Add(cliente1);
Console.WriteLine(envios.clientes[0].ID);

