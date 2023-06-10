using Infrastructure.Shared.Files;
using Lab.Models.Grupo9;


namespace Infrastructure.Shared.Repositories
{
    public class EnviosRepository : FileRepository, IEnviosRepository
    {

        private const string virtualPath = "../Infrastructure.Shared/DB/Grupo9-Cliente.json";
        private const string virtualStatusPath = "../Infrastructure.Shared/DB/Grupo9-Status.json";
        private const string virtualPaquetePath = "../Infrastructure.Shared/DB/Grupo9-Paquete.json";

        public async Task<List<Lab.Models.Grupo9.Cliente>> GetCliente()
        {

            return await ReadJsonFileAsync<List<Lab.Models.Grupo9.Cliente>>(virtualPath);
        }

        public async Task<List<Status>> GetStatus()
        {

            return await ReadJsonFileAsync<List<Status>>(virtualStatusPath);
        }

        public async Task<List<Paquete>> GetPaquete()
        {

            return await ReadJsonFileAsync<List<Paquete>>(virtualPaquetePath);
        }

    }


}

