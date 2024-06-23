using Microsoft.AspNetCore.Mvc;
using TokyoStock.WebApp.Models;
using TokyoStock.Core.Business;
using TokyoStock.Core.Entities;
using TokyoStock.Core.Entities.Filters;

namespace TokyoStock.WebApp.Controllers
{
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
            var f = new Filter { PageIndex = pageNumber ?? 1, PageSize = 5 };
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

            // ViewBag.Productos = productos;
            // ViewBag.Usuarios = usuarios;

            ViewData["Productos"] = productos;
            ViewData["Usuarios"] = usuarios;

            return View("Registrar");
        }
    }
}
