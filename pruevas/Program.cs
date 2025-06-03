using BLL;
using DAL;
using Entity;
using Entity.Dto;
using Entity.Interfaces;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        PaqueteDeServicioRepository paqueteDeServicioRepository = new PaqueteDeServicioRepository();

        var paquetes = paqueteDeServicioRepository.GetAllDTO();

        foreach (var paquete in paquetes)
        {
            Console.WriteLine($"ID: {paquete.Id}, Nombre: {paquete.Nombre}, Precio: {paquete.Precio}, Descripcion: {paquete.Descripcion}");
        }

    }

}



