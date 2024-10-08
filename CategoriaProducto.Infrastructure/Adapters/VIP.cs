using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Options;
using CategoriaProducto.Domain.Ports;
using Microsoft.Extensions.Options;

namespace CategoriaProducto.Infrastructure.Adapters
{
    public sealed record class VIP : IInteres
    {
        private readonly InteresOptions interesOptions;

        public VIP(IOptions<InteresOptions> interesOptions)
        {
            this.interesOptions = interesOptions.Value;
        }

        public TipoCliente Categoria => TipoCliente.VIP;
        public double Interes() => interesOptions.VIP;
    }
}
