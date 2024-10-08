using CategoriaProducto.Application.Carateristicas.Comandos.Productos.ProductoConDescuento;
using CategoriaProducto.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CategoriaProducto.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PrestamoController : ControllerBase
{
    private readonly IMediator mediator;
    private readonly ILogger<PrestamoController> _logger;

    public PrestamoController(
        ILogger<PrestamoController> logger
        , IMediator mediator
    )
    {
        _logger = logger;
        this.mediator = mediator;
    }

    [HttpPost(Name = "interes")]
    public async Task<IActionResult> Get(
     double valorPrestamo,
     TipoCliente categoria,
     int plazoMeses // Nuevo parámetro
 )
    {
        var request = new ProductoConDescuentoCommand(
            valorPrestamo,
            categoria,
            plazoMeses // Pasa el nuevo parámetro aquí
        );
        return Ok(await mediator.Send(request));
    }

}