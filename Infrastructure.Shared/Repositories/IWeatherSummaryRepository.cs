using Lab.Models.Grupo0;

namespace Infrastructure.Shared.Repositories;

public interface IWeatherSummaryRepository
{
    Task<List<Temperature>> GetTemperatures();

    Task<List<Wind>> GetWinds();

    Task<List<Moisture>> GetMoisture();
}
