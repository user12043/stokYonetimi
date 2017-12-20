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
        public ActionResult SiparisVer(int? urunId) {
            List<Urun> urunList = context.Urunler.ToList();
            Urun activeUrun = urunList.FirstOrDefault(urun => urun.UrunId == urunId);
            ViewBag.activeUrun = activeUrun;
            return View(urunList);
        }

        [KisiAuth(roleCode = 0)]
        // GET: Musteri/SiparisListele
        public ActionResult SiparisListele() {
            var id = (int) Session["loggedUserId"];
            List<Siparis> siparisList = context.Siparisler.Where(siparis => siparis.MusteriId == id).ToList();
            return View(siparisList);
        }

        [KisiAuth(roleCode = 0)]
        // GET: Musteri/SepeteGit
        public ActionResult SepeteGit() {
            return View();
        }
    }
}