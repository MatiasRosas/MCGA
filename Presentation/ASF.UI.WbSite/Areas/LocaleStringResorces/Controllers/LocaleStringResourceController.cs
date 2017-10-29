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
            return View(lista);
        }

        // GET: LocaleStringResorces/Details
        public ActionResult Details(int id)
        {
            var lsp = new LocaleStringResourceProcess();
            var locstr = lsp.Find(id);

            return View(locstr);
        }

        // GET: LocaleStringResorces/Create
        public ActionResult Create()
        {
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