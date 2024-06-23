using TokyoStock.Core.Entities;
using TokyoStock.Core.Data;

namespace TokyoStock.Core.Business
{
    public class ProductoBusiness
    {
        private readonly ProductoRepository _pr;

        public ProductoBusiness(ProductoRepository pr)
        {
            _pr = pr;
        }

        public List<Producto> GetProductos()
        {
            return _pr.GetProductos();
        }

        public Producto GetProducto(int id)
        {
            return _pr.GetProducto(id);
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
