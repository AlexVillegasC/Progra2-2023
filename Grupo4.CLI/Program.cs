

using Lab.Models.Grupo4;

internal class Program
{
    private static void Main(string[] args)
    {
        cpu GetCase()
        {
            var virtualPath = "Infrastructure.Shared\\DB\\Grupo4-Case.json"
            FileRepository fileRepo = new FileRepository();

            string caseJson = fileRepo. ReadJsonFileAsync<string>(virtualPath).Result;
            List <Case> Case = JsonConvert caseJson;

            Cpu cpu = new cpu ();
            cpu.case = case;
            return cpu;
        }

        CPU cpu = new GetCase();

        foreach (var Case in cpu.Cases)
        {
            Console.WriteLine(Case.Id);
            Console.WriteLine(Case.Nombre);
            Console.WriteLine(Case.Tamanno);
            Console.WriteLine(Case.Color);
            Console.WriteLine(Case.Costo);
            Console.WriteLine(Case.Forma);
        }
    }
}