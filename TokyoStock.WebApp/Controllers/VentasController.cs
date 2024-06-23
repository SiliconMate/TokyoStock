using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using TokyoStock.Core.Business;
using TokyoStock.Core.Entities.Filters;
using TokyoStock.WebApp.Models;

namespace TokyoStock.WebApp.Controllers
{
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
            var f = new Filter { PageIndex = pageNumber ?? 1, PageSize = 5 };
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

            // ViewBag.Productos = productos;
            // ViewBag.Usuarios = usuarios;

            ViewData["Productos"] = productos;
            ViewData["Usuarios"] = usuarios;

            return View("Registrar");
        }

    }
}
