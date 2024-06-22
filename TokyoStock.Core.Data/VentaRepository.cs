
using TokyoStock.Core.Entities;

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
