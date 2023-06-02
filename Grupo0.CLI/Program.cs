//using Infrastructure.Shared.Files;
//using Lab.Models.Grupo0;
//using Newtonsoft.Json;
//using System.Collections.Generic;

//WeatherSummary GetMySummary()
//{
//    // Read from File          
//    var tempetarureVirtualPath = "../../../../Infrastructure.Shared/DB/grupo0-temperature.json";
//    var windVirtualPath = "../../../../Infrastructure.Shared/DB/grupo0-wind.json";
//    var moistureVirtualPath = "../../../../Infrastructure.Shared/DB/grupo0-moisture.json";
//    FileRepository fileRepo = new FileRepository();

//    List<Temperature> temperatures = fileRepo.ReadJsonFileAsync<List<Temperature>>(tempetarureVirtualPath).Result;
//    List<Wind> winds = fileRepo.ReadJsonFileAsync<List<Wind>>(windVirtualPath).Result;
//    List<Moisture> moistures = fileRepo.ReadJsonFileAsync<List<Moisture>>(moistureVirtualPath).Result;

//    WeatherSummary weatherSummary = new WeatherSummary();
//    weatherSummary.Temperatures = temperatures;
//    weatherSummary.Winds = winds;
//    weatherSummary.Moistures = moistures;

//    return weatherSummary;
//}

//WeatherSummary mySummary = GetMySummary();

//Console.WriteLine("Temperatura");
//foreach (var temperature in mySummary.Temperatures)
//{
//    Console.WriteLine(temperature.Date);
//    Console.WriteLine(temperature.TemperatureC);
//    Console.WriteLine(temperature.TemperatureF);
//    Console.WriteLine(temperature.Summary);
//}

//Console.WriteLine("Viento");
//foreach (var winds in mySummary.Winds)
//{
//    Console.WriteLine(winds.Degree);
//    Console.WriteLine(winds.Speed);
//    Console.WriteLine(winds.Direction);
//}

//Console.WriteLine("Humedad:");
//foreach (var moisture in mySummary.Moistures)
//{
//    Console.WriteLine(moisture.Value);
//    Console.WriteLine(moisture.Unit);
//    Console.WriteLine(moisture.Date);
//}