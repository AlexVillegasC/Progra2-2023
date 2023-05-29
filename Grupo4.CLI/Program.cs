

using Lab.Models.Grupo4;

CPU cpu = new CPU();

cpu.Cases = new List<Case>();
cpu.TarjetaGraficas = new List<T_Grafica>();
cpu.Almacenamientos = new List<Almacenamiento>();

Case dato1 = new Case();
{
    dato1.Id = 01;
    dato1.Nombre = "Lian Li";
    dato1.Tamanno = 2.5;
    dato1.Color = "Blanco";
    dato1.Costo = 130000;
    dato1.Forma = "Cuadrado";
}
cpu.Cases.Add(dato1);
Console.WriteLine(cpu.Cases[0].Color);

foreach (var Case in cpu.Cases)
{
    Console.WriteLine(Case.Id);
    Console.WriteLine(Case.Nombre);
    Console.WriteLine(Case.Tamanno);
    Console.WriteLine(Case.Color);
    Console.WriteLine(Case.Costo);
    Console.WriteLine(Case.Forma);
}

