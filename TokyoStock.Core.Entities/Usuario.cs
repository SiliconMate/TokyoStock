using System;
using System.Collections.Generic;

namespace TokyoStock.Core.Entities;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string Nombre { get; set; } = null!;

    public byte[] Hash { get; set; } = null!;

    public byte[] Salt { get; set; } = null!;

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
