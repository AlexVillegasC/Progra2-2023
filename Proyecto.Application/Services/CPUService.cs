
using Infrastructure.Shared.Repositories;
using Lab.Models.Grupo4;
using System.Collections.Generic;

namespace Proyecto.Application.Services;

public class CPUService
{
    private readonly ICPURepository _CPURepository;

    public CPUService(ICPURepository _CPURepository)
    {
        _CPURepository = _CPURepository;
    }

    public async Task<CPU> GetCPU()
    {

         List<Case> cases = await _CPURepository.GetCase();
         List <Almacenamiento> almacenamientos = await _CPURepository.GetAlmacenamiento();
         List <T_Grafica> t_Graficas = await _CPURepository.GetT_Grafica();


        CPU cpu = new CPU()
        {
            Cases = cases,
            Almacenamientos = almacenamientos,
            T_Graficas = t_Graficas,
        };

            return cpu;
    }
}
