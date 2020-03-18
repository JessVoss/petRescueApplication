using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using petRescueApplication.DAL;
using petRescueApplication.Models;

namespace petRescueApplication.Controllers
{
    [Authorize]
    public class AdoptionController : Controller
    {
        private AnimalContext db = new AnimalContext();

        // GET: Adoption
       
        public ActionResult Index()
        {
            var adoptions = db.Adoptions.Include(a => a.Animal).Include(a => a.Patron);
            return View(adoptions.ToList());
        }

        // GET: Adoption/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adoption adoption = db.Adoptions.Find(id);
            if (adoption == null)
            {
                return HttpNotFound();
            }
            return View(adoption);
        }

        // GET: Adoption/Create
        public ActionResult Create()
        {
            ViewBag.AnimalID = new SelectList(db.Animals, "ID", "AnimalsName");
            ViewBag.PatronID = new SelectList(db.Patrons, "ID", "FirstName");
            return View();
        }

        // POST: Adoption/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,AnimalID,PatronID")] Adoption adoption)
        {
            if (ModelState.IsValid)
            {
                db.Adoptions.Add(adoption);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AnimalID = new SelectList(db.Animals, "ID", "AnimalsName", adoption.AnimalID);
            ViewBag.PatronID = new SelectList(db.Patrons, "ID", "FirstName", adoption.PatronID);
            return View(adoption);
        }

        // GET: Adoption/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adoption adoption = db.Adoptions.Find(id);
            if (adoption == null)
            {
                return HttpNotFound();
            }
            ViewBag.AnimalID = new SelectList(db.Animals, "ID", "AnimalsName", adoption.AnimalID);
            ViewBag.PatronID = new SelectList(db.Patrons, "ID", "FirstName", adoption.PatronID);
            return View(adoption);
        }

        // POST: Adoption/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,AnimalID,PatronID")] Adoption adoption)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adoption).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AnimalID = new SelectList(db.Animals, "ID", "AnimalsName", adoption.AnimalID);
            ViewBag.PatronID = new SelectList(db.Patrons, "ID", "FirstName", adoption.PatronID);
            return View(adoption);
        }

        // GET: Adoption/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adoption adoption = db.Adoptions.Find(id);
            if (adoption == null)
            {
                return HttpNotFound();
            }
            return View(adoption);
        }

        // POST: Adoption/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Adoption adoption = db.Adoptions.Find(id);
            db.Adoptions.Remove(adoption);
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
