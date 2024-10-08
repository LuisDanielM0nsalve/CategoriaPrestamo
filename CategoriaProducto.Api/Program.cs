using CategoriaProducto.Application;
using CategoriaProducto.Domain.Servicios.Fact;
using CategoriaProducto.Domain.Servicios.Interfaces;
using CategoriaProducto.Infrastructure;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

builder.Services
    .AddApplication()
    .AddInfra(configuration);

builder.Services.AddControllers();

builder.Services.AddScoped<IValidacionPrestamo, ValidacionPrestamoFrecuente>();
builder.Services.AddScoped<IValidacionPrestamo, ValidacionPrestamoNuevo>();
builder.Services.AddScoped<IValidacionPrestamo, ValidacionPrestamoVIP>();
builder.Services.AddScoped<IValidacionPrestamo, ValidacionPrestamoMoroso>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
