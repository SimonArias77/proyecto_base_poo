using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _00_ProyectoBase.Models;
public static class Administracion
{
    public static Empleado SolicitarInformacionEmpleado()
    {
        Console.WriteLine("Ingrese nombre del empleado: ");
        string? nombre = Console.ReadLine();

        Console.WriteLine("Ingrese apellido del empleado: ");
        string? apellido = Console.ReadLine();

        Console.WriteLine("Ingrese edad del empleado: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese cargo del empleado: ");
        string? cargo = Console.ReadLine();

        Console.WriteLine("Ingrese sueldo del empleado: ");
        double sueldo = Convert.ToDouble(Console.ReadLine());

        return new Empleado(nombre, apellido, edad, cargo, sueldo);
    }

    public static void AgregarEmpleado()
    {
        Empresa.AgregarEmpleado(SolicitarInformacionEmpleado());
    }

    public static void ListarEmpleados()
    {
        List<Empleado> empleados = Empresa.ObtenerEmpleados();
        Console.WriteLine("Listado de empleados:");
        foreach (var empleado in empleados)
        {
            Console.WriteLine(empleado);
        }
    }

    public static void EliminarEmpleado()
    {
        ListarEmpleados();
        Console.WriteLine("Ingrese el nombre del empleado a eliminar: ");
        string? nombre = Console.ReadLine();
        var empleado = Empresa.BuscarEmpleado(nombre);
        if (empleado == null)
        {
            Console.WriteLine("Empleado no encontrado...");
        }
        else
        {
            Empresa.EliminarEmpleado(empleado);
        }
    }

    public static void BuscarEmpleado()
    {
        Console.WriteLine("Ingrese el nombre del empleado a buscar: ");
        string? nombre = Console.ReadLine();
        Empleado empleado = Empresa.BuscarEmpleado(nombre);
        if (empleado != null)
        {
            Console.WriteLine(empleado);
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }

    public static void ActualizarEmpleado()
    {
        Console.WriteLine("Ingrese el nombre del empleado a buscar: ");
        string? nombre = Console.ReadLine();
        Empleado empleado = Empresa.BuscarEmpleado(nombre);

        if (empleado != null)
        {
            empleado = SolicitarInformacionEmpleado();
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }
}