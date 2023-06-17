﻿using Lab.Models.Grupo6;

namespace Infrastructure.Shared.Repositories;

public interface IEnviosRepository
{
    Task<List<Cliente>> GetClientes();
    Task<List<Seguimiento>> GetSeguimientos();
}
