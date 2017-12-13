using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stokYonetimi.Models;

namespace stokYonetimi.Controllers.DataControllers {
    public class UrunDataController : Controller {
        private DatabaseContext context = new DatabaseContext();

        // GET: UrunData
        public ActionResult Index() {
            return RedirectToActionPermanent("UrunListele", "Personel");
        }

        // POST: UrunData/UrunEkle
        [HttpPost]
        public ActionResult UrunEkle(Urun urun) {
            try {
                context.Urunler.Add(urun);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch {
                return RedirectToActionPermanent("UrunEkle", "Personel");
            }
        }

        // POST: UrunData/UrunGuncelle/5
        [HttpPost]
        public ActionResult UrunGuncelle(Urun urun) {
            try {
                context.Urunler.AddOrUpdate(urun);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch {
                return RedirectToActionPermanent("UrunGuncelle", "Personel");
            }
        }

        // GET: UrunData/UrunSil/5
        public ActionResult UrunSil(int id) {
            try {
                Urun urun = context.Urunler.Find(id);
                context.Urunler.Remove(urun);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch {
                return RedirectToActionPermanent("UrunGuncelle", "Personel");
            }
        }
    }
}