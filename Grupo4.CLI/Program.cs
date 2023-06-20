using Infrastructure.Shared.Files;
using Lab.Models.Grupo4;
using Newtonsoft.Json;

        CPU GetCase()
        {
         // RUTA CASE
         var virtualpathcase = "../../../../Infrastructure.Shared/DB/Grupo4-Case.json";
         FileRepository fileRepoCase = new FileRepository();
            
         //RUTA ALMACENAMIENTO
         var PathStorage = "../../../../Infrastructure.Shared/DB/Grupo4-Almacenamiento.json";
         FileRepository fileRepoStorage = new FileRepository();

          //RUTA T_GRAFICA 
         var PathGraph = "../../../../Infrastructure.Shared/DB/Grupo4-T_Grafica.json";
         FileRepository fileRepoGraph = new FileRepository();


           List<Case> cases = fileRepoCase.ReadJsonFileAsync<List<Case>>(virtualpathcase).Result;
           List<Almacenamiento> almacenamientos = fileRepoStorage.ReadJsonFileAsync<List<Almacenamiento>>(PathStorage).Result;
           List<T_Grafica> graficas = fileRepoGraph.ReadJsonFileAsync<List<T_Grafica>>(PathGraph).Result;

           CPU cpu = new CPU ();
           cpu.Cases = cases;
           cpu.Almacenamientos = almacenamientos;
           cpu.TarjetasGraficas = graficas;
           return cpu;
        }


      CPU cpu = GetCase();
Console.WriteLine("++++++++++++++++++++++++++Cases++++++++++++++++++++++++++++++++++");
foreach (var box in cpu.Cases)
{
    Console.WriteLine(box.Id);
    Console.WriteLine(box.Nombre);
    Console.WriteLine(box.Tamanno);
    Console.WriteLine(box.Color);
    Console.WriteLine(box.Costo);
    Console.WriteLine(box.Forma);
}


Console.WriteLine("++++++++++++++++++++++++++Almacenamientos++++++++++++++++++++++++");
foreach (var box in cpu.Almacenamientos)
{
    Console.WriteLine(box.id);
    Console.WriteLine(box.nombre);
    Console.WriteLine(box.capacidad);
    Console.WriteLine(box.dimensiones);
    Console.WriteLine(box.costo);
}

Console.WriteLine("++++++++++++++++++++++++++Tarjeta Graficas+++++++++++++++++++++++");
foreach (var box in cpu.TarjetasGraficas)
{
    Console.WriteLine(box.id);
    Console.WriteLine(box.nombre);
    Console.WriteLine(box.vram);
    Console.WriteLine(box.conectores);
    Console.WriteLine(box.marca);
    Console.WriteLine(box.costo);
}
