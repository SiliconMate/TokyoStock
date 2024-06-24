using Microsoft.AspNetCore.Mvc;
using TokyoStock.WebApp.Models;
using TokyoStock.Core.Business;
using TokyoStock.Core.Entities;
using TokyoStock.Core.Entities.Filters;
using TokyoStock.WebApp.Permisos;

namespace TokyoStock.WebApp.Controllers
{
	[ValidarSesion]
	public class ComprasController : Controller
    {
        private readonly ProductoBusiness _pb;
        private readonly UsuarioBusiness _ub;
        private readonly CompraBusiness _cb;

        public ComprasController(ProductoBusiness pb, UsuarioBusiness ub, CompraBusiness cb)
        {
            _pb = pb;
            _ub = ub;
            _cb = cb;
        }

        public IActionResult Index()
        {
            return View("Listar");
        }

        public IActionResult Listar(int? pageNumber)
        {
            var f = new Filter { PageIndex = pageNumber ?? 1, PageSize = 10 };
            var (compras, total) = _cb.GetComprasByFilter(f);
            var viewModel = new CompraListViewModel
            {
                Compras = compras,
                PageIndex = f.PageIndex,
                TotalPages = (int)Math.Ceiling(total / (double)f.PageSize)
            };

            return View(viewModel);
        }

        public IActionResult Registrar()
        {
            var productos = _pb.GetProductos();
            var usuarios = _ub.GetUsuarios();

            ViewData["Productos"] = productos;
            ViewData["Usuarios"] = usuarios;

            return View("Registrar");
        }

        [HttpPost]
        public IActionResult Registrar(VentaViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Crear la venta
                var compra = new Core.Entities.Compra
                {
                    Fecha = model.Fecha,
                    ProductoId = model.ProductoId,
                    Cantidad = model.Cantidad,
                    UsuarioId = HttpContext.Session.GetInt32("UsuarioId").Value
                };

                _cb.AddCompra(compra);

                return RedirectToAction("Listar");
            }

            var productos = _pb.GetProductos();
            var usuarios = _ub.GetUsuarios();

            ViewData["Productos"] = productos;
            ViewData["Usuarios"] = usuarios;

            return View(model);
        }
    }
}
