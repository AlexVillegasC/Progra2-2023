// CleanArchitectureJson.Infrastructure/FileRepository.cs
using Newtonsoft.Json;

namespace Infrastructure.Shared.Files;

public class FileRepository : IFileRepository
{
    public async Task<T> ReadJsonFileAsync<T>(string filePath)
    {
        using StreamReader reader = new StreamReader(filePath);
        string json = await reader.ReadToEndAsync();
        return JsonConvert.DeserializeObject<T>(json);
    }

    public async Task WriteJsonFileAsync<T>(string filePath, T data)
    {
        string json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
        using StreamWriter writer = new StreamWriter(filePath);
        await writer.WriteAsync(json);
    }
}

