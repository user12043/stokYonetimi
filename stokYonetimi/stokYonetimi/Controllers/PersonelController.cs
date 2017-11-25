using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stokYonetimi.Models;

namespace stokYonetimi.Controllers {
    public class PersonelController : Controller {
        DatabaseContext context = new DatabaseContext();

        // GET: Personel/StokEkle
        public ActionResult StokEkle() {
            return View();
        }

        // GET: Personel/StokListele
        public ActionResult StokListele() {
            return View();
        }

        // GET: Personel/UrunEkle
        public ActionResult UrunEkle() {
            return View();
        }

        // GET: Personel/UrunListele
        public ActionResult UrunListele() {
            return View();
        }

        // GET: Personel/MusteriEkle
        public ActionResult MusteriEkle() {
            return View();
        }

        // GET: Personel/MusteriGuncelle
        public ActionResult MusteriGuncelle(int id) {
            Musteri musteri = context.musteriler.Find(id);

            return View(musteri);
        }

        // GET: Personel/MusteriListele
        public ActionResult MusteriListele() {
            IEnumerable<Musteri> musteriler = context.musteriler.ToList();

            return View(musteriler);
        }
    }
}