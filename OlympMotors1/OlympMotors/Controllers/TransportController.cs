using OlympMotors.DAOClass;
using OlympMotors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OlympMotors.Controllers
{
    public class TransportController : Controller
    {
        Entities entities = new Entities();
        TransportDAO Tdao = new TransportDAO();
        // GET: Transport
        public ActionResult Index()
        {
            return View(Tdao.GetAllTransports());
        }

        // GET: Transport/Details/5
        public ActionResult Details(int id)
        {
            return View(Tdao.GetTransport(id));
        }

        // GET: Transport/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Transport/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "Id")] Transport transport)
        {
            if (Tdao.AddTransport(transport))
                return RedirectToAction("Index");
            else
            {

                return View("Create");
            }
        }

        // GET: Transport/Edit/5
        public ActionResult Edit(int id)
        {
            return View("Edit");
        }

        // POST: Transport/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Transport contact)
        {


            if ((id > 0) && (contact != null) && (ModelState.IsValid))
            {
                Tdao.UpdateTransport(contact);
                return RedirectToAction("Index");
            }
            else
            {

                return View("Edit");
            }

        }

        // GET: Transport/Delete/5
        public ActionResult Delete(int id)
        {
            return View("Delete", Tdao.GetTransport(id));
        }

        // POST: Transport/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {

            if (id > 0 && ModelState.IsValid)
            {
                Tdao.DeleteTransport(id);
                return RedirectToAction("Index");
            }

            else
                return View();
        }
    }
}

