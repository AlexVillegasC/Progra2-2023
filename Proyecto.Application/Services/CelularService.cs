
using Infrastructure.Shared.Repositories;
using Lab.Models.Grupo3;

namespace Proyecto.Application.Services;

public class CelularService
{
    private readonly ICelularRepository _celularRepository;

    public CelularService(ICelularRepository celularRepository)
    {
        _celularRepository = celularRepository;
    }

    public async Task<Celular> GetMyCelular()
    {
        List<Bateria> baterias = await _celularRepository.GetBaterias();
        List<Memoria> memorias = await _celularRepository.GetMemorias();



        Celular celular = new Celular()
        {
            Baterias = baterias,
            Memorias = memorias
        };

        return celular;
    }
}
