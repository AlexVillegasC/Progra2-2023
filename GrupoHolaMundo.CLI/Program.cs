// See https://aka.ms/new-console-template for more information

using Lab.Models.GrupoHolaMundo;
using grupoHolaMundo = Lab.Models.GrupoHolaMundo;

Alquiler alquiler = new Alquiler();
alquiler.cliente = new List<Cliente>();

string nombre, apellidos;
int cedula;


for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese los datos de los clientes en el siguiente orden (nombre, apellidos, cedula)", "", "Cliente "+ (i+1));

    nombre = Console.ReadLine();
    apellidos = Console.ReadLine();
    cedula = int.Parse(Console.ReadLine());
    Cliente cliente = new Cliente() { Nombre = nombre, Apellidos = apellidos, Cedula = cedula };
    alquiler.cliente.Add(cliente);
    Console.Clear();
 }




for (int i = 0; i < 5; i++)
{
    int decision;

    alquiler.calcularTotalBase(i);

    Console.WriteLine("Cliente " + (i + 1), " ", "Casa " + (i + 1), " ", "Desea agregar un paquete de internet? (1 paran si, 0 para no)");
    decision = int.Parse(Console.ReadLine());
    if (decision == 1)
    {

    }
    else
    {

    }

    Console.WriteLine(alquiler.cliente[i]);
    Console.WriteLine(alquiler.casa[i]);
}