using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TokyoStock.WebApp.Permisos
{
	public class ValidarSesionAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			if (context.HttpContext.Session.GetString("Usuario") == null)
			{
				context.Result = new RedirectResult("~/Acceso/Login");
			}

			base.OnActionExecuting(context);
		}
	}
}
