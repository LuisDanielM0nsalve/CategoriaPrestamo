using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoriaProducto.Domain.Servicios.Fact
{
    public class ValidacionPrestamoFrecuente : IValidacionPrestamo
{
    private const double MAX_PRESTAMO_FRECUENTE = 1500000;  // 1.5 millones
    private const int PLAZO_MESES_FRECUENTE = 12;           // 12 meses

    public TipoCliente TipoCliente => TipoCliente.Frecuente;

    public void ValidarPrestamo(double valorPrestamo, int plazoMeses)
    {
        if (valorPrestamo > MAX_PRESTAMO_FRECUENTE)
        {
            throw new Exception($"El cliente frecuente solo puede pedir hasta {MAX_PRESTAMO_FRECUENTE} pesos.");
        }

        if (plazoMeses > PLAZO_MESES_FRECUENTE)
        {
            throw new Exception($"El cliente frecuente solo puede solicitar préstamos por un máximo de {PLAZO_MESES_FRECUENTE} meses.");
        }
    }
}

}
