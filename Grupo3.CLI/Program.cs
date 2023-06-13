
using Infrastructure.Shared.Files;
using Lab.Models.Grupo3;
using Newtonsoft.Json;
using System.Collections.Generic;

Celular GetMyCelular()
{
    // Read from file

    var Bateriavirtualpath = "../../../../Infrastructure.Shared/DB/grupo3-bateria.json";
    var Memoriavirtualpath = "../../../../Infrastructure.Shared/DB/grupo3-memoria.json";


    FileRepository filerepo = new FileRepository();


    List<Bateria> baterias = filerepo.ReadJsonFileAsync<List<Bateria>>(Bateriavirtualpath).Result;
    List<Memoria> memorias = filerepo.ReadJsonFileAsync<List<Memoria>>(Memoriavirtualpath).Result;

    Celular cel1 = new Celular();
    cel1.Baterias = baterias;
    cel1.Memorias = memorias;
    return cel1;


}



Celular celular = GetMyCelular();

foreach (var bateria in celular.Baterias)
{
    
    Console.WriteLine(bateria.Capacidad);
    Console.WriteLine(bateria.Porcentaje);
    Console.WriteLine(bateria.Estado);
}

foreach (var memoria in celular.Memorias)
{   
    Console.WriteLine(memoria.EspacioTotal);
    Console.WriteLine(memoria.EspacioLibre);
    Console.WriteLine(memoria.EspacioUsado);
}