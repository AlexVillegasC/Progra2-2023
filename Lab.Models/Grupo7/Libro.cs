using System;
namespace Lab.Models.Grupo7
{

    public class Libro
    {
        private int id;
        private string categoria;
        private string editorial;
        private string autor;

        public Libro()
        {
            id = 150918;
            categoria = "Novela";
            editorial = "Santillana";
            autor = "Miguel De Cervantes";
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
}

