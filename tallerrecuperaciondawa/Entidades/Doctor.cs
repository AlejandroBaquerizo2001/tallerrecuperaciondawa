﻿namespace tallerrecuperaciondawa.Entidades
{
    public class Doctor
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string Especialidad { get; set; } = null!;

        public string Area { get; set; } = null!;

        public DateOnly FechaIngreso { get; set; }
    }
}
