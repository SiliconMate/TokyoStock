
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
        private readonly ProductoRepository _pr;

        public VentaBusiness(VentaRepository vr)
        {
            _vr = vr;
        }

        public VentaBusiness(VentaRepository vr, CompraRepository cr, ProductoRepository pr)
        {
            _vr = vr;
            _cr = cr;
            _pr = pr;
        }

        public List<Venta> GetVentas()
        {
            return _vr.GetVentas();
        }
        
        public List<Venta> GetVentasWithProducts()
        {
            return _vr.GetVentasWithProducts();
        }

        public Venta GetVenta(int id) => _vr.GetVenta(id);

        public (List<Venta> list, int total) GetVentasByFilter(Filter f)
        {
            return _vr.GetVentasByFilter(f);
        }

        public void AddVenta(Venta v)
		{
            var cantCompra = _cr.GetCompras().Where(c => c.ProductoId == v.ProductoId).Sum(c => c.Cantidad);
            var cantVenta = _vr.GetVentas().Where(c => c.ProductoId == v.ProductoId).Sum(c => c.Cantidad);
            var diferencia = cantCompra - cantVenta;

            if (diferencia > v.Cantidad - 1)
            {
                if (diferencia == v.Cantidad)
                {
                    _pr.DisableProducto(v.ProductoId);
                }
                _vr.AddVenta(v);
            }
            
            Console.WriteLine("No hay suficiente stock para realizar la venta");
		}
    }
}
