
using Microsoft.EntityFrameworkCore;
using TokyoStock.Core.Data;
using TokyoStock.Core.Entities;
using TokyoStock.Core.Entities.Filters;

namespace TokyoStock.Core.Business
{
    public class VentaBusiness
    {
        private readonly VentaRepository _vr;
        private readonly CompraRepository _cr;

        public VentaBusiness(VentaRepository vr)
        {
            _vr = vr;
        }

        public VentaBusiness(VentaRepository vr, CompraRepository cr)
        {
            _vr = vr;
            _cr = cr;
        }

        public List<Venta> GetVentas()
        {
            return _vr.GetVentas();
        }

        public Venta GetVenta(int id) => _vr.GetVenta(id);

        public (List<Venta> list, int total) GetVentasByFilter(Filter f)
        {
            return _vr.GetVentasByFilter(f);
        }

        public void AddVenta(Venta v)
		{
            var cantCompra = _cr.GetCompras().Where(c => c.ProductoId == v.ProductoId).Sum(c => c.Cantidad);

            if (cantCompra > v.Cantidad)
            {
                _vr.AddVenta(v);
            }
            
            Console.WriteLine("No hay suficiente stock para realizar la venta");
		}
    }
}
