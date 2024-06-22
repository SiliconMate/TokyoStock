
using Microsoft.EntityFrameworkCore;
using TokyoStock.Core.Entities;
using TokyoStock.Core.Entities.Filters;

namespace TokyoStock.Core.Data
{
    public class CompraRepository
    {

        public CompraRepository()
        {
        }

        public List<Compra> GetCompras()
        {
            var list = new List<Compra>();

            using (var db = new TokyoStockContext())
            {
                list = db.Compras.ToList();
            }

            return list;
        }

        public (List<Producto> productos, int totalP) GetComprasByFilter(Filter f)
        {
            var totalP = 0;
            var productos = new List<Producto>();

            using (var db = new TokyoStockContext())
            {
                totalP = db.Productos.Count();
                productos = db.Productos.Include(p => p.Categoria)
                    .Skip((f.PageIndex - 1) * f.PageSize)
                    .Take(f.PageSize)
                    .ToList();
            }

            return (productos, totalP);
        }

        public void AddCompra(Compra c)
        {
            using (var db = new TokyoStockContext())
            {
                db.Compras.Add(c);
                db.SaveChanges();
            }
        }
    }
}
