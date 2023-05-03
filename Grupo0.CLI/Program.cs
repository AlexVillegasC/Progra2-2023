

using Grupo0.CLI.Services;

WeatherSummaryService weatherSummary = new WeatherSummaryService();
var mySummary = weatherSummary.GetWeatherSummary(1);

foreach(var temperature in mySummary.Temperature) 
{
    Console.WriteLine("Date: "+ temperature.Date);
    Console.WriteLine("Temperature C: "+ temperature.TemperatureC);
}