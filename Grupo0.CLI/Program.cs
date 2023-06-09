using Infrastructure.Shared.Files;
using Lab.Models.Grupo0;
using Newtonsoft.Json;

WeatherSummary GetMySummary()
{
    // Read from File          
    var virtualPath = "../../../../Infrastructure.Shared/DB/grupo0-temperature.json";
    FileRepository fileRepo = new FileRepository();

    List<Temperature> temperatures= fileRepo.ReadJsonFileAsync<List<Temperature>>(virtualPath).Result;    

    WeatherSummary weatherSummary = new WeatherSummary();
    weatherSummary.Temperatures = temperatures;
    return weatherSummary;
}

WeatherSummary mySummary = GetMySummary();

foreach (var temperature in mySummary.Temperatures)
{
    Console.WriteLine(temperature.Date);
    Console.WriteLine(temperature.TemperatureC);
    Console.WriteLine(temperature.TemperatureF);
    Console.WriteLine(temperature.Summary);
}