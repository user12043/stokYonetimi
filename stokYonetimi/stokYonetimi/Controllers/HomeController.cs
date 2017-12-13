using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stokYonetimi.Models;

namespace stokYonetimi.Controllers {
    public class HomeController : Controller {
        private DatabaseContext context = new DatabaseContext();

        // GET: Home
        public ActionResult Login() {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection collection) {
            var username = collection.Get("username");
            var password = collection.Get("password");
            if (username != "" && password != "") {
                try {
                    var kisi = context.Kisiler.FirstOrDefault(k => (k.MailAdresi == username && k.Sifre == password));
                    if (kisi != null) {
                        Session["loggedUserName"] = kisi.Isim;
                        Session["loggedUserId"] = kisi.KisiId;
                        switch (kisi.Rolu) {
                            case 0:
                                Session["loggedUserRole"] = 0;
                                return RedirectToActionPermanent("SiparisListele", "Musteri");
                            case 1:
                                Session["loggedUserRole"] = 1;
                                return RedirectToActionPermanent("MusteriListele", "Personel");
                        }
                    }
                    else {
                        TempData["loginError"] = true;
                    }
                }
                catch (Exception e) {
                    Console.WriteLine(e);
                }
            }
            else {
                TempData["emptyInputError"] = true;
            }
            return View();
        }

        public ActionResult Logout() {
            Session["loggedUserName"] = null;
            Session["loggedUserId"] = null;
            Session["loggedUserRole"] = null;
            return Redirect("/");
        }
    }
}