using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stokYonetimi.Controllers.CustomAttributes;
using stokYonetimi.Models;

namespace stokYonetimi.Controllers {
    public class MusteriController : Controller {
        private DatabaseContext context = new DatabaseContext();

        [KisiAuth(roleCode = 0)]
        // GET: Musteri
        public ActionResult Index() {
            return RedirectToAction("SiparisListele");
        }

        [KisiAuth(roleCode = 0)]
        // GET: Musteri/SiparisVer
        public ActionResult SiparisVer() {
            return View();
        }

        [KisiAuth(roleCode = 0)]
        // GET: Musteri/SiparisListele
        public ActionResult SiparisListele() {
            List<Siparis> siparisList = context.Siparisler.ToList();

            return View(siparisList);
        }

        [KisiAuth(roleCode = 0)]
        // GET: Musteri/SepeteGit
        public ActionResult SepeteGit() {
            return View();
        }
    }
}