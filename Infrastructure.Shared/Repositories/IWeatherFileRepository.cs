using Lab.Models.Grupo0;

namespace Infrastructure.Shared.Repositories
{
    public interface IWeatherFileRepository
    {
        Task<List<Temperature>> GetTemperaturesAsync();
        Task<List<Wind>> GetWindsAsync();
        Task<List<Moisture>> GetMoisturesAsync();
    }
}
