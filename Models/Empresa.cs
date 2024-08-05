using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _00_ProyectoBase.Models
{
    public static class Empresa
    {
        public static string? Nombre { get; set; }
        public static List<Empleado> ListaEmpleados { get; set; }

        public static void InicializarEmpresa(string nombre)
        {
            Nombre = nombre;
            ListaEmpleados = new List<Empleado>();
        }

        public static void AgregarEmpleado(Empleado empleado)
        {
            ListaEmpleados.Add(empleado);
        }

        public static void EliminarEmpleado(Empleado empleado)
        {
            ListaEmpleados.Remove(empleado);
        }

        public static List<Empleado> ObtenerEmpleados()
        {
            return ListaEmpleados;
        }

        public static Empleado? BuscarEmpleado(string nombre)
        {
            return ListaEmpleados.FirstOrDefault(e => e.Nombre == nombre);
        }
    }
}