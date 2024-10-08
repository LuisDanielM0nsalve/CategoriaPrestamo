using CategoriaProducto.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoriaProducto.Domain.Servicios.Interfaces
{
    public interface IValidacionPrestamo
    {
        TipoCliente TipoCliente { get; }
        void ValidarPrestamo(double valorPrestamo, int plazoMeses);
    }
}
