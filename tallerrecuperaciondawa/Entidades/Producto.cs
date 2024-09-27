namespace tallerrecuperaciondawa.Entidades
{
    public class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string TipoProducto { get; set; } = null!;

        public int Cantidad { get; set; }

        public DateOnly FechaIngreso { get; set; }
    }
}
