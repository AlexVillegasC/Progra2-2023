// Definimos la interfaz ICaminar
public interface ICaminar
{
    void Caminar();
}

// Definimos la interfaz ICorrer
public interface ICorrer
{
    void Correr();
}

// Creamos la clase Vaca que hereda de las interfaces ICaminar e ICorrer
public class Vaca : ICaminar, ICorrer
{
    // Implementamos los métodos de la interfaz ICaminar
    public void Caminar()
    {
        Console.WriteLine("La vaca está caminando");
    }

    // Implementamos los métodos de la interfaz ICorrer
    public void Correr()
    {
        Console.WriteLine("La vaca está corriendo");
    }
}
