using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClubERP.Web.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        public ActionResult Index()
        {
            List<DAO.Role> result = new List<DAO.Role>();
            result = ORM.Role.List();
            return View(result);
        }

        // GET: Role/Details/5
        public ActionResult Details(string id)
        {
            DAO.Role result = new DAO.Role();
            result = ORM.Role.Detail(id);
            return View(result);
        }

        // GET: Role/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Role/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            DAO.Role result = new DAO.Role();
            try
            {
                result.Id = Request.Form["Id"];
                result.Name = Request.Form["Name"];
                result.Description = Request.Form["Description"];
                result.State.Id = Request.Form["State.Id"];
                result.TimeStamp = DateTime.Now;
                ORM.Role.Save(result);
                result = ORM.Role.Detail(result.Id);
                return RedirectToAction("Details", "Role", result);
            }
            catch
            {
                return View();
            }
        }

        // GET: Role/Edit/5
        public ActionResult Edit(string id)
        {
            DAO.Role result = new DAO.Role();
            result = ORM.Role.Detail(id);
            return View(result);
        }

        // POST: Role/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            DAO.Role result = new DAO.Role();
            try
            {
                result.Id = id;
                result.Name = Request.Form["Name"];
                result.Description = Request.Form["Description"];
                result.State.Id = Request.Form["State.Id"];
                result.TimeStamp = DateTime.Now;
                ORM.Role.Save(result);
                result = ORM.Role.Detail(id);
                return RedirectToAction("Details", "Role", result);
            }
            catch
            {
                return View();
            }
        }

        // GET: Role/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Role/Delete/5
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
