namespace CategoriaProducto.Domain.Options;

public class InteresOptions
{
    public int Nuevo { get; set; }
    public int Frecuente { get; set; }
    public int VIP { get; set; }
    public int Moroso { get; set; }

    public static class Fact
    {
        public static string SectionName { get => "Interes"; }
    }
}