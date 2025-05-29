using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class ProductoService
    {
        private readonly ProductoRepository _productoRepository;
        public ProductoService()
        {
            _productoRepository = new ProductoRepository();
        }
        public void Agregar(Producto producto)
        {
            if (producto == null)
                throw new ArgumentNullException(nameof(producto), "El producto no puede ser nulo.");
            if (string.IsNullOrWhiteSpace(producto.Nombre))
                throw new ArgumentException("El nombre del producto es obligatorio.");
            if (string.IsNullOrWhiteSpace(producto.Descripcion))
                throw new ArgumentException("La descripción del producto es obligatoria.");
            if (producto.Precio <= 0)
                throw new ArgumentException("El precio del producto debe ser mayor que cero.");
            if (producto.stock < 0)
                throw new ArgumentException("La cantidad del producto no puede ser negativa.");
            _productoRepository.Agregar(producto);
        }
        public List<Producto> Obtener()
        {
            try
            {
                return _productoRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new AppException("Error en la lógica de producto al obtener todos los productos", ex);
            }
        }
        public string Eliminar(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID del producto debe ser mayor que cero.");
            try
            {
                _productoRepository.Delete(id);
                return "Producto eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error eliminar el producto: {ex.Message}";
            }
        }
        public string UpdateName(int id, string nuevoNombre)
        {
            try
            {
                if (id <= 0)
                    throw new ArgumentException("El ID del producto debe ser mayor que cero.");
                return _productoRepository.Update(id, nuevoNombre);
            }
            catch (AppException ex)
            {
                return $"Error al actualizar el nomnre {ex.Message}";
            }
        }
        public Producto GetById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID del producto debe ser mayor que cero.");
            var producto = _productoRepository.ObtenerPorId(id);
            if (producto == null)
                throw new KeyNotFoundException($"Producto con ID {id} no encontrado.");
            return producto;

        }
    }
}
