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
    public class AlphaCreateController : Controller
    {
        private CapstoneModelContainer db = new CapstoneModelContainer();

        // GET: AlphaCreate
        public ActionResult Index()
        {
            return View(db.Builds.ToList());
        }

        // GET: AlphaCreate/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Build build = db.Builds.Find(id);
            if (build == null)
            {
                return HttpNotFound();
            }
            return View(build);
        }

        // GET: AlphaCreate/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlphaCreate/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BuildId,BuildName,Description,Rating,TotalPrice")] Build build)
        {
            if (ModelState.IsValid)
            {
                db.Builds.Add(build);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(build);
        }

        // GET: AlphaCreate/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Build build = db.Builds.Find(id);
            if (build == null)
            {
                return HttpNotFound();
            }
            return View(build);
        }

        // POST: AlphaCreate/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BuildId,BuildName,Description,Rating,TotalPrice")] Build build)
        {
            if (ModelState.IsValid)
            {
                db.Entry(build).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(build);
        }

        // GET: AlphaCreate/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Build build = db.Builds.Find(id);
            if (build == null)
            {
                return HttpNotFound();
            }
            return View(build);
        }

        // POST: AlphaCreate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Build build = db.Builds.Find(id);
            db.Builds.Remove(build);
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
