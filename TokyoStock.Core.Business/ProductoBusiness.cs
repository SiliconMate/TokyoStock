using TokyoStock.Core.Entities;
using TokyoStock.Core.Data;
using TokyoStock.Core.Entities.Filters;

namespace TokyoStock.Core.Business
{
    public class ProductoBusiness
    {
        private readonly ProductoRepository _pr;
        private readonly CompraRepository _cr;
        private readonly VentaRepository _vr;
        public ProductoBusiness(ProductoRepository pr)
        {
            _pr = pr;
        }
        public ProductoBusiness(ProductoRepository pr, CompraRepository cr, VentaRepository vr)
        {
            _pr = pr;
            _cr = cr;
            _vr = vr;
        }

        public List<Producto> GetProductos()
        {
            return _pr.GetProductos();
        }

        public (List<Producto> list, int total) GetProductosByFilter(Filter f)
        {
            return _pr.GetProductosByFilter(f);
        }

        public Producto GetProducto(int id)
        {
            return _pr.GetProducto(id);
        }

        public Producto GetProductoByName(string name)
        {
            return _pr.GetProductoByName(name);
        }

        public void AddProducto(Producto p)
        {
            _pr.AddProducto(p);
        }

        public void DeleteProducto(int id)
        {
            _pr.DeleteProducto(id);
        }

        public void UpdateProducto(Producto p)
        {
            _pr.UpdateProducto(p);
        }
    }
}
