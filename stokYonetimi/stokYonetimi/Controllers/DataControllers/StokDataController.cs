using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stokYonetimi.Models;

namespace stokYonetimi.Controllers.DataControllers {
    public class StokDataController : Controller {
        private DatabaseContext context = new DatabaseContext();

        // GET: StokData
        public ActionResult Index() {
            return RedirectToActionPermanent("StokListele", "Personel");
        }

        // POST: StokData/StokEkle
        [HttpPost]
        public ActionResult StokEkle(Stok stok) {
            try {
                stok.OlusturulmaTarihi = DateTime.Now;
                context.Stoklar.Add(stok);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch {
                return RedirectToActionPermanent("StokEkle", "Personel");
            }
        }

        // POST: StokData/StokGuncelle
        [HttpPost]
        public ActionResult StokGuncelle(Stok stok) {
            try {
                context.Stoklar.AddOrUpdate(stok);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch {
                return RedirectToActionPermanent("StokGuncelle", "Personel");
            }
        }

        // GET: StokData/StokSil/5
        public ActionResult StokSil(int id) {
            try {
                Stok stok = context.Stoklar.Find(id);
                context.Stoklar.Remove(stok);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch {
                return RedirectToActionPermanent("StokGuncelle", "Personel");
            }
        }
    }
}