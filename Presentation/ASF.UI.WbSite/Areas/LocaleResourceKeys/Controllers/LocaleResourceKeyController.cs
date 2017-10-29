using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASF.UI.Process;
using ASF.Entities;

namespace ASF.UI.WbSite.Areas.LocaleResourceKeys.Controllers
{
    public class LocaleResourceKeyController : Controller
    {
        // GET: LocaleResourceKeys/LocaleResourceKey
        public ActionResult Index()
        {
            var lrp = new LocaleResourceKeyProcess();
            var lista = lrp.SelectList();
            return View(lista);
        }

        // GET: LocaleResourceKeys/Details
        public ActionResult Details(int id)
        {
            var lrp = new LocaleResourceKeyProcess();
            var locres = lrp.Find(id);

            return View(locres);
        }

        // GET: LocaleResourceKeys/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        // POST: LocaleResourceKeys/Create
        public ActionResult Create(LocaleResourceKey locres)
        {
            locres.DateAdded = DateTime.Now;
            var lrp = new LocaleResourceKeyProcess();
            lrp.Insert(locres);
            return RedirectToAction("Index");
        }

        // GET: LocaleResourceKeys/Delete
        public ActionResult Delete(int id)
        {
            var lrp = new LocaleResourceKeyProcess();
            lrp.Delete(id);
            return RedirectToAction("Index");
        }

        // GET: LocaleResourceKeys/Edit
        public ActionResult Edit(int id)
        {
            var lrp = new LocaleResourceKeyProcess();
            var locres = lrp.Find(id);

            return View(locres);
        }

        [HttpPost]
        // POST: LocaleResourceKeys/Edit
        public ActionResult Edit(LocaleResourceKey locres)
        {
            var lrp = new LocaleResourceKeyProcess();
            lrp.Edit(locres);
            return RedirectToAction("Index");
        }
    }
}