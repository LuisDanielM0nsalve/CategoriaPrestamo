using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Options;
using CategoriaProducto.Domain.Ports;
using Microsoft.Extensions.Options;

namespace CategoriaProducto.Infrastructure.Adapters
{
    internal sealed record class Moroso : IInteres
    {
        private readonly InteresOptions interesOptions;

        public Moroso(IOptions<InteresOptions> interesOptions)
        {
            this.interesOptions = interesOptions.Value;
        }

        public TipoCliente Categoria => TipoCliente.Moroso;

        public double Interes() => interesOptions.Moroso;
    }
}
