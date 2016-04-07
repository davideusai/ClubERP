using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClubERP.Web.Controllers.Sail
{
    public class SailingModeController : Controller
    {
        // GET: SailingMode
        public ActionResult Index()
        {
            List<DAO.SailingMode> result = new List<DAO.SailingMode>();
            result = ORM.SailingMode.List();
            return View(result);
        }

        // GET: SailingMode/Details/5
        public ActionResult Details(string id)
        {
            DAO.SailingMode result = new DAO.SailingMode();
            result = ORM.SailingMode.Detail(id);
            return View(result);
        }

        // GET: SailingMode/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SailingMode/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            DAO.SailingMode result = new DAO.SailingMode();
            try
            {
                result.Id = Request.Form["Id"];
                result.Name = Request.Form["Name"];
                result.Description = Request.Form["Description"];
                result.State.Id = Request.Form["State.Id"];
                result.TimeStamp = DateTime.Now;
                ORM.SailingMode.Save(result);
                result = ORM.SailingMode.Detail(result.Id);
                return RedirectToAction("Details", "SailingMode", result);
            }
            catch
            {
                return View();
            }
        }

        // GET: SailingMode/Edit/5
        public ActionResult Edit(string id)
        {
            DAO.SailingMode result = new DAO.SailingMode();
            result = ORM.SailingMode.Detail(id);
            return View(result);
        }

        // POST: SailingMode/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            DAO.SailingMode result = new DAO.SailingMode();
            try
            {
                result.Id = id;
                result.Name = Request.Form["Name"];
                result.Description = Request.Form["Description"];
                result.State.Id = Request.Form["State.Id"];
                result.TimeStamp = DateTime.Now;
                ORM.SailingMode.Save(result);
                result = ORM.SailingMode.Detail(result.Id);
                return RedirectToAction("Details", "SailingMode", result);
            }
            catch
            {
                return View();
            }
        }

        // GET: SailingMode/Delete/5
        public ActionResult Delete(string id)
        {
            return View();
        }

        // POST: SailingMode/Delete/5
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
