using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stokYonetimi.Models;

namespace stokYonetimi.Controllers {
    public class PersonelController : Controller {
        DatabaseContext context = new DatabaseContext();

        // GET: Personel
        public ActionResult StokEkle() {
            return View();
        }

        public ActionResult StokGuncelle() {
            return View();
        }

        public ActionResult StokListele() {
            return View();
        }

        public ActionResult UrunEkle() {
            return View();
        }

        public ActionResult UrunGuncelle() {
            return View();
        }

        public ActionResult UrunListele() {
            return View();
        }

        public ActionResult KisiEkle() {
            return View();
        }

        public ActionResult KisiGuncelle() {
            return View();
        }

        public ActionResult KisiListele() {
            IEnumerable<Kisi> kisiler = context.kisiler.ToList();

            return View(kisiler);
        }
    }
}