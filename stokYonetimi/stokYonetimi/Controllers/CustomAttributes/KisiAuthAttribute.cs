using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace stokYonetimi.Controllers.CustomAttributes {
    public class KisiAuthAttribute : ActionFilterAttribute {
        public int roleCode { get; set; }

        public override void OnActionExecuting(ActionExecutingContext context) {
            var session = context.Controller.ControllerContext.HttpContext.Session;
            var role = session["loggedUserRole"];
            if (role == null || (int) role != this.roleCode || session["loggedUserId"] == null) {
                context.Controller.TempData["errorMessage"] = Language.Messages.messages.authError;
                context.Result = new RedirectToRouteResult(new RouteValueDictionary {
                    {"Controller", "Home"},
                    {"Action", "Login"}
                });
            }
            base.OnActionExecuting(context);
        }
    }
}