using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stokYonetimi.Models;

namespace stokYonetimi.Controllers {
    public class MusteriController : Controller {
        DatabaseContext context = new DatabaseContext();

        // GET: Musteri
        public ActionResult SiparisVer() {
            return View();
        }

        public ActionResult SiparisListele() {
            List<Siparis> siparisList = context.siparisler.ToList();

            return View(siparisList);
        }

        public ActionResult SepeteGit() {
            return View();
        }
    }
}