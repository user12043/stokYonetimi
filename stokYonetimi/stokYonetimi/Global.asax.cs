using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace stokYonetimi {
    public class MvcApplication : System.Web.HttpApplication {
        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        // Set default language to tr
        protected void Application_AcquireRequestState(object sender, EventArgs e) {
            if (HttpContext.Current.Session == null) {
                return;
            }

            CultureInfo cultureInfo;
            var lang = Session["lang"];
            if (lang == null) {
                cultureInfo = new CultureInfo("tr");
                Session["lang"] = "tr";
            }
            else {
                cultureInfo = new CultureInfo((string) lang);
            }

            var thread = System.Threading.Thread.CurrentThread;
            thread.CurrentUICulture = cultureInfo;
            thread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureInfo.Name);
        }
    }
}