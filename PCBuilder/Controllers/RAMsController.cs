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
    public class RAMsController : Controller
    {
        private CapstoneModelContainer db = new CapstoneModelContainer();

        // GET: RAMs
        public ActionResult Index()
        {
            return View(db.Components.OfType<RAM>().ToList());
        }

        // GET: RAMs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RAM rAM = (RAM)db.Components.Find(id);
            if (rAM == null)
            {
                return HttpNotFound();
            }
            return View(rAM);
        }

        // GET: RAMs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RAMs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ComponentId,Brand,ModelNumber,ModelName,Rating,ProductCode,Price,RAMId,Type,Memory")] RAM rAM)
        {
            if (ModelState.IsValid)
            {
                db.Components.Add(rAM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rAM);
        }

        // GET: RAMs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RAM rAM = (RAM)db.Components.Find(id);
            if (rAM == null)
            {
                return HttpNotFound();
            }
            return View(rAM);
        }

        // POST: RAMs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ComponentId,Brand,ModelNumber,ModelName,Rating,ProductCode,Price,RAMId,Type,Memory")] RAM rAM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rAM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rAM);
        }

        // GET: RAMs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RAM rAM = (RAM)db.Components.Find(id);
            if (rAM == null)
            {
                return HttpNotFound();
            }
            return View(rAM);
        }

        // POST: RAMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RAM rAM = (RAM)db.Components.Find(id);
            db.Components.Remove(rAM);
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
