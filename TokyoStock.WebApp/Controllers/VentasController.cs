using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using TokyoStock.Core.Business;
using TokyoStock.Core.Entities.Filters;
using TokyoStock.WebApp.Models;
using TokyoStock.WebApp.Permisos;

namespace TokyoStock.WebApp.Controllers
{
	[ValidarSesion]
	public class VentasController : Controller
    {
        private readonly ProductoBusiness _pb;
        private readonly UsuarioBusiness _ub;
        private readonly VentaBusiness _vb;

        public VentasController(ProductoBusiness pb, UsuarioBusiness ub, VentaBusiness vb)
        {
            _pb = pb;
            _ub = ub;
            _vb = vb;
        }

        public IActionResult Index()
        {
            return View("Listar");
        }

        public IActionResult Listar(int? pageNumber)
        {
            var f = new Filter { PageIndex = pageNumber ?? 1, PageSize = 10 };
            var (ventas, total) = _vb.GetVentasByFilter(f);
            var viewModel = new VentaListViewModel
            {
                Ventas = ventas,
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

            return View("Registrar");
        }

		[HttpPost]
		public IActionResult Registrar(VentaViewModel model)
		{
			if (ModelState.IsValid)
			{				
                // Crear la venta
                var venta = new Core.Entities.Venta
				{
					ProductoId = model.ProductoId,
					Cantidad = model.Cantidad,
					UsuarioId = HttpContext.Session.GetInt32("UsuarioId").Value
                };

                _vb.AddVenta(venta);

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
