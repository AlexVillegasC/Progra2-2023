using System.Threading.Tasks;

namespace Infrastructure.Shared.Files;

public interface IFileRepository
{
    Task<string> ReadJsonFileAsync<T>(string filePath);
    Task WriteJsonFileAsync<T>(string filePath, T data);
}
