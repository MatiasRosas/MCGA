using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASF.UI.Process;
using ASF.Entities;

namespace ASF.UI.WbSite.Areas.Orders.Controllers
{
    public class OrderController : Controller
    {
        // GET: Orders/Order
        public ActionResult Index()
        {
            var op = new OrderProcess();
            var lista = op.SelectList();
            return View(lista);
        }

        // GET: Orders/Details
        public ActionResult Details(int id)
        {
            var op = new OrderProcess();
            var order = op.Find(id);

            var cp = new ClientProcess();
            var descClient = cp.Find(order.ClientId);
            ViewData["Client"] = descClient.FirstName + " " + descClient.LastName;

            return View(order);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            var cp = new ClientProcess();
            var lista = cp.SelectList();
            ViewData["Client"] = lista;

            // se crean los estados válidos para el campo State

            List<State> listaState = new List<State>();

            var state1 = new State();
            state1.Id = 1;
            state1.Description = "Reviewed";
            listaState.Add(state1);

            var state2 = new State();
            state2.Id = 2;
            state2.Description = "Suspended";
            listaState.Add(state2);

            var state3 = new State();
            state3.Id = 3;
            state3.Description = "Closed";
            listaState.Add(state3);

            var state4 = new State();
            state4.Id = 4;
            state4.Description = "Cancelled";
            listaState.Add(state4);

            var state5 = new State();
            state5.Id = 5;
            state5.Description = "Approved";
            listaState.Add(state5);

            ViewData["State"] = listaState;

            return View();
        }

        [HttpPost]
        // POST: Orders/Create
        public ActionResult Create(Order order)
        {
            var op = new OrderProcess();
            op.Insert(order);
            return RedirectToAction("Index");
        }

        // GET: Orders/Delete
        public ActionResult Delete(int id)
        {
            var op = new OrderProcess();
            op.Delete(id);
            return RedirectToAction("Index");
        }

        // GET: Orders/Edit
        public ActionResult Edit(int id)
        {
            var op = new OrderProcess();
            var order = op.Find(id);

            var cp = new ClientProcess();
            var lista = cp.SelectList();
            ViewData["Client"] = lista;

            // se crean los estados válidos para el campo State

            List<State> listaState = new List<State>();

            var state = new State();

            state.Id = 1;
            state.Description = "Reviewed";
            listaState.Add(state);

            state.Id = 2;
            state.Description = "Suspended";
            listaState.Add(state);

            state.Id = 3;
            state.Description = "Closed";
            listaState.Add(state);

            state.Id = 4;
            state.Description = "Cancelled";
            listaState.Add(state);

            state.Id = 5;
            state.Description = "Approved";
            listaState.Add(state);

            ViewData["State"] = listaState;

            return View(order);
        }

        [HttpPost]
        // POST: Orders/Edit
        public ActionResult Edit(Order order)
        {
            var op = new OrderProcess();
            op.Edit(order);
            return RedirectToAction("Index");
        }

    }
}