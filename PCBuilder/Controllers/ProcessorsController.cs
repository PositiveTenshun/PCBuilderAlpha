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
    public class ProcessorsController : Controller
    {
        private CapstoneModelContainer db = new CapstoneModelContainer();

        // GET: Processors
        public ActionResult Index()
        {
            return View(db.Components.OfType<Processor>().ToList());
        }

        // GET: Processors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Processor processor = (Processor)db.Components.Find(id);
            if (processor == null)
            {
                return HttpNotFound();
            }
            return View(processor);
        }

        // GET: Processors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Processors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ComponentId,Brand,ModelNumber,ModelName,Rating,ProductCode,Price,ProcessorId,Speed,Memory,Pins")] Processor processor)
        {
            if (ModelState.IsValid)
            {
                db.Components.Add(processor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(processor);
        }

        // GET: Processors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Processor processor = (Processor)db.Components.Find(id);
            if (processor == null)
            {
                return HttpNotFound();
            }
            return View(processor);
        }

        // POST: Processors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ComponentId,Brand,ModelNumber,ModelName,Rating,ProductCode,Price,ProcessorId,Speed,Memory,Pins")] Processor processor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(processor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(processor);
        }

        // GET: Processors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Processor processor = db.Components.Find(id);
            Processor processor = (Processor)db.Components.Find(id);
            if (processor == null)
            {
                return HttpNotFound();
            }
            return View(processor);
        }

        // POST: Processors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Processor processor = (Processor)db.Components.Find(id);
            db.Components.Remove(processor);
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
