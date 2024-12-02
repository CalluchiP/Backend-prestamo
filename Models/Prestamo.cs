using System;
using System.Collections.Generic;

namespace App_Prestamos.Models;

public partial class Prestamo
{
    public int IdPrestamo { get; set; }

    public string Dni { get; set; } = null!;

    public string? Ruc { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public decimal Prestamo1 { get; set; }

    public decimal Deuda { get; set; }

    public int Plazo { get; set; }

    public DateOnly FechaInicio { get; set; }

    public DateOnly FechaFinal { get; set; }

    public string Estado { get; set; } = null!;
}
