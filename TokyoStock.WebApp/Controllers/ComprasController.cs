using Microsoft.AspNetCore.Mvc;
using TokyoStock.Core.Business;
using TokyoStock.Core.Entities;

namespace TokyoStock.WebApp.Controllers
{
    public class ComprasController : Controller
    {
        private readonly ProductoBusiness _pb;
        private readonly UsuarioBusiness _ub;

        public ComprasController(ProductoBusiness pb, UsuarioBusiness ub)
        {
            _pb = pb;
            _ub = ub;
        }

        public IActionResult Index()
        {
            return View("Listar");
        }

        public IActionResult Listar()
        {
            return View();
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
