using OlympMotors.DAOClass;
using OlympMotors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OlympMotors.Controllers
{
    public class FlightController : Controller
    {
        Entities entities = new Entities();
        FlightDAO Fdao = new FlightDAO();
        RouteDAO Rdao = new RouteDAO();
        // GET: Transport
        public ActionResult Index()
        {
            return View(Fdao.GetAllFlights());
        }

        // GET: Transport/Details/5
        public ActionResult Details(int id)
        {
            return View(Fdao.GetFlight(id));
        }

        //protected bool ViewDataSelectList(int route_id)
        //{
        //    var routes = Rdao.GetAllRoutes();
        //    ViewData["IdRoute"] = new SelectList(routes, "Id", "StartPoint", route_id);
        //    return routes.Count() > 0;
        //}


        // GET: Transport/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Transport/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "Id_Flight")] Flight flight)
        {
            if (Fdao.AddFlight(flight))
                return RedirectToAction("Index");
            else
            {

                return View("Create");
            }
        }

        // GET: Transport/Edit/5
        public ActionResult Edit(int id)
        {
            Flight flight = Fdao.GetFlight(id);
            return View(flight);
        }

        // POST: Transport/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Flight contact)
        {


            if ((id > 0) && (contact != null) && (ModelState.IsValid))
            {
                Fdao.UpdateFlight(contact);
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
            return View("Delete", Fdao.GetFlight(id));
        }

        // POST: Transport/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {

            if (id > 0 && ModelState.IsValid)
            {
                Fdao.DeleteFlight(id);
                return RedirectToAction("Index");
            }

            else
                return View();
        }
    }
}
