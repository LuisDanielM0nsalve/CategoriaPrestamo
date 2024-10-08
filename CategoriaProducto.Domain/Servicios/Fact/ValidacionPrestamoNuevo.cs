using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoriaProducto.Domain.Servicios.Fact
{
   public class ValidacionPrestamoNuevo : IValidacionPrestamo
{
    private const double MAX_PRESTAMO_NUEVO = 900000;  // 900 mil pesos
    private const int PLAZO_MESES_NUEVO = 6;           // 6 meses

    public TipoCliente TipoCliente => TipoCliente.Nuevo;

    public void ValidarPrestamo(double valorPrestamo, int plazoMeses)
    {
        if (valorPrestamo > MAX_PRESTAMO_NUEVO)
        {
            throw new Exception($"El cliente nuevo solo puede pedir hasta {MAX_PRESTAMO_NUEVO} pesos.");
        }

        if (plazoMeses > PLAZO_MESES_NUEVO)
        {
            throw new Exception($"El cliente nuevo solo puede solicitar préstamos por un máximo de {PLAZO_MESES_NUEVO} meses.");
        }
    }
}
}
