using Lab.Models.Grupo7;

Prestamos ListaPrestamos() 
{
    //Datos de archivos JSon
}

Prestamos obtenerPrestamo = ListaPrestamos();

foreach ( var libro in obtenerPrestamo.Libros)
{
    Console.WriteLine(libro.Id);
    Console.WriteLine(libro.Categoria);
    Console.WriteLine(libro.Editorial);
    Console.WriteLine(libro.Autor);
}