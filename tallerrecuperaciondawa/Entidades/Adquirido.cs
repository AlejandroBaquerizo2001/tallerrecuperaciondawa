﻿namespace tallerrecuperaciondawa.Entidades
{
    public class Adquirido
    {
        public int Id { get; set; }

        public string Producto { get; set; } = null!;

        public decimal Valor { get; set; }

        public string Usuario { get; set; } = null!;

        public DateOnly FechaAdquirido { get; set; }
    }
}
