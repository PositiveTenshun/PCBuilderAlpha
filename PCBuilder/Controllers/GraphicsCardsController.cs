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
    public class GraphicsCardsController : Controller
    {
        private CapstoneModelContainer db = new CapstoneModelContainer();

        // GET: GraphicsCards
        public ActionResult Index()
        {
            return View(db.Components.OfType<GraphicsCard>().ToList());
        }

        // GET: GraphicsCards/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GraphicsCard graphicsCard = (GraphicsCard)db.Components.Find(id);
            if (graphicsCard == null)
            {
                return HttpNotFound();
            }
            return View(graphicsCard);
        }

        // GET: GraphicsCards/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GraphicsCards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ComponentId,Brand,ModelNumber,ModelName,Rating,ProductCode,Price,GraphicsCardId,GRAM,Type,Speed")] GraphicsCard graphicsCard)
        {
            if (ModelState.IsValid)
            {
                db.Components.Add(graphicsCard);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(graphicsCard);
        }

        // GET: GraphicsCards/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GraphicsCard graphicsCard = (GraphicsCard)db.Components.Find(id);
            if (graphicsCard == null)
            {
                return HttpNotFound();
            }
            return View(graphicsCard);
        }

        // POST: GraphicsCards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ComponentId,Brand,ModelNumber,ModelName,Rating,ProductCode,Price,GraphicsCardId,GRAM,Type,Speed")] GraphicsCard graphicsCard)
        {
            if (ModelState.IsValid)
            {
                db.Entry(graphicsCard).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(graphicsCard);
        }

        // GET: GraphicsCards/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GraphicsCard graphicsCard = (GraphicsCard)db.Components.Find(id);
            if (graphicsCard == null)
            {
                return HttpNotFound();
            }
            return View(graphicsCard);
        }

        // POST: GraphicsCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GraphicsCard graphicsCard = (GraphicsCard)db.Components.Find(id);
            db.Components.Remove(graphicsCard);
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
