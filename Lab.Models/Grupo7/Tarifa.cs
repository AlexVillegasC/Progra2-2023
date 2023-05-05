public class Tarifa
{
    private String nombre;
    private double precio;
    private String descripcion;

    public Tarifa(String nombre, double precio, String descripcion)
    {
        this.nombre = nombre;
        this.precio = precio;
        this.descripcion = descripcion;
    }

    @Override
    public String toString()
    {
        return nombre + ": $" + precio + "\n" + descripcion;
    }
}