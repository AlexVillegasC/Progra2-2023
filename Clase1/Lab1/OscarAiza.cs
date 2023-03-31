namespace Labs.Lab1;

public class AnimalZoo
{
    public string nombre;
    public int edad;
    public string especie;
    public string habitat;

    public void MostrarInfoAnimal()
    {
        Console.WriteLine("Nombre del animal: " + nombre);
        Console.WriteLine("Edad del animal: " + edad);
        Console.WriteLine("Especie del animal: " + especie);
        Console.WriteLine("Habitat del animal: " + habitat);
    }
}

public class Mamifero : AnimalZoo
{
    public bool gestacion;
    public string alimento;

    public void MostrarInfoMamifero()
    {
        MostrarInfoAnimal();
        Console.WriteLine("Gestación del mamífero: " + gestacion);
        Console.WriteLine("Alimento del mamífero: " + alimento);
    }
}

public class Ave : AnimalZoo
{
    public bool vuela;
    public string plumaje;

    public void MostrarInfoAve()
    {
        MostrarInfoAnimal();
        Console.WriteLine("¿Vuela el ave? " + vuela);
        Console.WriteLine("Plumaje del ave: " + plumaje);
    }
}

public class Zoologico
{
    public string nombre;
    public int capacidad;

    public void MostrarInfoZoologico()
    {
        Console.WriteLine("Nombre del zoologico: " + nombre);
        Console.WriteLine("Capacidad del zoologico: " + capacidad);
    }
}

//Ejemplo de uso
public class OscarAiza
{
    public static void Run()
    {
        Zoologico zoologico1 = new Zoologico();
        zoologico1.nombre = "Zoologico de New York";
        zoologico1.capacidad = 1000;
    }
}

