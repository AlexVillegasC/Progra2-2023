using Infrastructure.Shared.Repositories;
using Lab.Models.Grupo0;

namespace Proyecto.Application.Services;

public class WeatherSummaryService
{
    private readonly IWeatherSummaryRepository _weatherSummaryRepository;

    public WeatherSummaryService(IWeatherSummaryRepository weatherSummaryRepository)
    {
        _weatherSummaryRepository = weatherSummaryRepository;
    }

    public async Task<WeatherSummary> GetMySummary()
    {
        List<Temperature> temperatures = await _weatherSummaryRepository.GetTemperatures();
        List<Wind> winds = await _weatherSummaryRepository.GetWinds();
        List<Moisture> moisture = await _weatherSummaryRepository.GetMoisture();


        WeatherSummary weatherSummary = new WeatherSummary()
        {
            Temperatures = temperatures,
            Winds = winds,
            Moistures = moisture
        };

        return weatherSummary;
    }
}
