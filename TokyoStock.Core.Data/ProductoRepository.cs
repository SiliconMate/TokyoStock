





using Microsoft.EntityFrameworkCore;
using TokyoStock.Core.Entities;

namespace TokyoStock.Core.Data
{
    public class ProductoRepository
    {
        public List<Producto> GetProductos()
        {
            var list = new List<Producto>();

            using (var db = new TokyoStockContext())
            {
                list = db.Productos.Include(p => p.Categoria).ToList();
            }

            return list;
        }
    }
}
