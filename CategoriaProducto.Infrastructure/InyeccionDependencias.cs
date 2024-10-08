using CategoriaProducto.Domain.Options;
using CategoriaProducto.Domain.Ports;
using CategoriaProducto.Infrastructure.Adapters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CategoriaProducto.Infrastructure
{
    public static class InyeccionDependencias
    {
        public static IServiceCollection AddInfra(
            this IServiceCollection services
            , IConfiguration configuration
        )
        {
            services.AddScoped<IInteres, Nuevo>();
            services.AddScoped<IInteres, Frecuente>();
            services.AddScoped<IInteres, VIP>();
            services.AddScoped<IInteres, Moroso>();


            services.Configure<InteresOptions>(
                configuration.GetSection(
                    InteresOptions.Fact.SectionName
                )
            );

            return services;
        }
    }
}
