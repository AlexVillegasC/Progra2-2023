using System;

public class Cliente
{
    private string nombre;
    private string matricula;
    private string carrera;

    public Cliente()
    {

    }

    public Cliente(string nombre, string matricula, string carrera, string autor)
    {
        this.nombre = nombre;
        this.matricula = matricula;
        this.carrera = carrera;
    }

    public int Id { get; set; }
    public String Categoria { get; set; }
    public String Editorial { get; set; }
    public String Autor { get; set; }

}



