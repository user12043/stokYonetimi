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

        [PersonelAuth]
        // GET: Personel
        public ActionResult Index() {
            return RedirectToAction("UrunListele");
        }

        [PersonelAuth]
        // GET: Personel/StokEkle
        public ActionResult StokEkle() {
            var urunler = context.urunler.ToList();

            return View(urunler);
        }

        [PersonelAuth]
        // GET: Personel/StokGuncelle
        public ActionResult StokGuncelle(int id) {
            var urunler = context.urunler.ToList();
            Stok stok = context.stoklar.Find(id);
            ViewBag.stok = stok;

            return View(urunler);
        }

        [PersonelAuth]
        // GET: Personel/StokListele
        public ActionResult StokListele() {
            var stoklar = context.stoklar.ToList();

            return View(stoklar);
        }

        [PersonelAuth]
        // GET: Personel/UrunEkle
        public ActionResult UrunEkle() {
            return View();
        }

        [PersonelAuth]
        // GET: Personel/UrunGuncelle
        public ActionResult UrunGuncelle(int id) {
            Urun urun = context.urunler.Find(id);

            return View(urun);
        }

        [PersonelAuth]
        // GET: Personel/UrunListele
        public ActionResult UrunListele() {
            IEnumerable<Urun> urunler = context.urunler.ToList();

            return View(urunler);
        }

        [PersonelAuth]
        // GET: Personel/MusteriEkle
        public ActionResult MusteriEkle() {
            return View();
        }

        [PersonelAuth]
        // GET: Personel/MusteriGuncelle
        public ActionResult MusteriGuncelle(int id) {
            Musteri musteri = context.musteriler.Find(id);

            return View(musteri);
        }

        [PersonelAuth]
        // GET: Personel/MusteriListele
        public ActionResult MusteriListele() {
            IEnumerable<Musteri> musteriler = context.musteriler.ToList();

            return View(musteriler);
        }
    }
}