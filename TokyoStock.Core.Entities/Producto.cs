using System;
using System.Collections.Generic;

namespace TokyoStock.Core.Entities;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string Nombre { get; set; } = null!;

    public int CategoriaId { get; set; }

    public bool Habilitado { get; set; }

    public virtual Categoria Categoria { get; set; } = null!;

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
