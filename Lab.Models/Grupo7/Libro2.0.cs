using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Models.Grupo7
{
    internal class Libro
    {
    }
}

public class Libro
{
    private int id;
    private string categoria;
    private string editorial;
    private string autor;

    public Libro()
    {
        id = 0;
        categoria = "";
        editorial = "";
        autor = "";
    }

    public Libro(int id, string categoria, string editorial, string autor)
    {
        this.id = id;
        this.categoria = categoria;
        this.editorial = editorial;
        this.autor = autor;
    }

    public int getId()
    {
        return id;
    }

    public void setId(int id)
    {
        this.id = id;
    }

    public string getCategoria()
    {
        return categoria;
    }

    public void setCategoria(string categoria)
    {
        this.categoria = categoria;
    }

    public string getEditorial()
    {
        return editorial;
    }

    public void setEditorial(string editorial)
    {
        this.editorial = editorial;
    }

    public string getAutor()
    {
        return autor;
    }

    public void setAutor(string autor)
    {
        this.autor = autor;
    }
}

public class Program
{
    public static void Main()
    {
        Libro miLibro = new Libro();
        miLibro.setId(1);
        miLibro.setCategoria("Novela");
        miLibro.setEditorial("Editorial XYZ");
        miLibro.setAutor("Juan Pérez");

        Console.WriteLine("Id: " + miLibro.getId());
        Console.WriteLine("Categoría: " + miLibro.getCategoria());
        Console.WriteLine("Editorial: " + miLibro.getEditorial());
        Console.WriteLine("Autor: " + miLibro.getAutor());
    }
}


