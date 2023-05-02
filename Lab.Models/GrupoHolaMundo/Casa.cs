public class Casa
{
    private int habitaciones;
    private int banos;
    private int comedor;
    private int piscina;

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
}
