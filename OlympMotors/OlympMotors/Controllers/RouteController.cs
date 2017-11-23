using OlympMotors.DAOClass;
using OlympMotors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OlympMotors.Controllers
{
    public class RouteController : Controller
    {
        Entities entities = new Entities();
        RouteDAO Rdao = new RouteDAO();
        // GET: Transport
        public ActionResult Index()
        {
            return View(Rdao.GetAllRoutes());
        }

        // GET: Transport/Details/5
        public ActionResult Details(int id)
        {
            return View(Rdao.GetRoute(id));
        }

        // GET: Transport/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Transport/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "Id_Route")] Route route)
        {
            if (Rdao.AddRoute(route))
                return RedirectToAction("Index");
            else
            {

                return View("Create");
            }
        }

        // GET: Transport/Edit/5
        public ActionResult Edit(int id)
        {
            Route route = Rdao.GetRoute(id);
            return View(route);
        }

        // POST: Transport/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Route contact)
        {


            if ((id > 0) && (contact != null) && (ModelState.IsValid))
            {
                Rdao.UpdateRoute(contact);
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
            return View("Delete", Rdao.GetRoute(id));
        }

        // POST: Transport/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {

            if (id > 0 && ModelState.IsValid)
            {
                Rdao.DeleteRoute(id);
                return RedirectToAction("Index");
            }

            else
                return View();
        }
    }
}
