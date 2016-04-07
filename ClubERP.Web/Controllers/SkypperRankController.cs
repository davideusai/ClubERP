using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClubERP.Web.Controllers
{
    public class SkypperRankController : Controller
    {
        // GET: SkypperRank
        public ActionResult Index()
        {
            List<DAO.SkypperRank> result = new List<DAO.SkypperRank>();
            result = ORM.SkypperRank.List();
            return View(result);
        }

        // GET: SkypperRank/Details/5
        public ActionResult Details(string id)
        {
            DAO.SkypperRank result = new DAO.SkypperRank();
            result = ORM.SkypperRank.Detail(id);
            return View(result);
        }

        // GET: SkypperRank/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SkypperRank/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            DAO.SkypperRank result = new DAO.SkypperRank();
            try
            {
                result.Id = Request.Form["Id"];
                result.Name = Request.Form["Name"];
                result.Description = Request.Form["Description"];
                result.Position = Convert.ToInt16(Request.Form["Position"]);
                result.State.Id = Request.Form["State.Id"];
                result.TimeStamp = DateTime.Now;
                ORM.SkypperRank.Save(result);
                result = ORM.SkypperRank.Detail(result.Id);
                return RedirectToAction("Details", "SkypperRank", result);
            }
            catch
            {
                return View();
            }
        }

        // GET: SkypperRank/Edit/5
        public ActionResult Edit(string id)
        {
            DAO.SkypperRank result = new DAO.SkypperRank();
            result = ORM.SkypperRank.Detail(id);
            return View(result);
        }

        // POST: SkypperRank/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            DAO.SkypperRank result = new DAO.SkypperRank();
            try
            {
                result.Id = id;
                result.Name = Request.Form["Name"];
                result.Description = Request.Form["Description"];
                result.Position = Convert.ToInt16(Request.Form["Position"]);
                result.State.Id = Request.Form["State.Id"];
                result.TimeStamp = DateTime.Now;
                ORM.SkypperRank.Save(result);
                result = ORM.SkypperRank.Detail(id);
                return RedirectToAction("Details", "SkypperRank", result);
            }
            catch
            {
                return View();
            }
        }

        // GET: SkypperRank/Delete/5
        public ActionResult Delete(string id)
        {
            return View();
        }

        // POST: SkypperRank/Delete/5
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
