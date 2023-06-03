
using Infrastructure.Shared.Files;
using Lab.Models.Grupo2;
using Newtonsoft.Json;
using System.Collections.Generic;

Inventario GetMyInventario()
{   
    var virtualPath = "../../../../Infrastructure.Shared/DB/Grupo02-Frutas.json";
    FileRepository fileRepo = new FileRepository();

    List<Frutas> frutas = fileRepo.ReadJsonFileAsync<List<Frutas>>(virtualPath).Result;

    Inventario inventario = new Inventario();
    inventario.Frutas = frutas;
    return inventario; 
}
 
Inventario myInventario = GetMyInventario();

    
foreach (var frutas in myInventario.Frutas)
{
    Console.WriteLine(frutas.Cantidad);
    Console.WriteLine(frutas.TipodeFruta);
}
