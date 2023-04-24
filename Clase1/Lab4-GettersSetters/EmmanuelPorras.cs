using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab4;

public class Producto
{
    private int cantidad;

    public int Cantidad
    {
        get { return cantidad; }
        set
        {
            if (value >= 0) // Validación de entrada
            {
                cantidad = value;
            }
            else
            {
                throw new ArgumentException("La cantidad debe ser un número entero positivo.");
            }
        }
    }
}
internal class EmmanuelPorras
{
    public static void Run()
    {

        Producto producto = new Producto();
        producto.Cantidad = -10; // Test.

        producto.Cantidad = 5;

        Console.WriteLine("La cantidad de productos es: {0}", producto.Cantidad);

        {
            throw new NotImplementedException();
        }
    }
}
