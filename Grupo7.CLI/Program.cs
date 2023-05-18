

using Lab.Models.Grupo7;

Prestamos prestamos = new Prestamos();
prestamos.Libro = new List<Libro>();


Libro ListaLibros = new Libro();
ListaLibros.Categoria = "Novela";
ListaLibros.Editorial = "Santillana";
ListaLibros.Autor = "Miguel De Cervantes";

prestamos.Libro.Add(ListaLibros);

