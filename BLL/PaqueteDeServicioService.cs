﻿using DAL;
using Entity.Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PaqueteDeServicioService
    {
        private readonly PaqueteDeServicioRepository _repository;
        private readonly ProductoRepository _productoRepo;

        public PaqueteDeServicioService()
        {
            _repository = new PaqueteDeServicioRepository();
            _productoRepo = new ProductoRepository();
        }

        public string Agregar(PaqueteDeServicio paquete)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(paquete.Nombre))
                    throw new ArgumentException("El nombre es obligatorio.");

                if (paquete.Precio <= 0)
                    throw new ArgumentException("El precio debe ser mayor que cero.");

                if (paquete.DuracionPaquete <= 0)
                    throw new ArgumentException("La duración debe ser mayor que cero.");

                return _repository.Agregar(paquete);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar paquete de servicio {ex.Message}");
            }
        }

        public List<PaqueteDeServicio> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener paquetes de servicio", ex);
            }
        }

        public List<PaqueteDeServicioDTO> GetAllDTO()
        {
            try
            {
                return _repository.GetAllDTO();
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener paquetes de servicio DTO", ex);
            }
        }

        public PaqueteDeServicioDTO GetById(int id)
        {
            try
            {
                if (id <= 0)
                    throw new ArgumentException("El ID debe ser mayor que cero.");

                var paquete = _repository.GetById(id);
                if (paquete == null)
                    throw new AppException("No se encontró el paquete con el ID especificado.");

                return paquete;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al buscar paquete de servicio por ID", ex);
            }
        }

        public string Update(PaqueteDeServicio paquete)
        {
            try
            {
                if (paquete.Id <= 0)
                    throw new ArgumentException("ID de paquete no válido.");

                if (string.IsNullOrWhiteSpace(paquete.Nombre))
                    throw new ArgumentException("El nombre es obligatorio.");

                if (paquete.Precio <= 0)
                    throw new ArgumentException("El precio debe ser mayor que cero.");

                if (paquete.DuracionPaquete <= 0)
                    throw new ArgumentException("La duración debe ser mayor que cero.");

                return _repository.Update(paquete);
            }
            catch (Exception ex)
            {
                throw new AppException("Error al actualizar paquete de servicio", ex);
            }
        }

        public string Delete(int id)
        {
            try
            {
                if (id <= 0)
                    throw new ArgumentException("El ID debe ser mayor que cero.");

                return _repository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new AppException("Error al eliminar paquete de servicio", ex);
            }
        }

        public void DescontarPaqueteDeServicio(PaqueteDeServicio paquete, int cantidad)
        {
            try
            {
                
                _repository.ActualizarStock(paquete.Id, paquete.stock - cantidad);
            }
            catch (Exception ex)
            {
                throw new AppException("Error al descontar paquete de servicio", ex);
            }
        }

        public void DescontarProductosDelPaquete(int paqueteId, int cantidadVendida)
        {
            var productos = _repository.ObtenerProductosPorPaquete(paqueteId);

            foreach (var (productoId, cantidadPorPaquete) in productos)
            {
                int stockActual = _productoRepo.ObtenerStock(productoId);
                int cantidadTotal = cantidadPorPaquete * cantidadVendida;

                if (stockActual < cantidadTotal)
                {
                    throw new Exception($"Stock insuficiente para el producto ID {productoId}");
                }

                _productoRepo.ActualizarStock(productoId, stockActual - cantidadTotal);
            }
        }
        


    }

}
