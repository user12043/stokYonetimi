using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stokYonetimi.Controllers.CustomAttributes;
using stokYonetimi.Models;

namespace stokYonetimi.Controllers {
    public class PersonelController : Controller {
        private DatabaseContext context = new DatabaseContext();

        [KisiAuth(roleCode = 1)]
        // GET: Personel
        public ActionResult Index() {
            return RedirectToAction("UrunListele");
        }

        [KisiAuth(roleCode = 1)]
        // GET: Personel/StokEkle
        public ActionResult StokEkle() {
            var urunler = context.Urunler.ToList();

            return View(urunler);
        }

        [KisiAuth(roleCode = 1)]
        // GET: Personel/StokGuncelle
        public ActionResult StokGuncelle(int id) {
            var urunler = context.Urunler.ToList();
            Stok stok = context.Stoklar.Find(id);
            ViewBag.stok = stok;

            return View(urunler);
        }

        [KisiAuth(roleCode = 1)]
        // GET: Personel/StokListele
        public ActionResult StokListele() {
            var stoklar = context.Stoklar.ToList();

            return View(stoklar);
        }

        [KisiAuth(roleCode = 1)]
        // GET: Personel/UrunEkle
        public ActionResult UrunEkle() {
            return View();
        }

        [KisiAuth(roleCode = 1)]
        // GET: Personel/UrunGuncelle
        public ActionResult UrunGuncelle(int id) {
            Urun urun = context.Urunler.Find(id);

            return View(urun);
        }

        [KisiAuth(roleCode = 1)]
        // GET: Personel/UrunListele
        public ActionResult UrunListele() {
            IEnumerable<Urun> urunler = context.Urunler.ToList();

            return View(urunler);
        }

        [KisiAuth(roleCode = 1)]
        // GET: Personel/MusteriEkle
        public ActionResult MusteriEkle() {
            return View();
        }

        [KisiAuth(roleCode = 1)]
        // GET: Personel/MusteriGuncelle
        public ActionResult MusteriGuncelle(int id) {
            Musteri musteri = context.Musteriler.Find(id);

            return View(musteri);
        }

        [KisiAuth(roleCode = 1)]
        // GET: Personel/MusteriListele
        public ActionResult MusteriListele() {
            IEnumerable<Musteri> musteriler = context.Musteriler.ToList();

            return View(musteriler);
        }
    }
}