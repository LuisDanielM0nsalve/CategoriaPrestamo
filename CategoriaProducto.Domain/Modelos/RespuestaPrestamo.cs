namespace CategoriaProducto.Domain.Modelos;

public record RespuestaPrestamo(
    double ValorPrestamo
    , double Interes
    , double ValorFinalConInteres
);