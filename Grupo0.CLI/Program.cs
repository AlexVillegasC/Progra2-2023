using Infrastructure.Shared.Files;
using Lab.Models.Grupo0;
using Newtonsoft.Json;

FileRepository fileRepository = new FileRepository();

WeatherSummary GetWeatherSummary(int weatherType)
{
    if (weatherType == 1)
    {
        var temperatureJson = fileRepository.ReadJsonFileAsync<Temperature>("../../../../Infrastructure.Shared/DB/grupo0-temperature.json").Result;
        List<Temperature> temperatures = JsonConvert.DeserializeObject<List<Temperature>>(temperatureJson);
        WeatherSummary weatherSummary = new WeatherSummary();
        weatherSummary.Temperature = temperatures;
        return weatherSummary;
    }
    else if (weatherType == 2)
    {
        var windJson = fileRepository.ReadJsonFileAsync<Wind>("../../DB/grupo0-wind.json").Result;
        List<Wind> winds = JsonConvert.DeserializeObject<List<Wind>>(windJson);
        WeatherSummary weatherSummary = new WeatherSummary();
        weatherSummary.Wind = winds;
        return weatherSummary;
    }
    else if (weatherType == 3)
    {
        var moistureJson = fileRepository.ReadJsonFileAsync<Moisture>("../../DB/grupo0-moisture.json").Result;
        List<Moisture> moisture = JsonConvert.DeserializeObject<List<Moisture>>(moistureJson);
        WeatherSummary weatherSummary = new WeatherSummary();
        weatherSummary.Moisture = moisture;
        return weatherSummary;
    }
    else
    {
        var temperatureJson = fileRepository.ReadJsonFileAsync<Temperature>("../../DB/grupo0-temperature.json").Result;
        List<Temperature> temperatures = JsonConvert.DeserializeObject<List<Temperature>>(temperatureJson);

        var windJson = fileRepository.ReadJsonFileAsync<Wind>("../../DB/grupo0-wind.json").Result;
        List<Wind> winds = JsonConvert.DeserializeObject<List<Wind>>(temperatureJson);

        var moistureJson = fileRepository.ReadJsonFileAsync<Moisture>("../../DB/grupo0-moisture.json").Result;
        List<Moisture> moistures = JsonConvert.DeserializeObject<List<Moisture>>(temperatureJson);


        var wind = fileRepository.ReadJsonFileAsync<Wind>("../../DB/grupo0-temperature.json");
        var moisture = fileRepository.ReadJsonFileAsync<Moisture>("../../DB/grupo0-temperature.json");

        WeatherSummary weatherSummary = new WeatherSummary();
        weatherSummary.Temperature = temperatures;
        weatherSummary.Wind = winds;
        weatherSummary.Moisture = moistures;
        return weatherSummary;
    }
}

WeatherSummary mySummary = GetWeatherSummary(1);

foreach(var temperature in mySummary.Temperature) 
{
    Console.WriteLine("Date: "+ temperature.Date);
    Console.WriteLine("Temperature C: "+ temperature.TemperatureC);
}