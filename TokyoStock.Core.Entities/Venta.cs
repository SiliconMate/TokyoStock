using System;
using System.Collections.Generic;

namespace TokyoStock.Core.Entities;

public partial class Venta
{
    public int VentaId { get; set; }

    public DateTime Fecha { get; set; }

    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    public int UsuarioId { get; set; }

    public virtual Producto Producto { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
