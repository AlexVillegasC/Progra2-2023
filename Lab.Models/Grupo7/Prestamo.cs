using System;

public class Prestamos
{
    private DateTime fechaPréstamo;
    private DateTime fechaDevolución;
    private int idLibro;

    public Cliente Cliente { get; set; }
    public Tarifa Tarifa { get; set; }
   

    public DateTime FechaPréstamo
    {
        get { return fechaPréstamo; }
        set { fechaPréstamo = value; }
    }

    public DateTime FechaDevolución
    {
        get { return fechaDevolución; }
        set { fechaDevolución = value; }
    }

    public int IDLibro
    {
        get { return idLibro; }
        set { idLibro = value; }
    }


    public static void Préstamo(string[] args)
    {
        
        Prestamos prestamo = new Prestamos();

       
        prestamo.FechaPréstamo = DateTime.Now;
        prestamo.FechaDevolución = DateTime.Now.AddDays(14);
        prestamo.IDLibro = 150418;
        prestamo.Cliente = "Luis Gómez";

        
        Console.WriteLine("Fecha de Préstamo: " + prestamo.FechaPréstamo);
        Console.WriteLine("Fecha de Devolución: " + prestamo.FechaDevolución);
        Console.WriteLine("ID del Libro: " + prestamo.IDLibro);
        Console.WriteLine("Cliente: " + prestamo.Cliente);
    }
}

