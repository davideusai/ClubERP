using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace ClubERP.Web.Controllers
{
    public class CrewController : Controller
    {
        // GET: Crew
        public ActionResult Index(int id)
        {
            List<DAO.Crew> result = new List<DAO.Crew>();
            result = ORM.Sail.CrewList(id);
            return View(result);
        }

        // GET: Crew/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Crew/Create
        public ActionResult Add(int id)
        {
            return View();
        }

        // POST: Crew/Create
        [HttpPost]
        public ActionResult Add(int id, DAO.Crew model)
        {
            DAO.Crew result = new DAO.Crew();
                 
            try
            {
                result = model;
                string temp = User.Identity.Name;
               // result.User.Id = User.Identity.GetUserId();
                result.TimeStamp = DateTime.Now;
                ORM.Sail.AddCrew(id, result);
            }
            catch (Exception e)
            {
            }
            if (ModelState.IsValid)
            {
                //do work
                return Json(new { success = true });
            }
            return RedirectToAction("Details", "Sail", id);
        }

        // GET: Crew/Edit/5
        public ActionResult Edit(int id)
        {
            DAO.Crew result = new DAO.Crew();
            result = ORM.Crew.Detail(id);
            return View(result);
        }

        // POST: Crew/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DAO.Crew model)
        {
            DAO.Crew result = new DAO.Crew();

            try
            {
                result = model;
                string temp = User.Identity.Name;
                //result.User.Id = User.Identity.GetUserId();
                result.TimeStamp = DateTime.Now;
                ORM.Sail.AddCrew(id, result);
            }
            catch (Exception e)
            {
            }
            if (ModelState.IsValid)
            {
                //do work
                return Json(new { success = true });
            }
            return RedirectToAction("Details", "Sail", id);
        }


        // GET: Crew/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Crew/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
