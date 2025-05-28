using BLL;
using DAL;
using Entity;
using Entity.Dto;
using Entity.Interfaces;

public class Program
{
    public static void Main(string[] args)
    {
        DespachoRepository clienteRepository = new DespachoRepository();
        List<DespachoDTO> clientes = clienteRepository.GetAll();

        foreach (var cliente in clientes)
        {
            Console.WriteLine($"ID : {cliente.Id}");
        }
    }


}