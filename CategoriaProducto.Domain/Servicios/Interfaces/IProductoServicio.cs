using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoriaProducto.Domain.Servicios.Interfaces
{
    internal interface IProductoServicio
    {
        public RespuestaPrestamo ValorFinalConInteres(double valorPrestamo, TipoCliente cliente, int plazoMeses);   

    }
}
