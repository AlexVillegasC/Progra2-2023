using Infrastructure.Shared.Files;
using Lab.Models.Grupo4;
using Newtonsoft.Json;

        CPU GetCase()
        {
            var virtualPath = "C:\\repo_progra\\Infrastructure.Shared\\DB\\Grupo4-Case.json";
            FileRepository fileRepo = new FileRepository();

            /*string caseJson = fileRepo. ReadJsonFileAsync<string>(virtualPath).Result;*/
            List <Case> cases = fileRepo.ReadJsonFileAsync<List<Case>>(virtualPath).Result;

           CPU cpu = new CPU ();
           cpu.Cases = cases;
           return cpu;
        }

      CPU cpu = GetCase();

        foreach (var box in cpu.Cases)
        {
            Console.WriteLine(box.Id);
            Console.WriteLine(box.Nombre);
            Console.WriteLine(box.Tamanno);
            Console.WriteLine(box.Color);
            Console.WriteLine(box.Costo);
            Console.WriteLine(box.Forma);
        }