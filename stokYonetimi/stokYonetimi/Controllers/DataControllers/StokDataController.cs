using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace stokYonetimi.Controllers.DataControllers {
    public class StokDataController : Controller {
        // GET: StokData
        public ActionResult Index() {
            return View();
        }

        // GET: StokData/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: StokData/Create
        public ActionResult Create() {
            return View();
        }

        // POST: StokData/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection) {
            try {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }

        // GET: StokData/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: StokData/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection) {
            try {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }

        // GET: StokData/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: StokData/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection) {
            try {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }
    }
}