using Infrastructure.Shared.Files;
using Infrastructure.Shared.Repositories;
using Lab.Models.Grupo0;

namespace Proyecto.ApplicationLayer.Services;

public class WeatherSummaryService
{
    private readonly IWeatherFileRepository _weatherRepository;

    public WeatherSummaryService(IWeatherFileRepository weatherRepository)
    {
        _weatherRepository = weatherRepository;
    }

    public async Task<WeatherSummary> GetMySummaryAsync()
    {
        List<Temperature> temperatures = await _weatherRepository.GetTemperaturesAsync();
        List<Wind> winds = await _weatherRepository.GetWindsAsync();
        List<Moisture> moistures = await _weatherRepository.GetMoisturesAsync();

        WeatherSummary weatherSummary = new WeatherSummary
        {
            Temperatures = temperatures,
            Winds = winds,
            Moistures = moistures
        };

        return weatherSummary;
    }
}
