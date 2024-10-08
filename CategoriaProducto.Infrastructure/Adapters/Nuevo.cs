using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Options;
using CategoriaProducto.Domain.Ports;
using Microsoft.Extensions.Options;

namespace CategoriaProducto.Infrastructure.Adapters
{
    internal record class Nuevo : IInteres
    {
        private readonly InteresOptions interesOptions;

        public Nuevo(IOptions<InteresOptions> interesOptions)
        {
            this.interesOptions = interesOptions.Value;
        }

        public TipoCliente Categoria => TipoCliente.Nuevo;

        public double Interes() => interesOptions.Nuevo;
    }
}
