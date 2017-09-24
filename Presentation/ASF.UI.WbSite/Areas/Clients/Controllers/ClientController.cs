﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASF.UI.Process;
using ASF.Entities;

namespace ASF.UI.WbSite.Areas.Clients.Controllers
{
    public class ClientController : Controller
    {
        // GET: Clients/Client
        public ActionResult Index()
        {
            var cp = new ClientProcess();
            var lista = cp.SelectList();

            //var cop = new CountryProcess();
            //var descCountry = cop.Find(client.CountryId);
            //ViewData["Country"] = descCountry.Name;

            var cop = new CountryProcess();
            var listaCountries = cop.SelectList();
            ViewData["Country"] = listaCountries;

            return View(lista);
        }

        // GET: Clients/Details
        public ActionResult Details(int id)
        {
            var cp = new ClientProcess();
            var client = cp.Find(id);

            var cop = new CountryProcess();
            var descCountry = cop.Find(client.CountryId);
            ViewData["Country"] = descCountry.Name;

            return View(client);
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            var cp = new CountryProcess();
            var lista = cp.SelectList();
            ViewData["Country"] = lista;

            return View();
        }

        [HttpPost]
        // POST: Clients/Create
        public ActionResult Create(Client client)
        {
            var cp = new ClientProcess();
            cp.Insert(client);
            return RedirectToAction("Index");
        }

        // GET: Clients/Delete
        public ActionResult Delete(int id)
        {
            var cp = new ClientProcess();
            cp.Delete(id);
            return RedirectToAction("Index");
        }

        // GET: Clients/Edit
        public ActionResult Edit(int id)
        {
            var cp = new ClientProcess();
            var cat = cp.Find(id);

            var cop = new CountryProcess();
            var lista = cop.SelectList();
            ViewData["Country"] = lista;

            return View(cat);
        }

        [HttpPost]
        // POST: Clients/Edit
        public ActionResult Edit(Client client)
        {
            var cp = new ClientProcess();
            cp.Edit(client);
            return RedirectToAction("Index");
        }

    }
}