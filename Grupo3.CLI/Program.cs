

using Lab.Models.Grupo3;

Celular GetMyCelular()
{
    // Read from file
}

Celular celular = GetMyCelular();

foreach (var bateria in celular.baterias)
{
    Console.WriteLine(bateria.Capacidad);
    Console.WriteLine(bateria.Porcentaje);
    Console.WriteLine(bateria.Estado);
}

foreach (var memoria in celular.memorias)
{
    Console.WriteLine(memoria.EspacioTotal);
    Console.WriteLine(memoria.EspacioLibre);
    Console.WriteLine(memoria.EspacioUsado);
}