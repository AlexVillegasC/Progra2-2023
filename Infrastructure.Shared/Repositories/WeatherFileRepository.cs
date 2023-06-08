using Infrastructure.Shared.Files;
using Lab.Models.Grupo0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Shared.Repositories
{
    public class WeatherFileRepository : FileRepository, IWeatherFileRepository
    {
        private const string TemperatureVirtualPath = "../Infrastructure.Shared/DB/grupo0-temperature.json";
        private const string WindVirtualPath = "../Infrastructure.Shared/DB/grupo0-wind.json";
        private const string MoistureVirtualPath = "../Infrastructure.Shared/DB/grupo0-moisture.json";

        public async Task<List<Temperature>> GetTemperaturesAsync() =>
            await ReadJsonFileAsync<List<Temperature>>(TemperatureVirtualPath);

        public async Task<List<Wind>> GetWindsAsync() =>
            await ReadJsonFileAsync<List<Wind>>(WindVirtualPath);

        public async Task<List<Moisture>> GetMoisturesAsync() =>
            await ReadJsonFileAsync<List<Moisture>>(MoistureVirtualPath);
    }
}
