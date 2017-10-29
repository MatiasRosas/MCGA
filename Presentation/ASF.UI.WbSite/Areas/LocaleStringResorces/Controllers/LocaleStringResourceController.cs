using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASF.UI.Process;
using ASF.Entities;


namespace ASF.UI.WbSite.Areas.LocaleStringResorces.Controllers
{
    public class LocaleStringResourceController : Controller
    {
        // GET: LocaleStringResorces/LocaleStringResource
        public ActionResult Index()
        {
            var lsp = new LocaleStringResourceProcess();
            var lista = lsp.SelectList();

            var lp = new LanguageProcess();
            var listaLanguages = lp.SelectList();
            ViewData["Language"] = listaLanguages;

            var lrp = new LocaleResourceKeyProcess();
            var listaLocRes = lrp.SelectList();
            ViewData["LocRes"] = listaLocRes;

            return View(lista);
        }

        // GET: LocaleStringResorces/Details
        public ActionResult Details(int id)
        {
            var lsp = new LocaleStringResourceProcess();
            var locstr = lsp.Find(id);

            var lp = new LanguageProcess();
            var descLanguage = lp.Find(locstr.Language_Id);
            ViewData["Language"] = descLanguage.Name;

            var lrp = new LocaleResourceKeyProcess();
            var descLocRes = lrp.Find(locstr.LocaleResourceKey_Id);
            ViewData["LocRes"] = descLocRes.Name;

            return View(locstr);
        }

        // GET: LocaleStringResorces/Create
        public ActionResult Create()
        {
            var lp = new LanguageProcess();
            var listaLanguages = lp.SelectList();
            ViewData["Language"] = listaLanguages;

            var lrp = new LocaleResourceKeyProcess();
            var listaLocRes = lrp.SelectList();
            ViewData["LocRes"] = listaLocRes;

            return View();
        }

        [HttpPost]
        // POST: LocaleStringResorces/Create
        public ActionResult Create(LocaleStringResource locstr)
        {
            var lsp = new LocaleStringResourceProcess();
            lsp.Insert(locstr);
            return RedirectToAction("Index");
        }

        // GET: LocaleStringResorces/Delete
        public ActionResult Delete(int id)
        {
            var lsp = new LocaleStringResourceProcess();
            lsp.Delete(id);
            return RedirectToAction("Index");
        }

        // GET: LocaleStringResorces/Edit
        public ActionResult Edit(int id)
        {
            var lsp = new LocaleStringResourceProcess();
            var locstr = lsp.Find(id);

            var lp = new LanguageProcess();
            var listaLanguages = lp.SelectList();
            ViewData["Language"] = listaLanguages;

            var lrp = new LocaleResourceKeyProcess();
            var listaLocRes = lrp.SelectList();
            ViewData["LocRes"] = listaLocRes;

            return View(locstr);
        }

        [HttpPost]
        // POST: LocaleStringResorces/Edit
        public ActionResult Edit(LocaleStringResource locstr)
        {
            var lsp = new LocaleStringResourceProcess();
            lsp.Edit(locstr);
            return RedirectToAction("Index");
        }

    }
}