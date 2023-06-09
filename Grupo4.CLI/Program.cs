using Infrastructure.Shared.Files;
using Lab.Models.Grupo4;
using Newtonsoft.Json;

        CPU GetCase()
        {
            var virtualPath = "C:\\Users\\yoili\\Documents\\REPOSITORIO PROGRA\\Infrastructure.Shared\\DB\\Grupo4-Case.json";
            FileRepository fileRepo = new FileRepository();

            /*string caseJson = fileRepo. ReadJsonFileAsync<string>(virtualPath).Result;*/
            List <Case> cases = fileRepo.ReadJsonFileAsync<List<Case>>(virtualPath).Result;

           CPU cpu = new CPU ();
           cpu.Cases = cases;
           return cpu;
        }

      CPU cpu = GetCase();

        foreach (var Case in cpu.Cases)
        {
            Console.WriteLine(Case.Id);
            Console.WriteLine(Case.Nombre);
            Console.WriteLine(Case.Tamanno);
            Console.WriteLine(Case.Color);
            Console.WriteLine(Case.Costo);
            Console.WriteLine(Case.Forma);
        }