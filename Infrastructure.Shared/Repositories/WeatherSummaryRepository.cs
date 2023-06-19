using Infrastructure.Shared.Files;
using Lab.Models.Grupo0;

namespace Infrastructure.Shared.Repositories;

public class WeatherSummaryRepository : FileRepository, IWeatherSummaryRepository
{
    private const string tempetarureVirtualPath = "../Infrastructure.Shared/DB/grupo0-temperature.json";
    private const string windVirtualPath = "../Infrastructure.Shared/DB/grupo0-wind.json";
    private const string moistureVirtualPath = "../Infrastructure.Shared/DB/grupo0-moisture.json";

    public async Task<List<Temperature>> GetTemperatures() 
    {
        return await ReadJsonFileAsync<List<Temperature>>(tempetarureVirtualPath);  
    }

    public async Task<List<Wind>> GetWinds()
    {
        return await ReadJsonFileAsync<List<Wind>>(windVirtualPath);
    }

    public async Task<List<Moisture>> GetMoisture()
    {
        return await ReadJsonFileAsync<List<Moisture>>(moistureVirtualPath);
    }
}
