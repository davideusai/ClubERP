using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClubERP.Web.Controllers
{
    public class BoatController : Controller
    {
        // GET: Boat
        public ActionResult Index()
        {
            List<DAO.Boat> result = new List<DAO.Boat>();
            result = ORM.Boat.List();
            return View(result);
        }

        // GET: Boat/Details/5
        public ActionResult Details(string id)
        {
            DAO.Boat result = new DAO.Boat();
            result = ORM.Boat.Detail(id);
            result.State = ORM.State.Detail(result.State.Id);
            return View(result);
        }

        // GET: Boat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Boat/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            DAO.Boat result = new DAO.Boat();
            try
            {
                result.Id = Request.Form["Id"];
                result.Name = Request.Form["Name"];
                result.Description = Request.Form["Description"];
                result.DateBuild = Convert.ToDateTime(Request.Form["DateBuild"]);
                result.DateEntryClub = Convert.ToDateTime(Request.Form["DateEntryClub"]);
                result.CrewMax = Convert.ToInt16(Request.Form["CrewMax"]);
                result.MinSkypperRank.Id = Request.Form["MinSkypperRank.Id"];
                result.Photo = Request.Form["Photo"];
                result.State.Id = Request.Form["State.Id"];
                result.TimeStamp = DateTime.Now;
                ORM.Boat.Save(result);
                result = ORM.Boat.Detail(result.Id);
                return RedirectToAction("Details", "Boat", result);
            }
            catch
            {
                return View();
            }
        }

        // GET: Boat/Edit/5
        public ActionResult Edit(string id)
        {
            DAO.Boat result = new DAO.Boat();
            result = ORM.Boat.Detail(id);
            return View(result);
        }

        // POST: Boat/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            DAO.Boat result = new DAO.Boat();
            try
            {

                result.Id = id;
                result.Name = Request.Form["Name"];
                result.Description = Request.Form["Description"];
                result.DateBuild = Convert.ToDateTime(Request.Form["DateBuild"]);
                result.DateEntryClub = Convert.ToDateTime(Request.Form["DateEntryClub"]);
                result.CrewMax = Convert.ToInt16(Request.Form["CrewMax"]);
                result.MinSkypperRank.Id = Request.Form["MinSkypperRank.Id"];
                result.Photo = Request.Form["Photo"];
                result.State.Id = Request.Form["State.Id"];
                result.TimeStamp = DateTime.Now;
                ORM.Boat.Save(result);
                result = ORM.Boat.Detail(result.Id);
                return RedirectToAction("Details", "Boat", result);
            }
            catch
            {
                return View();
            }
        }

        // GET: Boat/Delete/5
        public ActionResult Delete(string id)
        {
            return View();
        }

        // POST: Boat/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
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
