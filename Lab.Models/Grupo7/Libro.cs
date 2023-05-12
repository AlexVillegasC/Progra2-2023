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

        }

        public Libro(int id, string categoria, string editorial, string autor)
        {
            this.id = id;
            this.categoria = categoria;
            this.editorial = editorial;
            this.autor = autor;
        }

        public int Id { get; set; }
        public String Categoria { get; set; }
        public String Editorial { get; set; }
        public String Autor { get; set; }

    }
}

