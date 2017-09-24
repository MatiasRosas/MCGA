using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASF.UI.Process;
using ASF.Entities;

namespace ASF.UI.WbSite.Areas.OrderDetails.Controllers
{
    public class OrderDetailController : Controller
    {
        // GET: OrderDetails/OrderDetail
        public ActionResult Index()
        {
            var op = new OrderDetailProcess();
            var lista = op.SelectList();
            return View(lista);
        }

        // GET: OrderDetails/Details
        public ActionResult Details(int id)
        {
            var op = new OrderDetailProcess();
            var orderItem = op.Find(id);

            var pp = new ProductProcess();
            var descProd = pp.Find(orderItem.ProductId);
            ViewData["Product"] = descProd.Description;

            return View(orderItem);
        }

        // GET: OrderDetails/Create
        public ActionResult Create()
        {
            var op = new OrderProcess();
            var listaOrder = op.SelectList();
            ViewData["Order"] = listaOrder;

            var pp = new ProductProcess();
            var listaProd = pp.SelectList();
            ViewData["Product"] = listaProd;

            return View();
        }

        [HttpPost]
        // POST: OrderDetails/Create
        public ActionResult Create(OrderDetail orderDetails)
        {
            var op = new OrderDetailProcess();
            op.Insert(orderDetails);
            return RedirectToAction("Index");
        }

        // GET: OrderDetails/Delete
        public ActionResult Delete(int id)
        {
            var op = new OrderDetailProcess();
            op.Delete(id);
            return RedirectToAction("Index");
        }

        // GET: OrderDetails/Edit
        public ActionResult Edit(int id)
        {
            var oip = new OrderDetailProcess();
            var orderItem = oip.Find(id);

            var op = new OrderProcess();
            var listaOrder = op.SelectList();
            ViewData["Order"] = listaOrder;

            var pp = new ProductProcess();
            var listaProd = pp.SelectList();
            ViewData["Product"] = listaProd;

            return View(orderItem);
        }

        [HttpPost]
        // POST: OrderDetails/Edit
        public ActionResult Edit(OrderDetail orderDetails)
        {
            var op = new OrderDetailProcess();
            op.Edit(orderDetails);
            return RedirectToAction("Index");
        }

    }
}