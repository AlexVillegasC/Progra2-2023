using Lab.Models.Grupo10;

ReportePlanilla reportePlanilla = new ReportePlanilla();
reportePlanilla.empleados = new List<Empleado>();
reportePlanilla.departamentos = new List<Departamento>();
reportePlanilla.Salarios = new List<Salario>();

Empleado empleado1 = new Empleado();
empleado1.Id = 1;
empleado1.Nombre = "Juan";
empleado1.Departamento = new Departamento();
empleado1.Departamento.IdDepartamento = 1;
empleado1.Departamento.NombreDepartamento = "Contabilidad";
empleado1.Salario = new Salario();
empleado1.Salario.Id = 1;
empleado1.Salario.Roll = "Contador";
empleado1.Salario.Monto = 1000;
reportePlanilla.empleados.Add(empleado1);

Console.WriteLine(reportePlanilla.empleados[0].Nombre);