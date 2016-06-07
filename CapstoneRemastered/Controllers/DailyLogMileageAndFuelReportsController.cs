using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CapstoneRemastered.Models;

namespace CapstoneRemastered.Controllers
{
    public class DailyLogMileageAndFuelReportsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DailyLogMileageAndFuelReports
        public ActionResult Index()
        {
            return View(db.DailyLogMileageAndFuelReports.ToList());
        }

        // GET: DailyLogMileageAndFuelReports/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyLogMileageAndFuelReport dailyLogMileageAndFuelReport = db.DailyLogMileageAndFuelReports.Find(id);
            if (dailyLogMileageAndFuelReport == null)
            {
                return HttpNotFound();
            }
            return View(dailyLogMileageAndFuelReport);
        }

        // GET: DailyLogMileageAndFuelReports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DailyLogMileageAndFuelReports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Driver,DateofWork,Owner,Tractornumber,Trailernumber,Pronumber,State,Totalmilesdriven,Totalgaspurchased,Routestraveled,Odometerstart,Odometerfinish")] DailyLogMileageAndFuelReport dailyLogMileageAndFuelReport)
        {
            if (ModelState.IsValid)
            {
                db.DailyLogMileageAndFuelReports.Add(dailyLogMileageAndFuelReport);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dailyLogMileageAndFuelReport);
        }

        // GET: DailyLogMileageAndFuelReports/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyLogMileageAndFuelReport dailyLogMileageAndFuelReport = db.DailyLogMileageAndFuelReports.Find(id);
            if (dailyLogMileageAndFuelReport == null)
            {
                return HttpNotFound();
            }
            return View(dailyLogMileageAndFuelReport);
        }

        // POST: DailyLogMileageAndFuelReports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Driver,DateofWork,Owner,Tractornumber,Trailernumber,Pronumber,State,Totalmilesdriven,Totalgaspurchased,Routestraveled,Odometerstart,Odometerfinish")] DailyLogMileageAndFuelReport dailyLogMileageAndFuelReport)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dailyLogMileageAndFuelReport).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dailyLogMileageAndFuelReport);
        }

        // GET: DailyLogMileageAndFuelReports/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyLogMileageAndFuelReport dailyLogMileageAndFuelReport = db.DailyLogMileageAndFuelReports.Find(id);
            if (dailyLogMileageAndFuelReport == null)
            {
                return HttpNotFound();
            }
            return View(dailyLogMileageAndFuelReport);
        }

        // POST: DailyLogMileageAndFuelReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DailyLogMileageAndFuelReport dailyLogMileageAndFuelReport = db.DailyLogMileageAndFuelReports.Find(id);
            db.DailyLogMileageAndFuelReports.Remove(dailyLogMileageAndFuelReport);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

