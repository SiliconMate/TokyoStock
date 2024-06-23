
using Microsoft.EntityFrameworkCore;
using TokyoStock.Core.Entities;
using TokyoStock.Core.Entities.Filters;

namespace TokyoStock.Core.Data
{
    public class VentaRepository
    {
        public VentaRepository()
        {

        }

        public List<Venta> GetVentas()
        {
            var ventas = new List<Venta>();

            using (var db = new TokyoStockContext())
            {
                ventas = db.Venta.ToList();
            }

            return ventas;
        }

        public List<Venta> GetVentasWithProducts()
        {
            var ventas = new List<Venta>();

            using (var db = new TokyoStockContext())
            {
                ventas = db.Venta.Include(v => v.Producto).ToList();
            }

            return ventas;
        }

        public Venta GetVenta(int id)
        {
            Venta venta = null;

            using (var db = new TokyoStockContext())
            {
                venta = db.Venta.Find(id);
            }

            return venta;
        }

        public (List<Venta> list, int total) GetVentasByFilter(Filter f)
        {
            var list = new List<Venta>();
            var total = 0;

            using (var db = new TokyoStockContext())
            {
                total = db.Venta.Count();
                list = db.Venta.Include(v => v.Producto)
                    .Include(v => v.Usuario)
                    .Skip((f.PageIndex - 1) * f.PageSize)
                    .Take(f.PageSize)
                    .ToList();
            }

            return (list, total);
        }

        public void AddVenta(Venta v)
        {
            using (var db = new TokyoStockContext())
            {
                db.Venta.Add(v);
                db.SaveChanges();
            }
        }
    }
}
