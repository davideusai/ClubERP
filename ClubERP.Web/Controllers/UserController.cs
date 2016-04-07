using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClubERP.Web.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            List<DAO.User> result = new List<DAO.User>();
            result = ORM.User.List();
            return View(result);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            DAO.User result = new DAO.User();
            result = ORM.User.Detail(id);
            result.SkypperRank = ORM.SkypperRank.Detail(result.SkypperRank.Id);
            result.State = ORM.State.Detail(result.State.Id);
            return View(result);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                DAO.User user = new DAO.User();
                user.UserName = Request.Form["userName"];
                user.FirstName = Request.Form["firstName"];
                user.LastName = Request.Form["lastName"];
                user.eMail = Request.Form["eMail"];
                user.PhoneNumber = Request.Form["phoneNumber"];
                user.SkypperRank.Id = "COT";
                user.State.Id = "A";
                user.TimeStamp = DateTime.Now;
                ORM.User.Save(user);
               // user = ORM.User.Detail(1);
                return RedirectToAction("Index");
                //return RedirectToAction("Details", "User", user);
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            DAO.User result = new DAO.User();
            result = ORM.User.Detail(id);
            return View(result);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            DAO.User user = new DAO.User();
            try
            {
                user.UserName = Request.Form["userName"];
                user.FirstName = Request.Form["firstName"];
                user.LastName = Request.Form["lastName"];
                user.eMail = Request.Form["eMail"];
                user.PhoneNumber = Request.Form["phoneNumber"];
                user.SkypperRank.Id = Request.Form["SkypperRank.Id"];
                user.State.Id = Request.Form["State.Id"];
                user.TimeStamp = DateTime.Now;
                ORM.User.Save(user);

                user = ORM.User.Detail(id);
                return RedirectToAction("Details", "User", user);
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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
