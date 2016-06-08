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
    public class HourBreakdownsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: HourBreakdowns
        public ActionResult Index()
        {
            return View(db.HourBreakdowns.ToList());
        }

        // GET: HourBreakdowns/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HourBreakdown hourBreakdown = db.HourBreakdowns.Find(id);
            if (hourBreakdown == null)
            {
                return HttpNotFound();
            }
            return View(hourBreakdown);
        }

        // GET: HourBreakdowns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HourBreakdowns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Driver,Hoursworked,VehicleNumbers,Signature,CoDriver,OnDutyHours,OffDutyHours,OnDutyHours2,OffDutyHours2,OnDutyHours3,OffDutyHours3,TotalHours")] HourBreakdown hourBreakdown)
        {
            if (ModelState.IsValid)
            {
                db.HourBreakdowns.Add(hourBreakdown);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hourBreakdown);
        }

        // GET: HourBreakdowns/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HourBreakdown hourBreakdown = db.HourBreakdowns.Find(id);
            if (hourBreakdown == null)
            {
                return HttpNotFound();
            }
            return View(hourBreakdown);
        }

        // POST: HourBreakdowns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Driver,Hoursworked,VehicleNumbers,Signature,CoDriver,OnDutyHours,OffDutyHours,OnDutyHours2,OffDutyHours2,OnDutyHours3,OffDutyHours3,TotalHours")] HourBreakdown hourBreakdown)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hourBreakdown).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hourBreakdown);
        }

        // GET: HourBreakdowns/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HourBreakdown hourBreakdown = db.HourBreakdowns.Find(id);
            if (hourBreakdown == null)
            {
                return HttpNotFound();
            }
            return View(hourBreakdown);
        }

        // POST: HourBreakdowns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HourBreakdown hourBreakdown = db.HourBreakdowns.Find(id);
            db.HourBreakdowns.Remove(hourBreakdown);
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
