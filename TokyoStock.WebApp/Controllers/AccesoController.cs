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
                    HttpContext.Session.SetString("Usuario", um.Nombre);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
    }
}
