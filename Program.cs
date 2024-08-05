using _00_ProyectoBase.Models;

Empresa.InicializarEmpresa("Sarias");
Empresa.AgregarEmpleado(new Empleado("David","Meedina",23,"Gerente",15000000));


void mostrarMenu()
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Agregar empleado");
    Console.WriteLine("2. Listar empleados");
    Console.WriteLine("3. Eliminar empleado");
    Console.WriteLine("4. Buscar empleado");
    Console.WriteLine("5. Salir");
}

int seleccionarOpcion()
{
    mostrarMenu();
    Console.Write("Ingrese la opción: ");
    return Convert.ToInt32(Console.ReadLine());
}

void MenuPrincipal()
{
    int opcion;
    do
    {
        opcion = seleccionarOpcion();
        switch (opcion)
        {
            case 1:
                Administracion.AgregarEmpleado();
                break;
            case 2:
                Administracion.ListarEmpleados();
                break;
            case 3:
                Administracion.EliminarEmpleado();
                break;
            case 4:
                Administracion.BuscarEmpleado();
                break;
            case 5:
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opción inválida. Intente nuevamente.");
                break;
        }
    } while (opcion != 5);
}

MenuPrincipal();


