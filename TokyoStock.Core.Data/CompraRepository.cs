
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

        public (List<Producto> list, int total) GetComprasByFilter(Filter f)
        {
            var total = 0;
            var list = new List<Producto>();

            using (var db = new TokyoStockContext())
            {
                
            }

            return (list, total);
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
