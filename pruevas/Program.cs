using Entity;
using BLL;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Entity.Dto;
using DAL;
public class Program
{
    ClienteService clienteService = new ClienteService();
    Cliente cliente = new Cliente();
    private static void Main(string[] args)
    {
        ClienteService clienteService = new ClienteService();
        Cliente cliente = new Cliente();
        cliente.Nombre = "Juan";
        cliente.Apellido = "Pérez";
        cliente.Telefono = "1234567890";
        cliente.Email = "ejemplo@orama.com";
        cliente.Direccion = "Calle Falsa 123";

        //try
        //{
        //    clienteService.Agregar(cliente);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"Error {ex.Message}");
        //}

        //try
        //{
        //    clienteService.GetById(1);
        //    if (cliente != null)
        //    {
        //        Console.WriteLine($"Cliente encontrado: {cliente.Nombre} {cliente.Apellido}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Cliente no encontrado.");
        //    }
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"Error {ex.Message}");
        //}

        try
        {
            var clientes = clienteService.GetAll();
            foreach (var c in clientes)
            {
                Console.WriteLine($"Cliente: {c.Nombre} {c.Apellido}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error {ex.Message}");
        }



    }



}