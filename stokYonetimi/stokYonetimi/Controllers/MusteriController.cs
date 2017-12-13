using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stokYonetimi.Models;

namespace stokYonetimi.Controllers {
    public class MusteriController : Controller {
        private DatabaseContext context = new DatabaseContext();

        [MusteriAuth]
        // GET: Musteri
        public ActionResult Index() {
            return RedirectToAction("SiparisListele");
        }

        [MusteriAuth]
        // GET: Musteri/SiparisVer
        public ActionResult SiparisVer() {
            return View();
        }

        [MusteriAuth]
        // GET: Musteri/SiparisListele
        public ActionResult SiparisListele() {
            List<Siparis> siparisList = context.siparisler.ToList();

            return View(siparisList);
        }

        [MusteriAuth]
        // GET: Musteri/SepeteGit
        public ActionResult SepeteGit() {
            return View();
        }
    }
}