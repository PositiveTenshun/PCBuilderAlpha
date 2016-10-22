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
    public class PowerSuppliesController : Controller
    {
        private CapstoneModelContainer db = new CapstoneModelContainer();

        // GET: PowerSupplies
        public ActionResult Index()
        {
            return View(db.Components.OfType<PowerSupply>().ToList());
        }

        // GET: PowerSupplies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PowerSupply powerSupply = (PowerSupply)db.Components.Find(id);
            if (powerSupply == null)
            {
                return HttpNotFound();
            }
            return View(powerSupply);
        }

        // GET: PowerSupplies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PowerSupplies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ComponentId,Brand,ModelNumber,ModelName,Rating,ProductCode,Price,PowerSupplyId,Wattage,Connections")] PowerSupply powerSupply)
        {
            if (ModelState.IsValid)
            {
                db.Components.Add(powerSupply);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(powerSupply);
        }

        // GET: PowerSupplies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PowerSupply powerSupply = (PowerSupply)db.Components.Find(id);
            if (powerSupply == null)
            {
                return HttpNotFound();
            }
            return View(powerSupply);
        }

        // POST: PowerSupplies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ComponentId,Brand,ModelNumber,ModelName,Rating,ProductCode,Price,PowerSupplyId,Wattage,Connections")] PowerSupply powerSupply)
        {
            if (ModelState.IsValid)
            {
                db.Entry(powerSupply).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(powerSupply);
        }

        // GET: PowerSupplies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PowerSupply powerSupply = (PowerSupply)db.Components.Find(id);
            if (powerSupply == null)
            {
                return HttpNotFound();
            }
            return View(powerSupply);
        }

        // POST: PowerSupplies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PowerSupply powerSupply = (PowerSupply)db.Components.Find(id);
            db.Components.Remove(powerSupply);
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
