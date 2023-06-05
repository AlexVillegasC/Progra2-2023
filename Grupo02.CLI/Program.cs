
using Infrastructure.Shared.Files;
using Lab.Models.Grupo2;
using Newtonsoft.Json;
using System.Collections.Generic;

Inventario GetMyInventario()
{   
    var FrutasVirtualPath = "../../../../Infrastructure.Shared/DB/Grupo02-Frutas.json";
	var BebidasVirtualPath = "../../../../Infrastructure.Shared/DB/Grupo02-Bebidas.json";
	FileRepository fileRepo = new FileRepository();

    List<Frutas> frutas = fileRepo.ReadJsonFileAsync<List<Frutas>>(FrutasVirtualPath).Result;
	List<Bebidas> bebidas = fileRepo.ReadJsonFileAsync<List<Bebidas>>(BebidasVirtualPath).Result;

	Inventario inventario = new Inventario();
    inventario.Frutas = frutas;
    inventario.Bebidas = bebidas;

    return inventario; 
}
 
Inventario myInventario = GetMyInventario();

    
foreach (var frutas in myInventario.Frutas)
{
    Console.WriteLine(frutas.Cantidad);
    Console.WriteLine(frutas.TipodeFruta);
}
foreach (var bebidas in myInventario.Bebidas)
{
	Console.WriteLine(bebidas.Marcas);
	Console.WriteLine(bebidas.TipodeBebida);
}
