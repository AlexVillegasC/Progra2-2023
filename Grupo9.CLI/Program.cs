
using Lab.Models.Grupo9;

Envio envio = new Envio();

envio.Cliente = new List<Cliente>();
envio.Paquetes = new  List<Paquetes>();
envio.Status = new List<Estatus>();


Cliente primerCliente = new Cliente();
primerCliente.Nombre = "Priscila Diaz";
primerCliente.Direccion = "Quebrada Honda, Nicoya";

envio.Cliente.Add(primerCliente);

Console.WriteLine(envio.Cliente[0].Nombre);
