﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CIS420TeamA.Models;

namespace CIS420TeamA.Controllers
{
    public class TestimonialsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Testimonials
        public ActionResult Index()
        {
            return View(db.Testimonials.ToList());
        }

        // GET: Testimonials/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Testimonials testimonials = db.Testimonials.Find(id);
            if (testimonials == null)
            {
                return HttpNotFound();
            }
            return View(testimonials);
        }

        // GET: Testimonials/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Testimonials/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID")] Testimonials testimonials)
        {
            if (ModelState.IsValid)
            {
                db.Testimonials.Add(testimonials);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(testimonials);
        }

        // GET: Testimonials/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Testimonials testimonials = db.Testimonials.Find(id);
            if (testimonials == null)
            {
                return HttpNotFound();
            }
            return View(testimonials);
        }

        // POST: Testimonials/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID")] Testimonials testimonials)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testimonials).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testimonials);
        }

        // GET: Testimonials/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Testimonials testimonials = db.Testimonials.Find(id);
            if (testimonials == null)
            {
                return HttpNotFound();
            }
            return View(testimonials);
        }

        // POST: Testimonials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Testimonials testimonials = db.Testimonials.Find(id);
            db.Testimonials.Remove(testimonials);
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
