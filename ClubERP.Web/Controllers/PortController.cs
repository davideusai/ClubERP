using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClubERP.Web.Controllers
{
    public class PortController : Controller
    {
        // GET: Port
        public ActionResult Index()
        {
            List<DAO.Port> result = new List<DAO.Port>();
            result = ORM.Port.List();
            return View(result);
        }

        // GET: Port/Details/5
        public ActionResult Details(string id)
        {
            DAO.Port result = new DAO.Port();
            result = ORM.Port.Detail(id);
            return View(result);
        }

        // GET: Port/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Port/Create
        [HttpPost]
        public ActionResult Create(DAO.Port model)
        {
            DAO.Port result = new DAO.Port();
            try
            {
                result = model;
                result.TimeStamp = DateTime.Now;
                ORM.Port.Save(result);
                return RedirectToAction("Details", "Port", result);
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Port/Edit/5
        public ActionResult Edit(string id)
        {
            DAO.Port result = new DAO.Port();
            result = ORM.Port.Detail(id);
            return View(result);
        }

        // POST: Port/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, DAO.Port model)
        {
            DAO.Port result = new DAO.Port();
            try
            {
                result = model;
                result.TimeStamp = DateTime.Now;
                ORM.Port.Save(result);
                return RedirectToAction("Details", "Port", result);
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Port/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Port/Delete/5
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
