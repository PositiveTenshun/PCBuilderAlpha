using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DBModel;

namespace PCBuilder.Controllers
{
    public class HardDrivesController : Controller
    {
        private CapstoneModelContainer db = new CapstoneModelContainer();

        // GET: HardDrives
        public ActionResult Index()
        {
            return View(db.Components.OfType<HardDrive>().ToList());
        }

        // GET: HardDrives/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HardDrive hardDrive = (HardDrive)db.Components.Find(id);
            if (hardDrive == null)
            {
                return HttpNotFound();
            }
            return View(hardDrive);
        }

        // GET: HardDrives/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HardDrives/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ComponentId,Brand,ModelNumber,ModelName,Rating,ProductCode,Price,HardDriveId,Capacity,IsSSD")] HardDrive hardDrive)
        {
            if (ModelState.IsValid)
            {
                db.Components.Add(hardDrive);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hardDrive);
        }

        // GET: HardDrives/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HardDrive hardDrive = (HardDrive)db.Components.Find(id);
            if (hardDrive == null)
            {
                return HttpNotFound();
            }
            return View(hardDrive);
        }

        // POST: HardDrives/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ComponentId,Brand,ModelNumber,ModelName,Rating,ProductCode,Price,HardDriveId,Capacity,IsSSD")] HardDrive hardDrive)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hardDrive).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hardDrive);
        }

        // GET: HardDrives/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HardDrive hardDrive = (HardDrive)db.Components.Find(id);
            if (hardDrive == null)
            {
                return HttpNotFound();
            }
            return View(hardDrive);
        }

        // POST: HardDrives/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HardDrive hardDrive = (HardDrive)db.Components.Find(id);
            db.Components.Remove(hardDrive);
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
