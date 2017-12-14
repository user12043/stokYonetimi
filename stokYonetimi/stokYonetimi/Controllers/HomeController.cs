using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stokYonetimi.Models;

namespace stokYonetimi.Controllers {
    public class HomeController : Controller {
        private DatabaseContext context = new DatabaseContext();

        // GET: Home/Index
        public ActionResult Index() {
            var id = Session["loggedUserId"];
            var role = Session["loggedUserRole"];
            if (id != null && role != null) {
                if ((int) role == 0) {
                    return RedirectToActionPermanent("SiparisListele", "Musteri");
                }
                else if ((int) role == 1) {
                    return RedirectToActionPermanent("MusteriListele", "Personel");
                }
            }
            return RedirectToAction("Login");
        }

        // GET: Home/ChangeLang
        public ActionResult ChangeLang(string lang, string returnUrl) {
            if (lang != null && returnUrl != null) {
                Session["lang"] = lang;
            }

            return Redirect(returnUrl);
        }

        // GET: Home/Login
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
                        TempData["errorMessage"] = Language.Messages.messages.loginError;
                    }
                }
                catch (Exception e) {
                    Console.WriteLine(e);
                }
            }
            else {
                TempData["errorMessage"] = Language.Messages.messages.emptyInputError;
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