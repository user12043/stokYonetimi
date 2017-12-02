using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stokYonetimi.Models;

namespace stokYonetimi.Controllers {
    public class MusteriController : Controller {
        private DatabaseContext context = new DatabaseContext();

        // GET: Musteri
        public ActionResult Index() {
            return RedirectToAction("SiparisListele");
        }

        // GET: Musteri/SiparisVer
        public ActionResult SiparisVer() {
            return View();
        }

        // GET: Musteri/SiparisListele
        public ActionResult SiparisListele() {
            List<Siparis> siparisList = context.siparisler.ToList();

            return View(siparisList);
        }

        // GET: Musteri/SepeteGit
        public ActionResult SepeteGit() {
            return View();
        }
    }
}