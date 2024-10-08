using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoriaProducto.Domain.Servicios.Fact
{
 public class ValidacionPrestamoMoroso : IValidacionPrestamo
{
    public TipoCliente TipoCliente => TipoCliente.Moroso;

    public void ValidarPrestamo(double valorPrestamo, int plazoMeses)
    {
        throw new Exception("El cliente moroso no puede solicitar préstamos.");
    }
}

}
