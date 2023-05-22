using Lab.Models.Grupo0;

WeatherSummary weatherSummary = new WeatherSummary();

weatherSummary.Temperature = new List<Temperature>();

Temperature primerMedida = new Temperature();
primerMedida.Date = DateTime.Now;
primerMedida.TemperatureC = 35;
primerMedida.Summary = "hace calor";

weatherSummary.Temperature.Add(primerMedida);

Console.WriteLine(weatherSummary.Temperature[0].Summary);