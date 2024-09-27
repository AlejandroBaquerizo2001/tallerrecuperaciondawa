namespace tallerrecuperaciondawa.Entidades
{
    public class Historial
    {
        public int Id { get; set; }

        public string Usuario { get; set; } = null!;

        public string Doctor { get; set; } = null!;

        public string Area { get; set; } = null!;

        public string Estado { get; set; } = null!;
    }
}
