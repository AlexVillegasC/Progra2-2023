public class Prestamo
{
    private double monto;
    private double tasa;
    private int plazo;

    public Prestamo(double monto, double tasa, int plazo)
    {
        this.monto = monto;
        this.tasa = tasa;
        this.plazo = plazo;
    }

    public double calcularCuota()
    {
        double r = tasa / 100 / 12;
        int n = plazo * 12;
        double cuota = (monto * r) / (1 - Math.pow(1 + r, -n));
        return cuota;
    }
}
