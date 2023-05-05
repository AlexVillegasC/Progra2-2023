using System;
public class Almacenamiento
    //Test
{
    private int id;
    private string nombre;
    private int capacidad;
    private string dimensiones;
    private double costo;

    public Almacenamiento(int id, string nombre, int capacidad, string dimensiones, double costo)
    {
        this.id = id;
        this.nombre = nombre;
        this.capacidad = capacidad;
        this.dimensiones = dimensiones;
        this.costo = costo;
    }

    public int GetId()
    {
        return this.id;
    }

    public void SetId(int newId)
    {
        this.id = newId;
    }

    public string GetNombre()
    {
        return this.nombre;
    }

    public void SetNombre(string newNombre)
    {
        this.nombre = newNombre;
    }

    public int GetCapacidad()
    {
        return this.capacidad;
    }

    public void SetCapacidad(int newCapacidad)
    {
        this.capacidad = newCapacidad;
    }

    public string GetDimensiones()
    {
        return this.dimensiones;
    }

    public void SetDimensiones(string newDimensiones)
    {
        this.dimensiones = newDimensiones;
    }

    public double GetCosto()
    {
        return this.costo;
    }

    public void SetCosto(double newCosto)
    {
        this.costo = newCosto;
    }
}
