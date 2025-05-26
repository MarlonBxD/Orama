using Entity;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteMapper
    {
        public static ClienteDTO ToDTO(Cliente c) => new ClienteDTO
        {
            Id = c.Id,
            Nombre = c.Nombre,
            Apellido = c.Apellido,
            Telefono = c.Telefono,
            Direccion = c.Direccion,
            Email = c.Email
        };

        public static Cliente ToEntity(ClienteDTO dto) => new Cliente
        {
            Id = dto.Id,
            Nombre = dto.Nombre,
            Apellido = dto.Apellido,
            Telefono = dto.Telefono,
            Direccion = dto.Direccion,
            Email = dto.Email
        };
    }
}
