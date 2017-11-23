using OlympMotors.DAOClass;
using OlympMotors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OlympMotors.Controllers
{
    public class DriverController : Controller
    {
        Entities entities = new Entities();
        DriverDAO Ddao = new DriverDAO();
        // GET: Transport
        public ActionResult Index()
        {
            return View(Ddao.GetAllDrivers());
        }

        // GET: Transport/Details/5
        public ActionResult Details(int id)
        {
            return View(Ddao.GetDriver(id));
        }

        // GET: Transport/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Transport/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "Id_Driver")] Driver driver)
        {
            if (Ddao.AddDriver(driver))
                return RedirectToAction("Index");
            else
            {

                return View("Create");
            }
        }

        // GET: Transport/Edit/5
        public ActionResult Edit(int id)
        {
            Driver driver = Ddao.GetDriver(id);
            return View(driver);
        }

        // POST: Transport/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Driver contact)
        {


            if ((id > 0) && (contact != null) && (ModelState.IsValid))
            {
                Ddao.UpdateDriver(contact);
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
            return View("Delete", Ddao.GetDriver(id));
        }

        // POST: Transport/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {

            if (id > 0 && ModelState.IsValid)
            {
                Ddao.DeleteDriver(id);
                return RedirectToAction("Index");
            }

            else
                return View();
        }
    }
}