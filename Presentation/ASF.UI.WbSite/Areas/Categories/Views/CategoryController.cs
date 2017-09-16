using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASF.UI.Process;
using ASF.Entities;

namespace ASF.UI.WbSite.Areas.Categories.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Categories/Category
        public ActionResult Index()
        {
            var cp = new CategoryProcess();
            var lista = cp.SelectList();

            return View(lista);
        }

        // GET: Categories/Details
        public ActionResult Details(int id)
        {
            var cp = new CategoryProcess();
            var cat = cp.Find(id);

            return View(cat);
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        // POST: Categories/Create
        public ActionResult Create(Category cat)
        {
            var cp = new CategoryProcess();
            cp.Insert(cat);
            return RedirectToAction("Index");
        }

        // GET: Categories/Delete
        public ActionResult Delete(int id)
        {
            var cp = new CategoryProcess();
            cp.Delete(id);
            return RedirectToAction("Index");
        }

        // GET: Categories/Edit
        public ActionResult Edit(int id)
        {
            var cp = new CategoryProcess();
            var cat = cp.Find(id);

            return View(cat);
        }

        [HttpPost]
        // POST: Categories/Edit
        public ActionResult Edit(Category cat)
        {
            var cp = new CategoryProcess();
            cp.Edit(cat);
            return RedirectToAction("Index");
        }

    }
}