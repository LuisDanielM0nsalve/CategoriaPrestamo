using CategoriaProducto.Domain.Enums;

namespace CategoriaProducto.Domain.Ports;

public interface IInteres
{
    public TipoCliente Categoria { get; }

    public double Interes();
}
