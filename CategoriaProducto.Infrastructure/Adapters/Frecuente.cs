using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Options;
using CategoriaProducto.Domain.Ports;
using Microsoft.Extensions.Options;

namespace CategoriaProducto.Infrastructure.Adapters;

internal sealed record class Frecuente : IInteres
{
    private readonly InteresOptions interesOptions;

    public Frecuente(IOptions<InteresOptions> interesOptions)
    {
        this.interesOptions = interesOptions.Value;
    }

    public TipoCliente Categoria => TipoCliente.Frecuente;

    public double Interes() => interesOptions.Frecuente;

}
