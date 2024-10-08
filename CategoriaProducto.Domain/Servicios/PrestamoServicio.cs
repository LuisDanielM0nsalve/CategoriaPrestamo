using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Modelos;
using CategoriaProducto.Domain.Ports;
using CategoriaProducto.Domain.Servicios.Interfaces;

namespace CategoriaProducto.Domain.Servicios;

public sealed class PrestamoServicio : IProductoServicio
{
    private const double BASE_PORCENTAJE = 100;
    private readonly IEnumerable<IInteres> intereces;
    private readonly Dictionary<TipoCliente, IValidacionPrestamo> validacionesPrestamo;

    public PrestamoServicio(IEnumerable<IInteres> intereces, IEnumerable<IValidacionPrestamo> validaciones)
    {
        this.intereces = intereces;
        this.validacionesPrestamo = validaciones.ToDictionary(v => v.TipoCliente, v => v);
    }

    private double Interes(double valorPrestamo, TipoCliente cliente)
    {
        var interes = intereces
            .FirstOrDefault(inte => inte.Categoria == cliente);

        if (interes == null)
        {
            throw new Exception($"No se encontró interés para la categoría: {cliente}");
        }

        double porcentaje = interes.Interes();
        return valorPrestamo * porcentaje / BASE_PORCENTAJE;
    }

    private static double CalcularValorConInteres(double valorPrestamo, double interes)
    {
        return valorPrestamo + interes;
    }

    public RespuestaPrestamo ValorFinalConInteres(double valorPrestamo, TipoCliente cliente, int plazoMeses)
    {
        // Validar si el cliente puede realizar el préstamo (monto y plazo)
        if (validacionesPrestamo.ContainsKey(cliente))
        {
            validacionesPrestamo[cliente].ValidarPrestamo(valorPrestamo, plazoMeses);
        }
        else
        {
            throw new Exception("Tipo de cliente no reconocido.");
        }

        // Calcular el interés y el valor final con interés
        var interes = Interes(valorPrestamo, cliente);
        var valorFinalConInteres = CalcularValorConInteres(valorPrestamo, interes);

        return new RespuestaPrestamo(
            valorPrestamo,  // Préstamo original
            interes,        // Interés calculado
            valorFinalConInteres  // Valor total con interés
        );
    }
}
