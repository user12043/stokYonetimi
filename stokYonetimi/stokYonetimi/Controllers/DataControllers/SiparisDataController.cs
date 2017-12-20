using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stokYonetimi.Models;

namespace stokYonetimi.Controllers.DataControllers {
    public class SiparisDataController : Controller {
        private DatabaseContext context = new DatabaseContext();

        // GET: SiparisData
        public ActionResult Index() {
            return RedirectToActionPermanent("SiparisListele", "Musteri");
        }

        [HttpPost]
        public ActionResult SiparisEkle(FormCollection collection) {
            var miktar = Convert.ToInt32(collection.Get("miktar"));
            var fiyat = Convert.ToInt32(collection.Get("fiyat")); ;
            var urunId = Convert.ToInt32(collection.Get("urunId"));
            var fatura = new Fatura {
                Fiyat = fiyat,
                MusteriId = (int) Session["loggedUserId"]
            };

            context.Faturalar.Add(fatura);

            var siparis = new Siparis {
                Durum = false,
                Miktar = miktar,
                Tarih = DateTime.Now,
                Fiyat = fiyat,
                MusteriId = (int) Session["loggedUserId"],
                UrunId = urunId,
                Fatura = fatura
            };

            context.Siparisler.Add(siparis);

            context.SaveChanges();
            return RedirectToActionPermanent("SiparisListele", "Musteri");
        }
    }
}