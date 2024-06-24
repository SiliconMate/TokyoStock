
using TokyoStock.Core.Data;
using TokyoStock.Core.Entities.Filters;
using TokyoStock.Core.Entities;

namespace TokyoStock.Core.Business
{
    public class CompraBusiness
    {
        private readonly CompraRepository _cr;
        private readonly ProductoRepository _pr;

        public CompraBusiness(CompraRepository cr)
        {
            _cr = cr;
        }

        public CompraBusiness(CompraRepository cr, ProductoRepository pr)
        {
            _cr = cr;
            _pr = pr;
        }

        public List<Compra> GetCompras()
        {
            return _cr.GetCompras();
        }

        public Compra GetCompra(int id) => _cr.GetCompra(id);

        public (List<Compra> list, int total) GetComprasByFilter(Filter f)
        {
            return _cr.GetComprasByFilter(f);
        }

        public void AddCompra(Compra c)
		{
            _pr.EnableProducto(c.ProductoId);
			_cr.AddCompra(c);
		}
    }
}
