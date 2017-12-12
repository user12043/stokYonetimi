using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace stokYonetimi.Controllers {
    public class HomeController : Controller {
        // GET: Home
        public ActionResult Login() {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection collection) {
            var username = collection.Get("username");
            var password = collection.Get("password");
            if (username != "" && password != "") {
                return RedirectToActionPermanent("MusteriListele", "Personel");
            }
            return View();
        }
    }
}