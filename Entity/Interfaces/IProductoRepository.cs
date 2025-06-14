﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Interfaces
{
    public interface IProductoRepository
    {
        Producto ObtenerPorId(int id);
        string ActualizarStock(int productoId, int nuevoStock);
    }
}
