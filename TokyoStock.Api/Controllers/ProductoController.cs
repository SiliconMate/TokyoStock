using Microsoft.AspNetCore.Mvc;
using TokyoStock.Core.Business;
using TokyoStock.Core.Data;

namespace TokyoStock.Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet("{id}/stock")]
        public IActionResult GetStock(int id)
        {
            var cr = new CompraRepository();
            var vr = new VentaRepository();
            var pr = new ProductoRepository();

            var pb = new ProductoBusiness(pr, cr, vr);

            var stock = pb.CalculateStock(id);

            var resultado = new 
            {
                Name = pb.GetProducto(id).Nombre,
                Stock = stock
            };

            return Ok(resultado);
        }
    }
}
