using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace stokYonetimi.Controllers {
    public class MusteriAuthAttribute : ActionFilterAttribute {
        public override void OnActionExecuting(ActionExecutingContext context) {
            var session = context.Controller.ControllerContext.HttpContext.Session;
            var role = session["loggedUserRole"];
            if (role == null || (int) role != 0 || session["loggedUserId"] == null) {
                context.Controller.TempData["authError"] = true;
                context.Result = new RedirectToRouteResult(new RouteValueDictionary {
                    {"Controller", "Home"},
                    {"Action", "Login"}
                });
            }
            base.OnActionExecuting(context);
        }
    }
}