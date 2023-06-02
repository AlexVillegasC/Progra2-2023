
using System.ComponentModel;
using System.Text.Json.Serialization;
using Infrastructure.Shared.Files;
using Lab.Models.Grupo9;
using Newtonsoft.Json;



//Read from file

//Paquetes primerPaquete = new Paquetes();


Envio GetMyenvio()
{
    var virtualPath = "../../../../Infrastructure.Shared/DB/Grupo9-Paquete.json";
    FileRepository fileRepo = new FileRepository();

    string paqueteJson = fileRepo.ReadJsonFileAsync<string>(virtualPath).Result;
    List<Paquetes> paquete = JsonConvert.DeserializeObject<List<Paquetes>>(paqueteJson);



    Envio envio = new Envio();
    envio.Paquetes = paquete;

    return envio;
}

Envio envio = GetMyenvio();

foreach (var Paquetes in envio.Paquetes)
   
{
    Console.WriteLine(Paquetes.Codigo);
    Console.WriteLine(Paquetes.Remitente);
    Console.WriteLine(Paquetes.Destinatario);
    Console.Write(Paquetes.Peso);
    Console.WriteLine(Paquetes.Status);
}

