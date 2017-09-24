using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASF.UI.Process;
using ASF.Entities;

namespace ASF.UI.WbSite.Areas.Ratings.Controllers
{
    public class RatingController : Controller
    {
        // GET: Ratings/Rating
        public ActionResult Index()
        {
            var rp = new RatingProcess();
            var lista = rp.SelectList();
            return View(lista);
        }

        // GET: Ratings/Details
        public ActionResult Details(int id)
        {
            var rp = new RatingProcess();
            var rtng = rp.Find(id);

            var cp = new ClientProcess();
            var descClient = cp.Find(rtng.ClientId);
            ViewData["Client"] = descClient.FirstName + " " + descClient.LastName;

            var pp = new ProductProcess();
            var descProd = pp.Find(rtng.ProductId);
            ViewData["Product"] = descProd.Description;

            return View(rtng);
        }

        // GET: Ratings/Create
        public ActionResult Create()
        {
            var cp = new ClientProcess();
            var listaClient = cp.SelectList();
            ViewData["Client"] = listaClient;

            var pp = new ProductProcess();
            var listaProd = pp.SelectList();
            ViewData["Product"] = listaProd;

            return View();
        }

        [HttpPost]
        // POST: Ratings/Create
        public ActionResult Create(Rating rating)
        {
            var rp = new RatingProcess();
            rp.Insert(rating);
            return RedirectToAction("Index");
        }

        // GET: Ratings/Delete
        public ActionResult Delete(int id)
        {
            var rp = new RatingProcess();
            rp.Delete(id);
            return RedirectToAction("Index");
        }

        // GET: Ratings/Edit
        public ActionResult Edit(int id)
        {
            var rp = new RatingProcess();
            var rtng = rp.Find(id);

            var cp = new ClientProcess();
            var listaClient = cp.SelectList();
            ViewData["Client"] = listaClient;

            var pp = new ProductProcess();
            var listaProd = pp.SelectList();
            ViewData["Product"] = listaProd;

            return View(rtng);
        }

        [HttpPost]
        // POST: Ratings/Edit
        public ActionResult Edit(Rating rating)
        {
            var rp = new RatingProcess();
            rp.Edit(rating);
            return RedirectToAction("Index");
        }

    }
}