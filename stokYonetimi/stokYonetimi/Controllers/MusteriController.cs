using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace stokYonetimi.Controllers {
    public class MusteriController : Controller {
        // GET: Musteri
        public ActionResult SiparisVer() {
            return View();
        }

        public ActionResult SiparisListele() {
            return View();
        }

        public ActionResult SepeteGit() {
            return View();
        }
    }
}