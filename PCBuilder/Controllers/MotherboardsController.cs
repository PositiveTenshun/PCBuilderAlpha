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
    public class MotherboardsController : Controller
    {
        private CapstoneModelContainer db = new CapstoneModelContainer();

        // GET: Motherboards
        public ActionResult Index()
        {
            return View(db.Components.OfType<Motherboard>().ToList());
        }

        // GET: Motherboards/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motherboard motherboard = (Motherboard)db.Components.Find(id);
            if (motherboard == null)
            {
                return HttpNotFound();
            }
            return View(motherboard);
        }

        // GET: Motherboards/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Motherboards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ComponentId,Brand,ModelNumber,ModelName,Rating,ProductCode,Price,MotherboardId,Pins,PCISlots,Connectors,Chips,MemorySlots,Type")] Motherboard motherboard)
        {
            if (ModelState.IsValid)
            {
                db.Components.Add(motherboard);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(motherboard);
        }

        // GET: Motherboards/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motherboard motherboard = (Motherboard)db.Components.Find(id);
            if (motherboard == null)
            {
                return HttpNotFound();
            }
            return View(motherboard);
        }

        // POST: Motherboards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ComponentId,Brand,ModelNumber,ModelName,Rating,ProductCode,Price,MotherboardId,Pins,PCISlots,Connectors,Chips,MemorySlots,Type")] Motherboard motherboard)
        {
            if (ModelState.IsValid)
            {
                db.Entry(motherboard).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(motherboard);
        }

        // GET: Motherboards/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motherboard motherboard = (Motherboard)db.Components.Find(id);
            if (motherboard == null)
            {
                return HttpNotFound();
            }
            return View(motherboard);
        }

        // POST: Motherboards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Motherboard motherboard = (Motherboard)db.Components.Find(id);
            db.Components.Remove(motherboard);
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
