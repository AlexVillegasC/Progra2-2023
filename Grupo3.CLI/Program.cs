

using Lab.Models.Grupo3;

Celular celular = new Celular();


celular.bateria = new List<Bateria>();
celular.memoria = new List<Memoria>();



Bateria primeraBateria = new Bateria();
primeraBateria.Capacidad = 5000;
primeraBateria.Porcentaje = 80;
primeraBateria.Estado = "Cargado";

Memoria primerMemoria = new Memoria();
primerMemoria.EspacioTotal = 256;
primerMemoria.EspacioLibre = 200;
primerMemoria.EspacioUsado = 56;


celular.bateria.Add(primeraBateria);

Console.WriteLine(celular.bateria[0].Capacidad);
Console.WriteLine(celular.bateria[0].Porcentaje);
Console.WriteLine(celular.bateria[0].Estado);


celular.memoria.Add(primerMemoria);

Console.WriteLine(celular.memoria[0].EspacioTotal);
Console.WriteLine(celular.memoria[0].EspacioUsado);
Console.WriteLine(celular.memoria[0].EspacioLibre);
