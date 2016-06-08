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
    public class VehicleConditionReportsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: VehicleConditionReports
        public ActionResult Index()
        {
            return View(db.VehicleConditionReports.ToList());
        }

        // GET: VehicleConditionReports/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleConditionReport vehicleConditionReport = db.VehicleConditionReports.Find(id);
            if (vehicleConditionReport == null)
            {
                return HttpNotFound();
            }
            return View(vehicleConditionReport);
        }

        // GET: VehicleConditionReports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehicleConditionReports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,brakeLinesToTrailerPre,brakeLinesToTrailerPost,electricLinesToTrailerPre,electricLinesToTrailerPost,driveLinePre,driveLinePost,couplingDevicePre,couplingDevicePost,tiresandWheelsPre,tiresandWheelsPost,springsPre,springsPost,bodyPre,bodyPost,glassPre,glassPost,torchesAndReflectorsAndLanternsPre,torchesAndReflectorsAndLanternsPost,fusersPre,fusersPost,flagsPre,flagsPost,spareBulbsPre,spareBulbsPost,fusesPre,fusesPost,fireExtinquisherPre,fireExtinquisherPost,tireChainsPre,tireChainsPost,afterStartingEnginePre,afterStartingEnginePost,fuelSystemPre,fuelSystemPost,coolingSystemPre,coolingSystemPost,enginePre,enginePost,leaksPre,leaksPost,lightsPre,lightsPost,tailPre,tailPost,stopAndTurnPre,stopAndTurnPost,clearanceAndMarkerPre,clearanceAndMarkerPost,reflectorsPre,reflectorsPost,airPressureWarningDevicePre,airPressureWarningDevicePost,oilPressurePre,oilPressurePost,AmmeterPre,AmmeterPost,hornPre,hornPost,windshieldWipersPre,windshieldWipersPost,parkingBrakesPre,parkingBrakesPost,clutchPre,clutchPost,transmissionPre,transmissionPost,rearVisionMirrorPre,rearVisionMirrorPost,sterringPre,sterringPost,serviceBreaksPre,serviceBreaksPost,speedometerPre,speedometerPost,OtherItemsPre,OtherItemsPost,vehicleNumber,date,mechanicsSignature,driverSignature")] VehicleConditionReport vehicleConditionReport)
        {
            if (ModelState.IsValid)
            {
                db.VehicleConditionReports.Add(vehicleConditionReport);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vehicleConditionReport);
        }

        // GET: VehicleConditionReports/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleConditionReport vehicleConditionReport = db.VehicleConditionReports.Find(id);
            if (vehicleConditionReport == null)
            {
                return HttpNotFound();
            }
            return View(vehicleConditionReport);
        }

        // POST: VehicleConditionReports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,brakeLinesToTrailerPre,brakeLinesToTrailerPost,electricLinesToTrailerPre,electricLinesToTrailerPost,driveLinePre,driveLinePost,couplingDevicePre,couplingDevicePost,tiresandWheelsPre,tiresandWheelsPost,springsPre,springsPost,bodyPre,bodyPost,glassPre,glassPost,torchesAndReflectorsAndLanternsPre,torchesAndReflectorsAndLanternsPost,fusersPre,fusersPost,flagsPre,flagsPost,spareBulbsPre,spareBulbsPost,fusesPre,fusesPost,fireExtinquisherPre,fireExtinquisherPost,tireChainsPre,tireChainsPost,afterStartingEnginePre,afterStartingEnginePost,fuelSystemPre,fuelSystemPost,coolingSystemPre,coolingSystemPost,enginePre,enginePost,leaksPre,leaksPost,lightsPre,lightsPost,tailPre,tailPost,stopAndTurnPre,stopAndTurnPost,clearanceAndMarkerPre,clearanceAndMarkerPost,reflectorsPre,reflectorsPost,airPressureWarningDevicePre,airPressureWarningDevicePost,oilPressurePre,oilPressurePost,AmmeterPre,AmmeterPost,hornPre,hornPost,windshieldWipersPre,windshieldWipersPost,parkingBrakesPre,parkingBrakesPost,clutchPre,clutchPost,transmissionPre,transmissionPost,rearVisionMirrorPre,rearVisionMirrorPost,sterringPre,sterringPost,serviceBreaksPre,serviceBreaksPost,speedometerPre,speedometerPost,OtherItemsPre,OtherItemsPost,vehicleNumber,date,mechanicsSignature,driverSignature")] VehicleConditionReport vehicleConditionReport)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicleConditionReport).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vehicleConditionReport);
        }

        // GET: VehicleConditionReports/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleConditionReport vehicleConditionReport = db.VehicleConditionReports.Find(id);
            if (vehicleConditionReport == null)
            {
                return HttpNotFound();
            }
            return View(vehicleConditionReport);
        }

        // POST: VehicleConditionReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VehicleConditionReport vehicleConditionReport = db.VehicleConditionReports.Find(id);
            db.VehicleConditionReports.Remove(vehicleConditionReport);
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
