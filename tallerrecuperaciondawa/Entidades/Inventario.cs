namespace tallerrecuperaciondawa.Entidades
{
    public class Inventario
    {
        public int Id { get; set; }

        public string Producto { get; set; } = null!;

        public string TipoProducto { get; set; } = null!;

        public int Cantidad { get; set; }

        public string Estado { get; set; } = null!;
    }
}
