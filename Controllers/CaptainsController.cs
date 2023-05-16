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
    public class CaptainsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Captains
        public ActionResult Index()
        {
            return View(db.Captains.ToList());
        }

        // GET: Captains/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Captain captain = db.Captains.Find(id);
            if (captain == null)
            {
                return HttpNotFound();
            }
            return View(captain);
        }

        // GET: Captains/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Captains/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CaptainName,ViceCaptainName,Team,Year")] Captain captain)
        {
            if (ModelState.IsValid)
            {
                db.Captains.Add(captain);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(captain);
        }

        // GET: Captains/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Captain captain = db.Captains.Find(id);
            if (captain == null)
            {
                return HttpNotFound();
            }
            return View(captain);
        }

        // POST: Captains/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CaptainName,ViceCaptainName,Team,Year")] Captain captain)
        {
            if (ModelState.IsValid)
            {
                db.Entry(captain).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(captain);
        }

        // GET: Captains/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Captain captain = db.Captains.Find(id);
            if (captain == null)
            {
                return HttpNotFound();
            }
            return View(captain);
        }

        // POST: Captains/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Captain captain = db.Captains.Find(id);
            db.Captains.Remove(captain);
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
