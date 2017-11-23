using OlympMotors.DAOClass;
using OlympMotors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OlympMotors.Controllers
{
    public class ConductorController : Controller
    {
        Entities entities = new Entities();
        ConductorDAO Cdao = new ConductorDAO();
        // GET: Transport
        public ActionResult Index()
        {
            return View(Cdao.GetAllConductors());
        }

        // GET: Transport/Details/5
        public ActionResult Details(int id)
        {
            return View(Cdao.GetConductor(id));
        }

        // GET: Transport/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Transport/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "Id")] Conductor conductor)
        {
            if (Cdao.AddConductor(conductor))
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
        public ActionResult Edit(int id, Conductor contact)
        {


            if ((id > 0) && (contact != null) && (ModelState.IsValid))
            {
                Cdao.UpdateConductor(contact);
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
            return View("Delete", Cdao.GetConductor(id));
        }

        // POST: Transport/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {

            if (id > 0 && ModelState.IsValid)
            {
                Cdao.DeleteConductor(id);
                return RedirectToAction("Index");
            }

            else
                return View();
        }
    }
}