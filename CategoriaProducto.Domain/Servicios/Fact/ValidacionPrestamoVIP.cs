using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoriaProducto.Domain.Servicios.Fact
{
   public class ValidacionPrestamoVIP : IValidacionPrestamo
{
    private const double MAX_PRESTAMO_VIP = 5000000;  // 5 millones
    private const int PLAZO_MESES_VIP = 15;           // 15 meses

    public TipoCliente TipoCliente => TipoCliente.VIP;

    public void ValidarPrestamo(double valorPrestamo, int plazoMeses)
    {
        if (valorPrestamo > MAX_PRESTAMO_VIP)
        {
            throw new Exception($"El cliente VIP solo puede pedir hasta {MAX_PRESTAMO_VIP} pesos.");
        }

        if (plazoMeses > PLAZO_MESES_VIP)
        {
            throw new Exception($"El cliente VIP solo puede solicitar préstamos por un máximo de {PLAZO_MESES_VIP} meses.");
        }
    }
}

}
