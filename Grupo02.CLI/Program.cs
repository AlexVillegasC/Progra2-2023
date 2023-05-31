
using Lab.Models.Grupo2;

Inventario inventario = new Inventario();

inventario.Frutas = new List<Frutas>();

Frutas primerEntrega = new Frutas();

primerEntrega.Cantidad = 10;
primerEntrega.TipoFruta = "verdura";

 inventario.Frutas.Add(primerEntrega);

Console.WriteLine(inventario.Frutas[0].Cantidad);
        