
using TokyoStock.Core.Business;
using TokyoStock.Core.Data;
using TokyoStock.Core.Entities;

namespace TokyoStock.Core.Tests
{
    public class ProductoBusinessDebe
    {
        [Fact]
        public void CalcularElStock()
        {
            var cr = new CompraRepository();
            var vr = new VentaRepository();
            var pr = new ProductoRepository();

            var pb = new ProductoBusiness(pr, cr, vr);

            var productoBuscar = pr.GetProducto(1);

            var stock = pb.CalculateStock(productoBuscar);

            Assert.Equal((214-44), stock);
        }
    }
}