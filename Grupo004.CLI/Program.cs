

using Lab.Models.Grupo4;

CPU cpu = new CPU();

cpu.Case = new List<Case>();
cpu.T_Grafica = new List<T_Grafica>();
cpu.Almacenamiento = new List<Almacenamiento>();

Case dato1 = new Case();
{
    dato1.Id = 01;
    dato1.Nombre = "Lian Li";
    dato1.Tamanno = 2.5;
    dato1.Color = "Blanco";
    dato1.Costo = 130000;
    dato1.Forma = "Cuadrado";
}
cpu.Case.Add(dato1);
Console.WriteLine(cpu.Case[0].Color);