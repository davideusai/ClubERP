using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClubERP.Web.Controllers
{
    public class StateController : Controller
    {
        // GET: State
        public ActionResult Index()
        {
            List<DAO.State> result = new List<DAO.State>();
            BLL.State objLoader = new BLL.State();
            result = objLoader.List();
            return View(result);
        }

        // GET: State/Details/5
        public ActionResult Details(string id)
        {
            DAO.State result = new DAO.State();
            BLL.State objLoader = new BLL.State();
            result = objLoader.Detail(id);
            return View(result);
        }

        // GET: State/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: State/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            DAO.State result = new DAO.State();
            try
            {
                result.Id = Request.Form["Id"];
                result.Name = Request.Form["Name"];
                result.Description = Request.Form["Description"];
                result.Family = Request.Form["Family"];
                result.TimeStamp = DateTime.Now;
                ORM.State.Save(result);
                result = ORM.State.Detail(result.Id);
                return RedirectToAction("Details", "State", result);
            }
            catch
            {
                return View();
            }
        }

        // GET: State/Edit/5
        public ActionResult Edit(string id)
        {
            DAO.State result = new DAO.State();
            result = ORM.State.Detail(id);
            return View(result);
        }

        // POST: State/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            DAO.State result = new DAO.State();
            try
            {
                result.Id = id;
                result.Name = Request.Form["Name"];
                result.Description = Request.Form["Description"];
                result.Family = Request.Form["Family"];
                result.TimeStamp = DateTime.Now;
                ORM.State.Save(result);
                result = ORM.State.Detail(id);
                return RedirectToAction("Details", "State", result);
            }
            catch
            {
                return View();
            }
        }

        // GET: State/Delete/5
        public ActionResult Delete(string id)
        {
            return View();
        }

        // POST: State/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                //Todo
                //ORM.State.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index");
            }
        }
    }
}
