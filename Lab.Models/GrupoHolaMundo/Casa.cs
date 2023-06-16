public class Casa
{
    private int habitaciones;
    private int banos;
    private int comedor;
    private int piscina;
    private double totalBase = 0;

    public Casa()
    {
    }

    public Casa(int habitaciones, int banos, int comedor, int piscina)
    {
        this.habitaciones = habitaciones;
        this.banos = banos;
        this.comedor = comedor;
        this.piscina = piscina;
    }

    public int Habitaciones
    {
        get { return habitaciones; }
        set { habitaciones = value; }
    }

    public int Banos
    {
        get { return banos; }
        set { banos = value; }
    }

    public int Comedor
    {
        get { return comedor; }
        set { comedor = value; }
    }

    public int Piscina
    {
        get { return piscina; }
        set { piscina = value; }
    }


    public void calcularTotalBase()
    {
        int precioBanno = 40;
        int precioComedor = 60;
        int precioPiscina = 200;
        int precioHabitaciones = 50;
        int precioServicios = 100;

        totalBase = (precioBanno * banos) + (precioComedor * comedor) + (precioPiscina * piscina) + (precioHabitaciones * habitaciones) + precioServicios;

    }
}
