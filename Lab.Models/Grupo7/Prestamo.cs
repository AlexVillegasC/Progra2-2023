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
}

