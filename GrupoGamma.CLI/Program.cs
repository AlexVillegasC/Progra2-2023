
using Lab.Models.GrupoGamma;

Empresa R_Empresa()
{
    
}

Empresa empresa = new Empresa();    

foreach (var cliente in empresa.Cliente)
{
    Console.WriteLine(cliente.Nombre);
    Console.WriteLine(cliente.Id);
    Console.WriteLine(cliente.Telefono);
}

foreach ( var empleado in empresa.Empleado)
{
    Console.WriteLine(empleado.Nombre_emp);
    Console.WriteLine(empleado.id);
    Console.WriteLine(empleado.campo);
    Console.WriteLine(empleado.Telefono_emp);
}

foreach (var software in empresa.Software)
{
    Console.WriteLine(software.Nombre_app);
    Console.WriteLine(software.funcion);
    Console.WriteLine(software.Requerimientos);
    Console.WriteLine(software.fecha_inicio);
    Console.WriteLine(software.fecha_entrega);
        
}