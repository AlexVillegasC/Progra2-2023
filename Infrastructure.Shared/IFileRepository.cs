
﻿using System.Threading.Tasks;

namespace Infrastructure.Shared.Files;

public interface IFileRepository
{
    Task<T> ReadJsonFileAsync<T>(string filePath);
    Task WriteJsonFileAsync<T>(string filePath, T data);
}