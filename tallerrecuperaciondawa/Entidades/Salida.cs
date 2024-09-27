namespace tallerrecuperaciondawa.Entidades
{
    public class Salida
    {
        public int Id { get; set; }

        public string Producto { get; set; } = null!;

        public string TipoProducto { get; set; } = null!;

        public int Cantidad { get; set; }

        public DateOnly FechaSalida { get; set; }

        public string Descripcion { get; set; } = null!;
    }
}
