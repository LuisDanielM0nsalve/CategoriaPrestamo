using CategoriaProducto.Domain.Modelos;
using CategoriaProducto.Domain.Servicios;
using MediatR;

namespace CategoriaProducto.Application.Carateristicas.Comandos.Productos.ProductoConDescuento;

internal sealed record class ProductoConDescuentoCommandHandler
    : IRequestHandler<ProductoConDescuentoCommand, RespuestaPrestamo>
{
    private readonly PrestamoServicio prestamoServicio;

    public ProductoConDescuentoCommandHandler(
        PrestamoServicio prestamoServicio)
    {
        this.prestamoServicio = prestamoServicio;
    }

    public Task<RespuestaPrestamo> Handle(
    ProductoConDescuentoCommand request,
    CancellationToken cancellationToken
)
    {
        return Task.FromResult(
            prestamoServicio.ValorFinalConInteres(
                request.ValorPrestamo,
                request.TipoCategoria,
                request.PlazoMeses // Pasa el parámetro aquí
            )
        );
    }

}
