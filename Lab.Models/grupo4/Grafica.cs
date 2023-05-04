using System;
class Grafica
{
    private int id;
    private string nombre;
    private int vram;
    private string conectores;
    private string marca;
    private double costo;

    public Grafica(int id, string nombre, int vram, string conectores, string marca, double costo)
    {
        this.id = id;
        this.nombre = nombre;
        this.vram = vram;
        this.conectores = conectores;
        this.marca = marca;
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

    public int GetVram()
    {
        return this.vram;
    }

    public void SetVram(int newVram)
    {
        this.vram = newVram;
    }

    public string GetConectores()
    {
        return this.conectores;
    }

    public void SetConectores(string newConectores)
    {
        this.conectores = newConectores;
    }

    public string GetMarca()
    {
        return this.marca;
    }

    public void SetMarca(string newMarca)
    {
        this.marca = newMarca;
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
