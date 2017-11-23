using OlympMotors.DAOClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OlympMotors.Models;

namespace OlympMotors.Controllers
{
    public class AspNetUserController : Controller
    {
        AspNetUserDAO Udao = new AspNetUserDAO();

        // GET: AspNetUser 
        public ActionResult Index()
        {
            return View(Udao.GetAllUsers());
        }

        // GET: AspNetUser/Details/5 
        public ActionResult Details(int id)
        {
            return View();
        }


        // GET: AspNetUser/Edit/5 
        public ActionResult Edit(string id)
        {
            AspNetUsers asp = Udao.GetUser(id);
            return View(asp);
        }

        // POST: AspNetUser/Edit/5 
        [HttpPost]
        public ActionResult Edit(string id, AspNetUsers contact)
        {
            if ((id != null) && (contact != null) && (ModelState.IsValid))
            {
                Udao.UpdateUser(contact);
                return RedirectToAction("Index");
            }
            else
            {

                return View("Edit");
            }
        }

        // GET: AspNetUser/Delete/5 
        public ActionResult Delete(string id)
        {
            return View("Delete", Udao.GetUser(id));
        }

        // POST: AspNetUser/Delete/5 
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            if (id != null && ModelState.IsValid)
            {
                Udao.DeleteUser(id);
                return RedirectToAction("Index");
            }

            else
                return View();
        }
    }
}
