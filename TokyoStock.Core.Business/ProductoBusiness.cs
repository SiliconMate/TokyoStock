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
    }
}
