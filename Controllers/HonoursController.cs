using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MonashUWCC.Models;

namespace MonashUWCC.Controllers
{
    public class HonoursController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Honours
        public ActionResult Index()
        {
            return View(db.Honours.ToList());
        }

        // GET: Honours/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Honour honour = db.Honours.Find(id);
            if (honour == null)
            {
                return HttpNotFound();
            }
            return View(honour);
        }

        // GET: Honours/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Honours/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tl")] Honour honour)
        {
            if (ModelState.IsValid)
            {
                db.Honours.Add(honour);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(honour);
        }

        // GET: Honours/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Honour honour = db.Honours.Find(id);
            if (honour == null)
            {
                return HttpNotFound();
            }
            return View(honour);
        }

        // POST: Honours/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Tl")] Honour honour)
        {
            if (ModelState.IsValid)
            {
                db.Entry(honour).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(honour);
        }

        // GET: Honours/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Honour honour = db.Honours.Find(id);
            if (honour == null)
            {
                return HttpNotFound();
            }
            return View(honour);
        }

        // POST: Honours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Honour honour = db.Honours.Find(id);
            db.Honours.Remove(honour);
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
