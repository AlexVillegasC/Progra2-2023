using Lab.Models.Grupo10;

namespace Infrastructure.Shared.Repositories;

    public interface IReporteRepository
    {
        Task<List<Empleado>> GetEmpleados();
        Task<List<Departamento>> GetDepartamento();
        Task<List<Salario>> GetSalario();

    }
