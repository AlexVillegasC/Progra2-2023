using Infrastructure.Shared.Files;
using Lab.Models.Grupo4;
using Newtonsoft.Json;

        CPU GetCPU()
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
           cpu.T_Graficas = graficas;
           return cpu;
        }


      CPU cpu = GetCPU();
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
    Console.WriteLine(box.Id);
    Console.WriteLine(box.Forma);    
}

Console.WriteLine("++++++++++++++++++++++++++Tarjeta Graficas+++++++++++++++++++++++");
foreach (var box in cpu.T_Graficas)
{
    Console.WriteLine(box.Id);
    Console.WriteLine(box.Marca);
    Console.WriteLine(box.Vram);
}
