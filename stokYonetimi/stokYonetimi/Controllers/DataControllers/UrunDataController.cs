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
                context.urunler.Add(urun);
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
                context.urunler.AddOrUpdate(urun);
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
                Urun urun = context.urunler.Find(id);
                context.urunler.Remove(urun);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch {
                return RedirectToActionPermanent("UrunGuncelle", "Personel");
            }
        }
    }
}