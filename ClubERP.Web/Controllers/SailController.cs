using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;

namespace ClubERP.Web.Controllers
{
    public class SailController : Controller
    {
        // GET: Sail
        public ActionResult Index(string sailingModeId, string boatId, DateTime? departureDate)
        {
            List<DAO.Sail> result = new List<DAO.Sail>();
            result = ORM.Sail.List();
            foreach(DAO.Sail item in result)
            {
                item.DeparturePort = ORM.Port.Detail(item.DeparturePort.Id);
                item.ArrivalPort = ORM.Port.Detail(item.ArrivalPort.Id);
                item.SailingMode = ORM.SailingMode.Detail(item.SailingMode.Id);
                item.Boat = ORM.Boat.Detail(item.Boat.Id);
            }
            if (!String.IsNullOrEmpty(sailingModeId))
            {
                result = (from x in result
                          where x.SailingMode.Id == sailingModeId
                          select x).ToList();
            }
            if (!String.IsNullOrEmpty(boatId))
            {
                result = (from x in result
                          where x.Boat.Id == boatId
                          select x).ToList();
            }
            if (departureDate != null)
            {
                result = (from x in result
                          where x.DepartureDate >= departureDate
                          select x).ToList();
            }
            return View("Index", result);
        }

        // GET: Sail/Details/5
        public ActionResult Details(int id)
        {
            DAO.Sail result = new DAO.Sail();
            result = ORM.Sail.Detail(id);
            result.DeparturePort = ORM.Port.Detail(result.DeparturePort.Id);
            result.ArrivalPort = ORM.Port.Detail(result.ArrivalPort.Id);
            result.Boat = ORM.Boat.Detail(result.Boat.Id);
            result.SailingMode = ORM.SailingMode.Detail(result.SailingMode.Id);
            result.State = ORM.State.Detail(result.State.Id);
            result.Crew = ORM.Sail.CrewList(id);

            return View("MainDetails", result);
        }

        // GET: Sail/Create
        public ActionResult Create()
        {
            DAO.Sail result = new DAO.Sail();
            result.DepartureDate = DateTime.Now;
            result.ArrivalDate = DateTime.Now;
            result.Price = 0;
            return View(result);
        }

        // POST: Sail/Create
        [HttpPost]
        public ActionResult Create(DAO.Sail model, FormCollection collection)
        {
            DAO.Sail result = new DAO.Sail();
            try
            {
                result = model;
                result.TimeStamp = DateTime.Now;
                ORM.Sail.Save(result);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Sail/Edit/5
        public ActionResult Edit(int id)
        {
            DAO.Sail result = new DAO.Sail();
            result = ORM.Sail.Detail(id);
            return View(result);
        }

        // POST: Sail/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DAO.Sail model)
        {
            DAO.Sail result = new DAO.Sail();
            try
            {
                result = ORM.Sail.Detail(id);
                result.DepartureDate = model.DepartureDate;
                result.ArrivalDate = model.ArrivalDate;
                result.DeparturePort.Id = model.DeparturePort.Id;
                result.ArrivalPort.Id = model.ArrivalPort.Id;
                result.Boat.Id = model.Boat.Id;
                result.SailingMode.Id = model.SailingMode.Id;
                result.Price = model.Price;
                result.Commentary = model.Commentary;
                result.State.Id = model.State.Id;
                ORM.Sail.Save(result);
                result = ORM.Sail.Detail(id);
                return RedirectToAction("Details", "Sail", result);
            }
            catch
            {
                return View();
            }
        }

        // GET: Sail/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sail/Delete/5
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

        //public ActionResult Search(string boadId, string sailingModeId, DateTime? departureDate)
        //{
        //    DAO.SailSearch result = new DAO.SailSearch();

        //    DateTime targetDepartureDate = departureDate ?? DateTime.Now;
        //    result.Query.DepartureDate = targetDepartureDate;
        //    result.Query.Boat.Id = boadId;
        //    result.Query.SailingMode.Id = sailingModeId;
        //    result.Sails = ORM.Sail.Search(result.Query);


        //    return View(result);
        //}

        //[HttpPost]
        //public ActionResult Search(DAO.SailSearch model)
        //{
        //      return RedirectToAction("Search", new { departureDate=model.Query.DepartureDate, boadId=model.Query.Boat.Id, sailingModeId = model.Query.SailingMode.Id } );
        //}
    }
}
