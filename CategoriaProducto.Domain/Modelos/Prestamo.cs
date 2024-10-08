using CategoriaProducto.Domain.Enums;

namespace CategoriaProducto.Domain.Modelos;

public class Prestamo
{
    public Guid Id { get; set; }
    public double Monto { get; set; }
    public TipoCliente Cliente { get; set; }
}
