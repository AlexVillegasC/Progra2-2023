
using Lab.Models.GrupoGamma;

Empresa empresa = new Empresa();

empresa.Cliente = new List<Cliente>();
Cliente primerCliente = new Cliente();
primerCliente.Nombre = "Edgardo Mora";
primerCliente.Id = 504320687;
primerCliente.Telefono = 26561482;
empresa.Cliente.Add(primerCliente);
Console.WriteLine(empresa.Cliente[0]);

empresa.Empleado = new List<Empleado>();
Empleado primerEmpleado = new Empleado();
primerEmpleado.id = 403240675;
primerEmpleado.Nombre_emp = "José Hernandez";
primerEmpleado.Telefono_emp = 62613482;
primerEmpleado.campo = "Programacion";
empresa.Empleado.Add(primerEmpleado);
Console.WriteLine(empresa.Empleado[0]);

empresa.Software = new List<Software>();
Software primerSoftware = new Software();
primerSoftware.Nombre_app = "EasyMap";
primerSoftware.funcion = "Creación de mapas conseptuales";
primerSoftware.Requerimientos = "Existir (opcional)";
primerSoftware.fecha_inicio = DateTime.Now;
primerSoftware.fecha_entrega = new DateTime(2024, 12, 23);
empresa.Software.Add(primerSoftware);
Console.WriteLine(empresa.Software[0]);