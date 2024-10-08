using CategoriaProducto.Domain.Servicios;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CategoriaProducto.Application
{
    public static class InyeccionDependencias
    {
        public static IServiceCollection AddApplication(
            this IServiceCollection services
        )
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddMediatR(options => 
                options
                .RegisterServicesFromAssemblies(
                    assembly
                ));

            services.AddTransient<PrestamoServicio>();

            return services;
        }
    }
}

