using ConsoleApp1.Models;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        agregarEstudiante();
        listarCliente();
        //consultarEstudiantes();
        //consultarEstudiante();
        //modificarEstudiante();
        //eliminarEstudiante();
    }

    //listar Estudiante
    public static void listarCliente()
    {
        AppBD_contex context = new AppBD_contex();
        List<Cliente> lstClientes = context.Clientes.ToList();
        foreach (var item in lstClientes)
        {
            Console.WriteLine(item);
        }
    }


    //agregar estudiante
    public static void agregarEstudiante()
    {
        Console.WriteLine("Metodo agregar estudiante");
        AppBD_contex context = new AppBD_contex();
        Cliente cli = new Cliente();
        cli.Id = 1;
        cli.Nombre = "Diego";
        cli.Apellido = "Cordova";
        cli.Direccion = "Esteros";
        cli.Telefono = "0987654321";
        cli.FechaNacimiento = DateTime.Parse("2001-09-08");
        cli.Estado = 'A';
        Console.WriteLine(cli.ToString());
        context.Clientes.Add(cli);
        context.SaveChanges();
    }

    public static void consultarEstudiantes()
    {
        Console.WriteLine("Metodo consultar estudiantes");
        AppBD_contex context = new AppBD_contex();
        List<Cliente> lstClientes= context.Clientes.ToList() ;

        foreach (var item in lstClientes)
        {
            Console.WriteLine(item.ToString());
        }
        
    }

    public static void consultarEstudiante()
    {
        Console.WriteLine("Metodo consultar estudiante por Id");
        AppBD_contex context = new AppBD_contex();
        Cliente cli = new Cliente();
        cli = context.Clientes.Find(1);

       Console.WriteLine("Codigo: " + cli.Id + " Nombre: " + cli.Nombre);
      
    }

    public static void modificarEstudiante()
    {
        Console.WriteLine("Metodo modificar estudiante");
        AppBD_contex context = new AppBD_contex();
        Cliente cli = new Cliente();
        cli = context.Clientes.Find(1);

        cli.Nombre = "Xavier";
        context.SaveChanges();

    }

    public static void eliminarEstudiante()
    {
        Console.WriteLine("Metodo eliminar estudiante");
        AppBD_contex context = new AppBD_contex();
        Cliente cli = new Cliente();
        cli = context.Clientes.Find(1);
        context.Remove(cli);
        context.SaveChanges();

    }      
}