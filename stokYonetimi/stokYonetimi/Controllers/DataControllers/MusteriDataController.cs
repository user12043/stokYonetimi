using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stokYonetimi.Models;

namespace stokYonetimi.Controllers.DataControllers {
    public class MusteriDataController : Controller {
        private DatabaseContext context = new DatabaseContext();

        // GET: MusteriData
        public ActionResult Index() {
            return RedirectToActionPermanent("MusteriListele", "Personel");
        }

        // POST: MusteriData/MusteriEkle
        [HttpPost]
        public ActionResult MusteriEkle(FormCollection collection) {
            try {
                var musteri = new Musteri();
                musteri.isim = collection.Get("isim");
                musteri.sifre = collection.Get("sifre");
                musteri.adres = collection.Get("adres");
                musteri.telefon = collection.Get("telefon");
                musteri.mailAdresi = collection.Get("mailAdres");
                musteri.resim = collection.Get("resim");
                musteri.rolu = 1;

                var query = context.Database.SqlQuery<int>("SELECT NEXT VALUE FOR [dbo].[SEQ_musteriler_musteriNo]");
                var task = query.FirstOrDefaultAsync();
                musteri.musteriNo = task.Result;

                context.musteriler.Add(musteri);

                context.SaveChanges();

                return RedirectToActionPermanent("Index");
            }
            catch {
                return RedirectToActionPermanent("MusteriEkle", "Personel");
            }
        }

        // POST: MusteriData/MusteriGuncelle
        [HttpPost]
        public ActionResult MusteriGuncelle(FormCollection collection) {
            Musteri musteri = new Musteri();
            try {
                musteri.kisiId = Convert.ToInt32(collection.Get("kisiId"));
                musteri.musteriNo = Convert.ToInt32(collection.Get("musteriNo"));
                musteri.isim = collection.Get("isim");
                musteri.sifre = collection.Get("sifre");
                musteri.adres = collection.Get("adres");
                musteri.telefon = collection.Get("telefon");
                musteri.mailAdresi = collection.Get("mailAdres");
                musteri.resim = collection.Get("resim");

                context.musteriler.AddOrUpdate(musteri);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch {
                return RedirectToActionPermanent("MusteriGuncelle", "Personel", musteri);
            }
        }

        // GET: MusteriData/MusteriSil/5
        public ActionResult MusteriSil(int id) {
            Musteri musteri = context.musteriler.Find(id);
            context.musteriler.Remove(musteri);
            context.SaveChanges();
            return RedirectToActionPermanent("MusteriListele", "Personel");
        }
    }
}