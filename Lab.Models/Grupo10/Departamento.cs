namespace Lab.Models.Grupo10;
using System.Collections.Generic;

public class Departamento
{
    private List<Empleado> empleados { get; set; }

        public string NombreDepartamento { get; set; }
        public int IdDepartamento { get; set; }

        
        public Departamento(string nombreDepartamento)
        {
            NombreDepartamento = nombreDepartamento;
            empleados = new List<Empleado>();
        }

        public void agregar_empleado(Empleado empleado) {
            empleados.Add(empleado);
        }

    
        public void eliminar_empleado(Empleado empleado) {
            empleados.Remove(empleado);
        }

        public List<Empleado> obtener_empleados() {
            return empleados;
        }
    }
