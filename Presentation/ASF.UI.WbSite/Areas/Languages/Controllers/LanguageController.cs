using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASF.UI.Process;
using ASF.Entities;


namespace ASF.UI.WbSite.Areas.Languages.Controllers
{
    public class LanguageController : Controller
    {
        // GET: Languages/Language
        public ActionResult Index()
        {
            var lp = new LanguageProcess();
            var lista = lp.SelectList();
            return View(lista);
        }

        // GET: Languages/Details
        public ActionResult Details(int id)
        {
            var lp = new LanguageProcess();
            var lang = lp.Find(id);

            return View(lang);
        }

        // GET: Languages/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        // POST: Languages/Create
        public ActionResult Create(Language lang)
        {
            var lp = new LanguageProcess();
            lp.Insert(lang);
            return RedirectToAction("Index");
        }

        // GET: Languages/Delete
        public ActionResult Delete(int id)
        {
            var lp = new LanguageProcess();
            lp.Delete(id);
            return RedirectToAction("Index");
        }

        // GET: Languages/Edit
        public ActionResult Edit(int id)
        {
            var lp = new LanguageProcess();
            var lang = lp.Find(id);

            return View(lang);
        }

        [HttpPost]
        // POST: Languages/Edit
        public ActionResult Edit(Language lang)
        {
            var lp = new LanguageProcess();
            lp.Edit(lang);
            return RedirectToAction("Index");
        }

    }
}