using Microsoft.AspNetCore.Mvc;
using TokyoStock.Core.Business;
using TokyoStock.WebApp.Models;

namespace TokyoStock.WebApp.Controllers
{
    public class AccesoController : Controller
    {
        private readonly UsuarioBusiness _ub;

        public AccesoController(UsuarioBusiness ub)
        {
            _ub = ub;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(UsuarioModel um)
        {
            if (ModelState.IsValid)
            {
                _ub.RegistrarUsuario(um.Nombre, um.Contra);

                return RedirectToAction("Login", "Acceso");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(UsuarioModel um)
        {
            if (ModelState.IsValid)
            {
                if (_ub.ValidarUsuario(um.Nombre, um.Contra))
                {
                    var usuario = _ub.GetUsuarioByName(um.Nombre);

                    HttpContext.Session.SetInt32("UsuarioId", usuario.UsuarioId);
                    HttpContext.Session.SetString("UsuarioNombre", usuario.Nombre);

                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
    }
}
