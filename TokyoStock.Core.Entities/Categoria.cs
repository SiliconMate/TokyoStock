using System;
using System.Collections.Generic;

namespace TokyoStock.Core.Entities;

public partial class Categoria
{
    public int CategoriaId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public override string ToString()
    {
        return Nombre;
    }
}
