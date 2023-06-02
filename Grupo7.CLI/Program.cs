using Infrastructure.Shared.Files;
using Lab.Models.Grupo7;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

Prestamos ListaPrestamos() 
{
    //Datos de archivos JSon
    var virtualPath = "../../../../Infrastructure.Shared/DB/grupo7-Libro.json";
    var tarifavirtualPath = "../../../../Infrastructure.Shared/DB/grupo7-Tarifa.json";
    var clientevirtualPath = "../../../../Infrastructure.Shared/DB/grupo7-Cliente.json";
    FileRepository fileRepo = new FileRepository();

    string libroJson = fileRepo.ReadJsonFileAsync<string>(virtualPath).Result;
    string tarifaJson = fileRepo.ReadJsonFileAsync<string>(tarifavirtualPath).Result;
    string clienteJson = fileRepo.ReadJsonFileAsync<string>(clientevirtualPath).Result;
    List<Libro> libros = JsonConvert.DeserializeObject<List<Libro>>(libroJson);
    List<Tarifa> tarifas = JsonConvert.DeserializeObject<List<Tarifa>>(tarifaJson);
    List<Cliente> clientes = JsonConvert.DeserializeObject<List<Cliente>>(clienteJson);

    Prestamos prestamos = new Prestamos();
    prestamos.Libros = libros;
    prestamos.Tarifas = tarifas;
    prestamos.Clientes = clientes;

    return prestamos;

}

Prestamos obtenerPrestamo = ListaPrestamos();

Console.WriteLine("Libros");
foreach ( var libro in obtenerPrestamo.Libros)
{
    Console.WriteLine(libro.Id);
    Console.WriteLine(libro.Categoria);
    Console.WriteLine(libro.Editorial);
    Console.WriteLine(libro.Autor);
}

Console.WriteLine("Tarifas");
foreach (var tarifas in obtenerPrestamo.Tarifas)
{
    Console.WriteLine(tarifas.Id);
    Console.WriteLine(tarifas.CostoDia);
    Console.WriteLine(tarifas.DiasMaximos);
    Console.WriteLine(tarifas.DiasMinimos);
}

Console.WriteLine("Clientes");
foreach (var clientes in obtenerPrestamo.Clientes)
{
    Console.WriteLine(clientes.Nombre);
    Console.WriteLine(clientes.Matricula);
    Console.WriteLine(clientes.Carrera);
}